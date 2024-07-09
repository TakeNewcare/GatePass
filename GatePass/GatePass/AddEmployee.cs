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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // 모든 필드의 데이터를 저장
        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseOperation databaseOperation = new DatabaseOperation();
            string qry;
            DataSet ds;

            try
            {
                // 모든 필드 데이터를 변수에 저장한다
                string name = txtName.Text;
                string hireDate = txtHireDate.Text;
                string contact = txtContact.Text;
                string gender = txtGender.Text;
                string address = txtAddress.Text;
                string city = txtCity.Text;
                string state = txtState.Text;
                string userName = txtUsername.Text;
                string password = txtPassword.Text;

                // 모든 필드에 텍스트가 적혀있는지 확인
                if (!string.IsNullOrEmpty(name)&&
                    !string.IsNullOrEmpty(hireDate) &&
                    !string.IsNullOrEmpty(contact) &&  // 문자열에서 정수 형태로 변환해서 저장해야한다.(biging 형식)
                    !string.IsNullOrEmpty(gender) &&
                    !string.IsNullOrEmpty(address) &&
                    !string.IsNullOrEmpty(city) &&
                    !string.IsNullOrEmpty(state) &&
                    !string.IsNullOrEmpty(userName) &&
                    !string.IsNullOrEmpty(password))
                {
                    // 문자로 들어온 연락처(contact)를 숫자형식으로 변환
                    Int64 contactInt = Int64.Parse(contact);  // 이미 숫자만 입력받게 만들어서 int 변환 가능

                    // 데이터베이스 appUser 테이블의 username이라는 열에서 아이디 값 확인
                    qry = "select * from appUser where username = '" + userName+"' and uenabled = 1";  // 아이디로 확인한다.(이름은 name, 아이디 userName)
                    ds = databaseOperation.getData(qry);  // 쿼리를 실행한 결과를 받는다.

                    // 해당 아이디가 없다면 저장하기
                    if (ds !=null && ds.Tables[0].Rows.Count == 0)  // => 이중으로 물어본다고???????????
                    {
                        // appUser 테이블에 저장
                        qry = $"insert into appUser(username, upass, urole) values ('{userName}', '{password}','직원')";
                        databaseOperation.setDate(qry, null);

                        // appUser 테이블에서 방금 저장한 데이터 가져오기 => employee 테이블에 데이터 삽입 시 appUser의 프라이머리키를 이유하기 위해
                        qry = $"select * from appUser where username = '{userName}' and upass = '{password}' and uenabled = 1";
                        ds = databaseOperation.getData(qry);  



                        // 가져온 데이터 삽입
                        qry = $"insert into employee (ename, hiredate, contact, gender, eaddress, city, estate, appuser_fk, eid) values ('{name}', '{hireDate}', {contactInt}, '{gender}','{address}','{city}','{state}',{ds.Tables[0].Rows[0][0]}, '{userName}')";  // {ds.Tables[0].Rows[0][0]} : appUser에 저장된 프라이머리 키를 외래키인 appuser_fk로 잡는다.
                        databaseOperation.setDate(qry, "직원 추가 성공");
                        clearAllFrields();      // 필드 초기화

                    }
                    else
                    {
                        MessageBox.Show("해당 아이디는 이미 존재합니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else
                {
                    MessageBox.Show("정보를 기입해주세요", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("저장 오류 : " + ex);
                MessageBox.Show("Something went wrong : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // 키 하나하나 누를 때 마다 onlyNumber로 검출
        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.onlyNumber(e);  // 숫자와 제어문자만 가능하게 
        }

        // 필드 초기화
        private void clearAllFrields()
        {
            txtName.Clear();
            txtHireDate.ResetText();
            txtContact.Clear();
            txtGender.SelectedIndex = -1;
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
