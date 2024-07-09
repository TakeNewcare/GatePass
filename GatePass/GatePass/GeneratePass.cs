using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatePass
{
    public partial class GeneratePass : Form
    {
        DatabaseOperation databaseOperation = new DatabaseOperation();
        DataSet ds = new DataSet();
        string qry;


        public GeneratePass()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GeneratePass_Load(object sender, EventArgs e)
        {
            qry = "select * from visitors";
            ds = databaseOperation.getData(qry);
            //dataGridView1.DataSource = ds.Tables[0]; 모든 데이터 때려박는 방식

            DataTable dt = ds.Tables[0];

            for (int i=0; i< dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j =0; j <dataGridView1.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = dt.Rows[i][j];
                }
            }

            pictureBox1.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Yellow;
            pictureBox3.BackColor = Color.SkyBlue;
        }

        // 검색 기능
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string searchTect = txtSearch.Text;
            qry = $"select * from visitors where vname like '%{searchTect}%' or uniqueID like '%{searchTect}%' or visitorID like '%{searchTect}%'";
            ds = databaseOperation.getData(qry);
            // dataGridView1.DataSource = ds.Tables[0];

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count == 1)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = dt.Rows[i][j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = dt.Rows[i][j];
                    }
                }
            }

        }

        string passId;
        string path;            
        Int64 visitorPk;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try {
                // 데이터 베이스에 이름 텍스트로 저장된 이미지 이름을 이용하여 images 폴더에서 해당 이미지를 찾는다
                path = Application.StartupPath.Substring(0, (Application.StartupPath.Length -10))+ "\\Images\\" + dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() + ".jpg";

                passId = Utility.getUniqueId("PID-");  // PID- 문자를 붙여 특별한 번호 생성

                visitorPk = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());  // 클릭된 셀의 첫번째 열의 값을 visitorPk 변수에 할당

                lblPassID.Text = passId;
                lblName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblContact.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblGender.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (pictureBoxProfile.Image != null)
                {
                    pictureBoxProfile.Image.Dispose();
                    pictureBoxProfile.Image = null;
                }
                pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxProfile.Image = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        // 통행일 수에 따라 배경색 변경
        private void setPassColor(int days)
        {
            if (days == 0)
            {
                panel1.BackColor = Color.Gray;
            }else if (days <= 6)
            {
                panel1.BackColor = Color.Yellow;
            }
            else
            {
                panel1.BackColor = Color.SkyBlue;
            }
        }

        //private void compareDate(string input)
        //{
        //    DateTime dT = DateTime.Now;
        //    DateTime inputDt = DateTime.ParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        //    int result = DateTime.Compare(dT, inputDt);  

        //    Console.WriteLine(result);
        //}


        // yyyy.MM.dd 형식에 맞는 유효한 날짜인지를 검사, 날짜가 오늘 이전이거나 오늘과 같지를 확인
        public static bool IsDateBeforeOrToday(string input)
        {
            DateTime pDate;

            // input을 dd.MM.yyyy로 해석하여 dateTime 객체 pDate로 변환시도, 변환된 결과가 pDate에 저장되고 true값을 반환한다.
            // 변환에 성공하여  true 값을 전달하면 ! 에 의해 false로 변환되고 if문을 빠져나온다.
            if (!DateTime.TryParseExact(input, "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out pDate))
            {
                return false;
            }

            // 현재날짜와 pDate 날짜를 비교하여 현재날짜가 크면 false, 같거나 작으면 true를 반환
            return DateTime.Today <= pDate;
        }

        // 종료일이 시작일 이후인지 판단
        public static bool IsDateAfterValidFrom(string date, string dateFrom)
        {
            DateTime validTo, ValidFrom;

            // 시작일과 종료일을 받아 변환이 가능한지 판단하고 

            if (!DateTime.TryParseExact(date, "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out validTo))
            {
                return false ;
            }

            if (!DateTime.TryParseExact(dateFrom, "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out ValidFrom))
            {
                return false ;
            }

            return ValidFrom <= validTo;

        }


        // 날짜가 변경되면
        private void dateTimePickerValidFrom_ValueChanged(object sender, EventArgs e)
        {
            // 변경된 날짜가 오늘 이후인지 검사
            if (IsDateBeforeOrToday(dateTimePickerValidFrom.Text))
            {
                lblVaildFrom.Text = dateTimePickerValidFrom.Text;
            }
            else
            {
                MessageBox.Show("오늘이나 이 후의 날짜를 선택해주세요", "정보", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // 종료 시점을 정할 때 시작 시점보다 이 후인지 
        int days;
        private void dateTimePickerVaildTo_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblVaildFrom.Text))
            {
                if (IsDateAfterValidFrom(dateTimePickerValidTo.Text, lblVaildFrom.Text))
                {
                    lblVaildTo.Text = dateTimePickerValidTo.Text;
                    // 형식 변환 후 변수에 초기화
                    DateTime startDate = DateTime.ParseExact(lblVaildFrom.Text, "yyyy.MM.dd", CultureInfo.InvariantCulture);
                    DateTime EndDate = DateTime.ParseExact(lblVaildTo.Text, "yyyy.MM.dd", CultureInfo.InvariantCulture);

                    days = (EndDate.Date - startDate.Date).Days;
                    setPassColor(days);
                }
                else
                {
                    MessageBox.Show("시작일 이 후의 날짜를 선택해 주세요", "정보", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("시작 " +
                    "날짜를 선택해 주세요", "정보", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void reset()
        {
            lblPassID.ResetText();
            lblName.ResetText();
            lblContact.ResetText();
            lblGender.ResetText();
            lblVaildFrom.ResetText();
            lblVaildTo.ResetText();

            if (pictureBoxProfile.Image != null)
            {
                pictureBoxProfile.Image.Dispose();
                pictureBoxProfile.Image = null;
            }
        }

        // 통행증 생성
        private void btnGenerate_Click(object sender, EventArgs e)
        {

            string passId = lblPassID.Text;
            string name = lblName.Text; 
            string contact = lblContact.Text;
            string gender = lblGender.Text;
            string vaildFrom = lblVaildFrom.Text;
            string vailTo = lblVaildTo.Text;

            if (!string.IsNullOrEmpty(passId) &&
                !string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(contact) &&
                !string.IsNullOrEmpty(gender) &&
                !string.IsNullOrEmpty(vaildFrom) &&
                !string.IsNullOrEmpty(vailTo) )
            {
                // 통행증 생성
                Pass p= new Pass(path, passId, name, contact, gender, vaildFrom, vailTo, visitorPk, days);
                p.Show();
                reset();

            }
            else
            {
                MessageBox.Show("선택을 완료해 주세요", "정보", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
