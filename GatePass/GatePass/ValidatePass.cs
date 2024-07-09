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
    public partial class ValidatePass : Form
    {
        DatabaseOperation databaseOperation = new DatabaseOperation();
        string qry;
        DataSet ds;


        public ValidatePass()
        {
            InitializeComponent();
        }

        // 로드 시 데이터를 불러온다.
        private void ValidatePass_Load(object sender, EventArgs e)
        {
            qry = "select v.*, p.passID, p.validFrom, p.validTo from visitors as v inner join pass as p on v.visitors_pk=p.visitors_fk";
            ds = databaseOperation.getData(qry);
            // dataGridView1.DataSource = ds.Tables[0];

            DataTable dt = ds.Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridViewVisitor.Rows.Add();  // 행 추가

                for (int j = 0; j < dataGridViewVisitor.Columns.Count; j++)  // 추가된 행에 데이터를 연결
                {
                    dataGridViewVisitor.Rows[i].Cells[j].Value = dt.Rows[i][j];

                }
            }



            pictureBox1.BackColor = Color.LightGreen;
            pictureBox2.BackColor = Color.IndianRed;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 현재 날짜와 만료일을 비교한다
        public static bool IsDateAfterTodayOrToday(string input)
        {
            input = input.Replace("오전 ","");
            input = input.Replace("오후 ","");

            // 고쳐야한다!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 24:00
            DateTime pDate;
            if (!DateTime.TryParseExact(input, "yyyy-MM-dd hh:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out pDate))
            {
                return false;
            }
            return DateTime.Today <= pDate;
        }

        string path;
        Int64 visitorPk;

        // 클릭 시 하단의 창에 데이터 삽입
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {

                path = Utility.getImageStorePath(dataGridViewVisitor.Rows[e.RowIndex].Cells[6].Value.ToString());  // 열의 일곱번째 값인이름을 전달해서 경로에 있는 사진을 가져온다

                visitorPk = Int64.Parse(dataGridViewVisitor.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblPassID.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[7].Value.ToString();
                lblName.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblContact.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblGender.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[3].Value.ToString();

                lblVaildFrom.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[8].Value.ToString();
                lblVaildTo.Text = dataGridViewVisitor.Rows[e.RowIndex].Cells[9].Value.ToString();


                if (IsDateAfterTodayOrToday(dataGridViewVisitor.Rows[e.RowIndex].Cells[9].Value.ToString()))  // 현재날짜와 만료일을 비교해 색깔 설정
                {
                    panel1.BackColor = Color.LightGreen;
                }
                else
                {
                    panel1.BackColor = Color.IndianRed;
                }

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

        string txt;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txt = txtSearch.Text;
            qry = $"select v.*, p.passID, p.validFrom, p.validTo from visitors as v inner join pass as p on v.visitors_pk=p.visitors_fk where p.passID like '%{txt}%' or v.visitorID like '%{txt}%' or v.vname like '%{txt}%'";
            ds = databaseOperation.getData(qry);
            // dataGridView1.DataSource = ds.Tables[0];

            DataTable dt = ds.Tables[0];


            if (txtSearch.Text != "")
            {
                dataGridViewVisitor.Rows.Clear();
            }

            if (dt.Rows.Count == 1) 
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewVisitor.Rows[i].Cells.Count; j++)
                    {
                        dataGridViewVisitor.Rows[i].Cells[j].Value = dt.Rows[i][j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++) 
                {
                    dataGridViewVisitor.Rows.Add();   
                    for (int j = 0; j < dataGridViewVisitor.Rows[i].Cells.Count; j++)
                    {
                        dataGridViewVisitor.Rows[i].Cells[j].Value = dt.Rows[i][j];
                    }
                }
            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
