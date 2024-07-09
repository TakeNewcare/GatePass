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
    public partial class ViewVisitors : Form
    {
        DatabaseOperation databaseOperation = new DatabaseOperation();
        string qry;
        DataSet ds;


        public ViewVisitors()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 화면을 로드하면 방문자 데이터 가져와서 그리드에 보여주기
        private void ViewVisitors_Load(object sender, EventArgs e)
        {
            try {
                qry = "select * from visitors";
                ds = databaseOperation.getData(qry);
                // dataGridView1.DataSource = ds.Tables[0];            // 그리드 설정해서 필요한 데이터만 붙여보기!!!!!!!

                DataTable dt = ds.Tables[0];

                for (int i=0; i< dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();

                    for (int j=0; j< dataGridView1.Columns.Count; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            try
            {
                qry = $"select * from visitors where vname like '%{txtSearch.Text}%' or visitorID like '%{txtSearch.Text}%'";
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
