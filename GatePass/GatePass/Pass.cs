using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GatePass
{
    public partial class Pass : Form
    {
        DatabaseOperation databaseOperation = new DatabaseOperation();
        string qry;
        DataSet ds;


        // 통행증
        public Pass()
        {
            InitializeComponent();
        }

        string path, pssId, name, contact, gender, validFrom, validTo;


        // 해당 폼이 로드되면 실행되면서 bmp를 생성하고 
        Bitmap bmp;     // 픽셀단위로 정보를 저장하는 방식으로 각 픽셀은 색상 정보를 포함하며, 이미지의 크기와 해상도는 픽셀의 배열로 정의된다.
        private void Print()
        {
            bmp = new Bitmap(this.Width, this.Height);  // 비트맵의 크기를 현재 폼의 너비 / 높이와 동일하게 설정 => 프린트화면의 컨텐츠가 담기는 부분
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height)); // 폼의 그래픽을 지정된 비트맴에 드리고 영역을 설정한다(x, y, 가로, 세로)
        }


        // 실제 인쇄 작성 수행 시 호출된다.
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle r = e.PageBounds;  // 현재 인쇄 페이지의 경계를 나타내는 사각형입니다. 이 사각형은 인쇄할 영역을 정의
            e.Graphics.DrawImage(bmp,r);  
            // e.Graphice : 인쇄할 그래픽을 그리기 위한 객체
            // DrawImage(bmp, r) : bmp 이미지를 r의 크기에 맞게 그리는 설정
            
        }
        /// //////

        public Pass(string path, string passId, string name, string contact, string gender, string validFrom, string validTo, long visitorPk, int days)
        {
            InitializeComponent();

            try { 
                pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxProfile.Image = Image.FromFile(path);
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            lblPassId.Text = passId;
            lblName.Text = name;
            lblContack.Text = contact;
            lblGender.Text = gender;
            lblValidFrom.Text = validFrom;
            lblValidTo.Text = validTo;

            setPassColor(days);  // 색 설정
            savePassDetails(passId, validFrom, validTo, visitorPk);  // 데이터베이스에 저장

            this.path = path;
            this.pssId = passId;
            this.name = name;
            this.contact = contact;
            this.gender = gender;
            this.validFrom = validFrom;
            this.validTo = validTo;
        }


        private void setPassColor(int days)
        {
            if (days == 0)
            {
                this.BackColor = Color.Gray;
            }
            else if (days <= 6)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.SkyBlue;
            }
        }

        // 데이터베이스에 저장
        private void savePassDetails(string passId, string validFrom, string validTo, long visitorPk)
        {
            try {
                // 문자열을 datetime으로 변환
                DateTime validFromDate = DateTime.ParseExact(validFrom, "yyyy.MM.dd", CultureInfo.InvariantCulture);
                DateTime validToDate = DateTime.ParseExact(validTo, "yyyy.MM.dd", CultureInfo.InvariantCulture);
                qry = $"insert into pass (passID, validFrom, validTo, visitors_fk) values ('{passId}', '{validFromDate.ToString("yyyy-MM-dd")}', '{validToDate.ToString("yyyy-MM-dd")}', {visitorPk})";
                databaseOperation.setDate(qry, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        // 통행증을 만들어서 로드할 때 
        // 프린트 객체를 생성하여 통행증을 안에 담아서 출력한다.
        private void Pass_Load(object sender, EventArgs e)
        {
            Print();  // bitmap 설정 및
            printPreviewDialog1.ShowDialog();
            this.Close();
        }
    }
}
