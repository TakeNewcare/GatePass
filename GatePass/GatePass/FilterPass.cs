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
    public partial class FilterPass : Form
    {
        DatabaseOperation databaseOperation = new DatabaseOperation();
        string qry;
        DataSet ds;

        public FilterPass()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void FilterPass_Load(object sender, EventArgs e)
        {
            qry = "select v.*, p.passID, p.validFrom, p.validTo from visitors as v inner join pass as p on v.visitors_pk=p.visitors_fk";
            ds = databaseOperation.getData(qry);

            DataTable dt = ds.Tables[0];


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("발급된 통행증이 없습니다.");
            }
            else
            {
                // dataGridViewVisitor.DataSource = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridViewVisitor.Rows.Add();  

                    for (int j = 0; j < dataGridViewVisitor.Columns.Count; j++)  
                    {
                        dataGridViewVisitor.Rows[i].Cells[j].Value = dt.Rows[i][j];

                    }
                }



                string aa = dt.Rows[0][9].ToString();
            }
        }



        // 문제가 있다!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void dateTimePickerValidFrom_ValueChanged(object sender, EventArgs e)
        {
            DateTime pickedDate = DateTime.ParseExact(dateTimePicker.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string selectdDate = pickedDate.ToString("yyyy-MM-dd");


            
            if (string.IsNullOrEmpty(filterType))  // filterType에 값이 비어있는지 확인
            {
                MessageBox.Show("필터 형식을 설정해주세요", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if("From".Equals(filterType))
            {
                qry = $"select v.*, p.passID, p.validFrom, p.validTo from visitors as v inner join pass p on v.visitors_pk = p.visitors_fk where p.validFrom like '%{selectdDate}%'; ";
            }else if ("To".Equals(filterType))
            {
                qry = $"select v.*, p.passID, p.validFrom, p.validTo from visitors as v inner join pass p on v.visitors_pk = p.visitors_fk where p.validTo like '%{selectdDate}%'; ";
            }
            else  // 그냥 실패했을 경우
            {
                FilterPass_Load(this, null);   // this : 현재 자기 자신, null : EventArgs 형식으로 이벤트 발생 시 추가 정보를 전달할 때 사용
            }

            // 정해진 쿼리를 실행하고 데이터를 가져온다
            ds = databaseOperation.getData(qry);
            dataGridViewVisitor.DataSource = ds;

        }


        string filterType = null;
        private void txtFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterType = txtFilterType.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FilterPass_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                dataGridViewVisitor.Rows.Clear();
            }


            qry = $"select v.*, p.passID, p.validFrom, p.validTo from visitors as v inner join pass as p on v.visitors_pk = p.visitors_fk where p.passID like '%{txtSearch.Text}%' or v.visitorID like '%{txtSearch.Text}%' or v.vname like '%{txtSearch.Text}%'";
            ds = databaseOperation.getData(qry);
            //dataGridViewVisitor.DataSource = ds;

            DataTable dt = ds.Tables[0];


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

        private void dataGridViewVisitor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsDateAfterTodayOrToday(dataGridViewVisitor.Rows[e.RowIndex].Cells[9].Value.ToString()))  // 종료일이 남았다면 true
            {
                panel1.BackColor = Color.LightGreen;
                lblStatus.Text = "유효한 통행증";
            }
            else
            {
                panel1.BackColor = Color.IndianRed;
                lblStatus.Text = "만료된 통행증";
            }
        }

        private bool IsDateAfterTodayOrToday(string input)
        {

            input = input.Replace("오전 ", "");
            input = input.Replace("오후 ", "");

            DateTime pDate; // 클릭한 종료일
            if (!DateTime.TryParseExact(input, "yyyy-MM-dd hh:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out pDate))  // 형변환 실패 시 false + ! => true
            {
                return false;
            }
            return DateTime.Today <= pDate;  // 종료일이 아직 남았다면 true
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
