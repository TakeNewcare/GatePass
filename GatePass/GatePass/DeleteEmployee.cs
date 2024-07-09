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
    public partial class DeleteEmployee : Form
    {
        DatabaseOperation databaseOperation = new DatabaseOperation();
        string qry;
        DataSet ds;
        bool employeeAvailable = false;

        public DeleteEmployee()
        {
            InitializeComponent();
        }

        // 아이디로 직원 검색하는 버튼
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try {
            
                string username = txtUsername.Text;
                qry = $"select e.*, a.* from employee as e inner join appUser as a on e.appuser_fk = a.appuser_pk where a.username = '{username}'"; 

                ds = databaseOperation.getData(qry);

                if (ds != null && ds.Tables[0].Rows.Count != 0)  // 아이디는 중복 가입이 불가능하게 설정했기 때문에 한 행만 나온다.
                {
                    employeeAvailable = true;
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtHireDate.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtState.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    employeeAvailable = false;
                    MessageBox.Show("해당 직원을 찾을 수 없습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            } catch (Exception ex)
            {
                Console.WriteLine("직원 삭제 오류 : " + ex);
            }
        }

        // 닫기 버튼
        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("닫으시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                this.Close();

            }
        }

        // 초기화 기능
        private void clearAllFields()
        {
            txtAddress.Clear();
            txtCity.Clear();
            txtContact.Clear();
            txtGender.SelectedIndex = -1;
            txtHireDate.ResetText();  //  ==> 실행하는 당일의 날짜로 바꾼다.
            txtName.Clear();
            txtState.Clear();
            employeeAvailable = false;
        }

        // 초기화 버튼
        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }


        // txtUsername.Text에 해당하는 employee, appUser 테이블의 데이터 삭제
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                if (employeeAvailable)
                {
                    // appUser의 username 항목 중 appUserpk와 appUser_fk가 일치하는 employee 행을 삭제해라
                    qry = $"delete from employee from appUser where appuser_fk = appuser_pk and username = '{txtUsername.Text}'";
                    databaseOperation.setDate(qry, "삭제 완료");
                    qry = $"delete from appUser where username = '{txtUsername.Text}'";
                    databaseOperation.setDate(qry, null);
                    clearAllFields();
                }
                else
                {
                    employeeAvailable = false ;
                    MessageBox.Show("직원을 찾을 수 없습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("직원 삭제 오류 : " + ex);
            }
        }

        // 한번 검색 후 다른 username으로 변경하려고 할 때 모든 필드 데이터가 초기화 된다.
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            clearAllFields() ;
        }
    }
}
