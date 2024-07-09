using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GatePass
{
    public partial class AddVisitor : Form
    {
        DatabaseOperation databaseOperation = new DatabaseOperation();
        string qry;


        public AddVisitor()
        {
            InitializeComponent();
        }


        string visitorId;  // 방문자 고유 번호
        Boolean imageUploaded = false;      // 이미지가 업로드 되었느냐
        string path;    // 방문자 이미지 

        private void AddVisitor_Load(object sender, EventArgs e)
        {
            visitorId = Utility.getUniqueId("VID-");  // 고유 id 생성

            txtVisitor.Text = visitorId;


            // 저장 경로,형식 설정
            // pictureBox1_Click 에서 해당 경로를 찾아가 
            path = Application.StartupPath.Substring(0, (Application.StartupPath.Length-10)) + "\\Images\\" + visitorId + ".jpg";
        }


        // 컴퓨터에 있는 이미지를 프로젝트 내에서 임의적으로 다루는 이미지 폴더 파일에 저장한다.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";  // 초기 디렉터리 설정
            open.Filter = "(*.jpg; *.jpeg; *.bmp;)| *.jpg; *.jpeg; *.bmp;";
            open.FilterIndex = 1;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)      // 파일이 선택되었을 때
            {
                if (open.CheckFileExists) // 실제 디스크에 존재 하는지 판단
                {
                    if (!File.Exists(path))  // path라는 경로에 파일이 존재하지 않으면
                    {
                        System.IO.File.Copy(open.FileName, path);  // open.FileName : 지정한 경로 및 이름(path)으로 해당 파일을 복사
                    }
                    else  // 이미 경로에 파일이 있으면
                    {
                        pictureBox1.Image.Dispose();  // 프로그램 상의 리소스 해제
                        pictureBox1.Image = null;       // 기존 이미지 제거
                        System.IO.File.Delete(path);         // 기존 파일 삭제
                        System.IO.File.Copy (open.FileName, path);       // 새로 선택한 파일을 지정된 경로에 복사
                    }
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromFile(path);        // PictureBox에 지정된 경로에서 이미지 파일 로드
                    imageUploaded = true;           // 이미지가 업로드 되었느냐

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                
                string name = txtName.Text;
                string contact = txtContact.Text;
                string gender = txtGender.Text;
                string address = txtAddress.Text;
                string uniqueId = txtUniqueId.Text;

                if (imageUploaded)  // 이미지 업로드 되었니?
                {
                    if (!string.IsNullOrEmpty(name) &&
                        !string.IsNullOrEmpty(contact) &&
                        !string.IsNullOrEmpty(gender) &&
                        !string.IsNullOrEmpty(address) &&
                        !string.IsNullOrEmpty(uniqueId))
                    {
                        Int64 contactNum = Int64.Parse(contact);
                        qry = $"insert into visitors (vname,contact,gender,vaddress,uniqueID,visitorID) values ('{name}', {contact}, '{gender}', '{address}', '{uniqueId}', '{visitorId}')";
                        databaseOperation.setDate(qry, "방문자 추가 완료");
                        clearAllFields();

                    }
                    else
                    {
                        MessageBox.Show("입력 필드를 모두 채워주세요","경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
                else
                {
                    MessageBox.Show("이미지가 업로드되지 않았습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("방문자 이미지 저장 오류 : " + ex.Message);
                MessageBox.Show("Something went wrong : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // contact 필드에 숫자만 입력하게 하기
        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }


        private void clearAllFields()
        {
            txtName.Clear();
            txtUniqueId.Clear();
            txtGender.SelectedIndex = -1;
            txtContact.Clear();
            txtAddress.Clear();

            // 이미지 제거
            imageUploaded = false;
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

            AddVisitor_Load(this, null);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (imageUploaded)
            {
                if (MessageBox.Show("이미지가 삭제될 수 있습니다.", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    pictureBox1.Image.Dispose();        // 리소스 제거
                    pictureBox1.Image = null;           // 컨트롤에 표시된 화면 제거
                    System.IO.File.Delete(path);        // 파일 삭제
                    this.Close();
                }
            }
            else { 
            
                this.Close();
            
            }

        }
    }
}
