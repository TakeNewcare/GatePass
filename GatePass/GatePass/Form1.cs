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
    public partial class Form1 : Form
    {
        // 데이터베이스와 연결하기 위해 생성한 DatabaseOperation 객체 생성
        DatabaseOperation databaseOperations = new DatabaseOperation();
        string qry;

        public Form1()
        {
            InitializeComponent();
        }


        // 로그인 버튼 클릭
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }



        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }


            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

        }



        private void Login()
        {
            try
            {
                qry = $"select * from appUser where username = '{txtUsername.Text}' and upass = '{txtPassword.Text}' and uenabled=1";  // uenabled=1 활성화???
                DataSet ds = databaseOperations.getData(qry);       // 아이디와 패스워드를 전달해서 결과테이블을 반환받는다
                if (ds != null && ds.Tables[0].Rows.Count != 0)     // ds에 데이터가 들어왔다면
                {
                    string role = ds.Tables[0].Rows[0][3].ToString();   // 직책 받기 : 데이터베이스의 id 값을 제외한 첫번째 행의 3번째 열 값(urole)
                    Int64 appUserPk = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());      // id값 받기 : primary key

                    // ds.Tables[0].Rows[0][0] : dataset은 datatable(행,열 형식)이 여러개 있는 구조체로 ds.tables[0] 은 table 중 첫번째 테이블을 말하는 거고
                    //                          Rows[0][0] 는 첫번째 행의 첫번째 열 값을 의미한다!!!


                    // 로그인이 된다면 데쉬보드 생성하여 보여주고, 로그인 창은 숨기기
                    Dashboard dashboard = new Dashboard(role);
                    dashboard.Show();
                    this.Hide();

                }
                else  // 값이 들어오지 않았다면
                {
                    MessageBox.Show("아이디와 비밀번호를 확인해주세요.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("로그인 에러 : " + ex);
                MessageBox.Show("Something went wrong : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // 사용자에게 오류를 알려준다.

            }
        }

        private void btn_exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
