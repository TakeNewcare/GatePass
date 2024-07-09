using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatePass
{
    // 데이터베이스와의 연동 클래스

    internal class DatabaseOperation
    {
        // 데이터 베이스 연결 함수 생성
        protected SqlConnection getConnection()
        {
            string con_string = "Data Source = proPC; Initial Catalog=gatePass; TrustServerCertificate=True; Persist Security Info=True; User ID=sa; Password=1234;";
            SqlConnection con = new SqlConnection(con_string);

            return con;
        }

        // 데이터 베이스 조회 메서드
        public DataSet getData(string qry)
        {
            DataSet ds = new DataSet();             // Dataset은 여러 개의 Dataset이 여러개가 있는 구조체 형식이다!!!! => ViewEmployee 폼의 ViewEmployee_Load 에서 쉽게 이해 가능

            try { 
               
                SqlConnection con = getConnection();        // 위에서 만든 연결 함수를 호출하여 con 변수에 반환하여 호출한다.
                SqlCommand cmd = new SqlCommand(qry, con);   // 실행할 쿼리와 베이터베이스 연결
                SqlDataAdapter da = new SqlDataAdapter(cmd);  // 어뎁터와 연결
                DataTable dt = new DataTable();   // 퀴리의 결과를 채우기 위한 테이블
                da.Fill(ds);            // 테이블에 결과 채우기
                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine("아이디와 비밀번호를 확인해 주세요 : " + e);
            }
            return ds;
        }

        // 데이터를 삽입, 수정, 삭제 등의 작업을 수행
        public void setDate(string qry, string msg)
        {
            try { 
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.ExecuteNonQuery(); // 쿼리를 실행한다
                con.Close();
                if (msg != null)
                {
                    MessageBox.Show(msg, "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


    }
}
