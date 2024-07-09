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
    public partial class UpadateEmployee : Form
    {
        DatabaseOperation databaseOperation = new DatabaseOperation();
        string qry;
        DataSet ds;  // 검색 결과 값을 저장할 테이블셋
        Boolean employeeAvailable = false;   // 해당 직원이 고용된 상태인지?

        public UpadateEmployee()
        {
            InitializeComponent();
        }
        // 검색버튼 클릭 시 아이디로 검색하여 데이터를 가져온다
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try {
                string username = txtUsername.Text;
                qry = $"select e.*, a.* from employee as e inner join appUser a on e.appuser_fk=a.appuser_pk where a.username = '{username}'";
                ds = databaseOperation.getData(qry);
                if (ds != null && ds.Tables[0].Rows.Count != 0)  // 
                {
                    employeeAvailable = true;  // 변경 가능

                    // 찾은 데이터로 데이터 입력해주기
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();  // 첫번째 인덱스에 네임이 들어간다는 것을 확인하기 위해 sql 실행해보기
                    txtHireDate.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtState.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else  // 검색 내용이 없을 경우
                {
                    employeeAvailable = false;
                    MessageBox.Show("해당 직원을 찾을 수 없습니다", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch(Exception ex) {
                Console.WriteLine(" 직원 정보 검색 오류: " + ex);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // 직원 정보를 수정하는 기능(아이디 값을 기준으로 찾고 아이디를 제외한 값들을 수정한다.)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try    // 모든 필드값을 변수로 저장하여 쿼리로 전달한다
            {
                string name = txtName.Text;
                string contact = txtContact.Text;
                string gender = txtGender.Text;
                string address = txtAddress.Text;
                string city = txtCity.Text;
                string state = txtState.Text;
                string username = txtUsername.Text;

                if (employeeAvailable)      // 직원이 활성화 상태인지 확인한 후 
                {
                    if (!string.IsNullOrEmpty(name)&&           // 빈 칸이 아닌지 확인
                        !string.IsNullOrEmpty(contact) &&
                        !string.IsNullOrEmpty(gender) &&
                        !string.IsNullOrEmpty(address) &&
                        !string.IsNullOrEmpty(city) &&
                        !string.IsNullOrEmpty(state) &&
                        !string.IsNullOrEmpty(username)
                        )
                    {
                        // 스트링에서 인트형으로 저장되는 연락처를 인트형으로 변환해서 넣어야한다.
                        Int64 number = Int64.Parse(contact);
                        qry = $"update e set e.ename = '{name}', e.contact = {number}, e.gender = '{gender}', e.eaddress = '{address}', e.city = '{city}', e.estate = '{state}' from employee as e inner join appUser as a on e.appuser_fk = a.appuser_pk where a.username = '{username}'";

                        databaseOperation.setDate(qry, "직원 정보 수정");
                        clearAllFields();  // 수정 후 초기화

                    }
                    else  // 필드가 비어있다면?
                    {
                        MessageBox.Show("모든 정보를 넣어주세요.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }
                else
                {
                    MessageBox.Show("해당 직원이 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex) {

                Console.WriteLine("직원 정보 수정 오류 : " + ex);
            }
        }

        // 초기화 버튼
        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        // 초기화
        private void clearAllFields()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtContact.Clear();
            txtGender.SelectedIndex = 0;
            txtHireDate.ResetText();
            txtState.Clear();
            employeeAvailable = false;
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);
        }



        // 수정 화면에서 아이디를 변경하면 모든 필드가 자동으로 초기화 되게 설정
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            clearAllFields();
        }
    }
}
