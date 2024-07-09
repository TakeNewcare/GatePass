using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatePass
{
    public partial class UpdateVisitor : Form
    {
        DatabaseOperation databaseOperation = new DatabaseOperation();
        string qry;
        DataSet ds;


        public UpdateVisitor()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        bool isvisitorFound = false;  // 방문자를 찾은 상태를 기록한다. =>  방문자를 찾지 않고 수기로 적었을 경우를 거른다.

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string visitorId = txtVisitor.Text;
                qry = $"select * from visitors where visitorId = '{visitorId}'";
                ds = databaseOperation.getData(qry);

                if (ds != null && ds.Tables[0].Rows.Count != 0)
                {
                    isvisitorFound = true;    // 찾으면 true
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtUniqueId.Text = ds.Tables[0].Rows[0][5].ToString();
                    Utility.setImageInpictureBox(pictureBox1, visitorId);   // 픽쳐박스에 해당 이미지를 찾아서 넣어준다.

                }
                else
                {
                    isvisitorFound = false;

                    MessageBox.Show("등록하지 않은 방문자 번호 입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }



        // 필드 초기화
        private void clearAllFields()
        {

            txtName.Clear();
            txtContact.Clear();
            txtGender.SelectedIndex = -1;
            txtAddress.Clear();
            txtUniqueId.Clear();
            isvisitorFound = false;
            if(pictureBox1.Image != null){
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }


        // 숫자로만 제한
        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }

        private void txtVisitor_TextChanged(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string visitorId = txtVisitor.Text;  // 이미지 이름을 방문자 번호와 같게 하기 위해 

            if (isvisitorFound)           // 방문자를 찾았다면 true 변환된 상태, 방문자를 찾지 않고 수기로 적었을 경우를 거른다.
            {
                string path = Utility.getImageStorePath(visitorId); // 이미지의 절대 경로를 가져오기
                OpenFileDialog open = new OpenFileDialog(); // 파일 열어주는 클래스 생성
                open.InitialDirectory = "C:\\"; // 최소 경로 설정
                open.Filter = "(*.jpg;*.jpeg;*.bmp;) | *.jpg; *.jpeg; *.bmp;"; // 필터 추가
                open.FilterIndex = 1;// 필터 인덱스 : 설정한 여러개의 필터 중 첫번째 필터를 선택된 채로 생성

                if (open.ShowDialog()== DialogResult.OK)
                {
                    // open.CheckFileExists : 사용자가 이미지를 선택했는지 취소했는지 검사하는 속성으로 기본값이 true이다.
                    if (open.CheckFileExists)
                    {
                        if (!File.Exists(path))  // 해당 경로에 파일이 없다면
                        {
                            System.IO.File.Copy(open.FileName, path);       // 파일 이름으로 경로에다가 복사할거다
                        }
                        else   // 해당 경로에 파일이 있어 파일을 교체해야한다면
                        {
                            pictureBox1.Image.Dispose(); // 픽쳐박스에 이미지 제거
                            pictureBox1.Image = null;
                            string name = open.FileName;
                            System.IO.File.Delete(path); // path 경로의 이미지 폴더에 변경 전의 이미지 제거
                            System.IO.File.Copy(name, path); // path 경로에 새 이미지를 저장한다.
                        }
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // 픽쳐박스 사이즈 모드 설정
                        pictureBox1.Image = Image.FromFile(path); // 픽쳐박스 이미지 파일 설정


                    }
                }
             

            }
            else         // 방문자를 선택하기 전에 이미지를 클릭하면 오류를 설정하기 위해
            {
                MessageBox.Show("찾는 방문자가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string contact = txtContact.Text;
                string gender = txtGender.Text;
                string address = txtAddress.Text;
                string uniqueId = txtUniqueId.Text;
                string visitorId = txtVisitor.Text;
                if (isvisitorFound)   // 방문자를 찾았다면 true 변환된 상태, 방문자를 찾지 않고 수기로 적었을 경우를 거른다.
                {
                    if (!string.IsNullOrEmpty(name) &&
                        !string.IsNullOrEmpty(contact) &&
                        !string.IsNullOrEmpty(gender) &&
                        !string.IsNullOrEmpty(address) &&
                        !string.IsNullOrEmpty(uniqueId) &&
                        !string.IsNullOrEmpty(visitorId)
                        )
                    {
                        Int64 number = Int64.Parse(contact);

                        qry = $"update visitors set vname = '{name}', contact = {number}, gender = '{gender}', vaddress = '{address}', uniqueID='{uniqueId}', visitorID = '{visitorId}' where visitorID = '{visitorId}' ";
                        databaseOperation.setDate(qry, "방문자 정보를 수정하였습니다.");
                        clearAllFields();

                    }
                    else  // 비어있는 필드가 있다면
                    {
                        MessageBox.Show("정보 입력 필수", "중요", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else   // 수기로 적었을 경우 오류
                {
                    MessageBox.Show("방문자 정보 검색해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something wnt wrong : "+ ex, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtVisitor_Click(object sender, EventArgs e)
        {
            txtVisitor.Text = "";
        }
    }
}
