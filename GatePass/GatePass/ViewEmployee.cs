using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatePass
{
    public partial class ViewEmployee : Form
    {
        DatabaseOperation databaseOperation = new DatabaseOperation();
        string qry;
        DataSet ds;

        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // 폼이 로드될 때 등록된 모든 직원을 데이터그리드뷰에 작성하여 보여준다.
        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            try {

                qry = "select * from employee";
                ds = databaseOperation.getData(qry);

                DataTable dt = ds.Tables[0];

                for (int i=0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();  // 행 추가

                    for (int j = 0; j< dataGridView1.Columns.Count; j++)  // 추가된 행에 데이터를 연결
                    {
                        dataGridView1.Rows[i].Cells[j].Value = dt.Rows[i][j];

                    }
                }

                // dataGridView1.DataSource = ds.Tables[0];        // ★ 데이터 셋 : 테이터 테이블이 여러개 있는 형식이다.
                dataGridView1.ForeColor = System.Drawing.Color.Black;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        // 검색 텍스트박스에서 텍스트가 변경될 때 마다 실행하여 이메일 기준으로 찾는다.
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();  // 먼저 지운다기 보다, 검색 중 결과가 여러개라 행이 추가될 경우 계속 추가되는 것을 방지

            try
            {
                qry = $"select * from employee where eid like '%{txtSearch.Text}%'";
                ds = databaseOperation.getData(qry);
                //dataGridView1.DataSource = ds.Tables[0];

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count == 1) // 결과가 한개이면 datagridview의 기본 1행으로 채운다
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
                    for (int i = 0; i < dt.Rows.Count; i++) // 여러개이면 행을 생성해주면서 채우기
                    {
                        dataGridView1.Rows.Add();   // 
                        for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = dt.Rows[i][j];
                        }
                    }
                }
            }
            catch (Exception ex){
            Console.WriteLine(ex);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
