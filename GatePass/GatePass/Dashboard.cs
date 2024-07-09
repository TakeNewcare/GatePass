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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        // 로그인화면에서 Dashboard 화면을 보여주면서 role을 전달한다
        string role;
        // 새로운 생성자를 만들어 직책에 따라 보여주는 데쉬보드 스타일이 다르다???
        public Dashboard(string role)
        {
            InitializeComponent();
            this.role = role;
        }


        // 사용자에 따라 다른 대쉬보드를 보여준다
        private void Dashboard_Load(object sender, EventArgs e)
        {
            string backgroundName;
            if ("ADMIN".Equals(role))
            {
                employeeToolStripMenuItem.Visible = true;       // 관리자 => 직원 탭 보이기
                backgroundName = "gatePassBg1"; // 배경 이름 설정
                labelWelcomeText.Text = "관리자 대시보드";
            }
            else
            {
                employeeToolStripMenuItem.Visible = false;      // 관리자x => 직원 탭 숨기기
                backgroundName = "gatePassBg2"; // 배경 이름 설정
                labelWelcomeText.Text = "직원 대시보드";
            }

            // 로그인한 직책에 맞게 이미지 이름을 정하고 해당 이미지를 백그라운드로 설정한다.
            Image image = Image.FromFile(Utility.getImageStorePath(backgroundName));
            this.BackgroundImage = image;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        // 로그아웃 버튼
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("로그아웃 하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();        // 대쉬보드 화면 숨기기
                Form1 form1 = new Form1();      // 폼1(로그인 화면)을 다시 생성하여 보여준다.
                form1.Show();
            }
        }


        // 종료 버튼
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료 하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // 직원 추가 버튼 클릭 시 이미 있는 경우 최상위 위치로 올리고 없으면 생성
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddEmployee>().Count() == 1)
            {
                // Application.OpenForms : 현재 열려있는 모든 폼의 컬렉션
                // OfType<AddEmployee>() : 컬렉션에서 AddEmployee 클래스의 인스턴스만 필터링

                Application.OpenForms.OfType<AddEmployee>().First().BringToFront();

                // 이미 열려있는 AddEmployee 폼이 하나 있을 경우
                // .First() : 첫 번째로 발견된 AddEmployee 폼 인스턴스
            }
            else
            {
                AddEmployee addEmployee = new AddEmployee();
                addEmployee.Show();
            }
        }


        // 직원 정보 수정 버튼 클릭 메서드
        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<UpadateEmployee>().Count() == 1)
            {
                Application.OpenForms.OfType<UpadateEmployee>().First().BringToFront();
            }
            else
            {
                UpadateEmployee upadateEmployee= new UpadateEmployee();
                upadateEmployee.Show();
            }
        }

        private void viewAllEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ViewEmployee>().Count()==1)
            {
                Application.OpenForms.OfType<ViewEmployee>().First().BringToFront();
            }
            else
            {
                ViewEmployee viewEmployee = new ViewEmployee();
                viewEmployee.Show();
            }
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<DeleteEmployee>().Count() > 0)
            {
                Application.OpenForms.OfType<DeleteEmployee>().First().BringToFront();
            }
            else
            {
                DeleteEmployee application = new DeleteEmployee();
                application.Show();
            }
        }

        private void addVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddVisitor>().Count() == 1)
            {
                Application.OpenForms.OfType<AddVisitor>().First().BringToFront();
            }
            else
            {
                AddVisitor addVisitor = new AddVisitor();
                addVisitor.Show();
            }

        }

        private void updateVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<UpdateVisitor>().Count() > 0)
            {
                Application.OpenForms.OfType<UpdateVisitor>().First().BringToFront();
            }
            else
            {
                UpdateVisitor updateVisitor = new UpdateVisitor();
                updateVisitor.Show();
            }
        }

        private void viewVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ViewVisitors>().Count() == 1)
            {
                Application.OpenForms.OfType<ViewVisitors>().First().BringToFront();
            }
            else
            {
                ViewVisitors viewVisitors = new ViewVisitors();
                viewVisitors.Show();
            }
        }

        private void generatePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<GeneratePass>().Count() == 1)
            {
                Application.OpenForms.OfType<GeneratePass>().First().BringToFront();
            }
            else
            {
                GeneratePass generatePass = new GeneratePass();
                generatePass.Show();
            }

        }

        private void validatePasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ValidatePass>().Count() == 1)
            {
                Application.OpenForms.OfType<ValidatePass>().First().BringToFront();
            }
            else
            {
                ValidatePass generatePass = new ValidatePass();
                generatePass.Show();
            }
        }

        private void filterPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FilterPass>().Count()==1)
            {
                Application.OpenForms.OfType<FilterPass>().First().BringToFront();
            }
            else
            {
                FilterPass filterPass = new FilterPass();
                filterPass.Show();
            }

        }
    }
}
