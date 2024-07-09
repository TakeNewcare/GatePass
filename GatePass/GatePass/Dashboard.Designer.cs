namespace GatePass
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.방문자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validatePasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelWelcomeText = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnLogOut,
            this.filterPassToolStripMenuItem,
            this.validatePasToolStripMenuItem,
            this.generatePassToolStripMenuItem,
            this.방문자ToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1351, 68);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.updateEmployeeToolStripMenuItem,
            this.viewAllEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.Image = global::GatePass.Properties.Resources.add1;
            this.employeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(105, 64);
            this.employeeToolStripMenuItem.Text = "직원";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeToolStripMenuItem.Image = global::GatePass.Properties.Resources.add1;
            this.addEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(206, 70);
            this.addEmployeeToolStripMenuItem.Text = "직원 추가";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployeeToolStripMenuItem.Image = global::GatePass.Properties.Resources.update_emp;
            this.updateEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(206, 70);
            this.updateEmployeeToolStripMenuItem.Text = "직원 정보 수정";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // viewAllEmployeeToolStripMenuItem
            // 
            this.viewAllEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllEmployeeToolStripMenuItem.Image = global::GatePass.Properties.Resources.eye_60;
            this.viewAllEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewAllEmployeeToolStripMenuItem.Name = "viewAllEmployeeToolStripMenuItem";
            this.viewAllEmployeeToolStripMenuItem.Size = new System.Drawing.Size(206, 70);
            this.viewAllEmployeeToolStripMenuItem.Text = "전체 직원 보기";
            this.viewAllEmployeeToolStripMenuItem.Click += new System.EventHandler(this.viewAllEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmployeeToolStripMenuItem.Image = global::GatePass.Properties.Resources.x;
            this.deleteEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(206, 70);
            this.deleteEmployeeToolStripMenuItem.Text = "직원 삭제";
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // 방문자ToolStripMenuItem
            // 
            this.방문자ToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.방문자ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVisitorToolStripMenuItem,
            this.viewVisitorToolStripMenuItem,
            this.updateVisitorToolStripMenuItem});
            this.방문자ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.방문자ToolStripMenuItem.Image = global::GatePass.Properties.Resources.visitor1;
            this.방문자ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.방문자ToolStripMenuItem.Name = "방문자ToolStripMenuItem";
            this.방문자ToolStripMenuItem.Size = new System.Drawing.Size(133, 64);
            this.방문자ToolStripMenuItem.Text = "방문 예약";
            // 
            // addVisitorToolStripMenuItem
            // 
            this.addVisitorToolStripMenuItem.Image = global::GatePass.Properties.Resources.visitor1;
            this.addVisitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addVisitorToolStripMenuItem.Name = "addVisitorToolStripMenuItem";
            this.addVisitorToolStripMenuItem.Size = new System.Drawing.Size(186, 66);
            this.addVisitorToolStripMenuItem.Text = "예약 추가";
            this.addVisitorToolStripMenuItem.Click += new System.EventHandler(this.addVisitorToolStripMenuItem_Click);
            // 
            // viewVisitorToolStripMenuItem
            // 
            this.viewVisitorToolStripMenuItem.Image = global::GatePass.Properties.Resources.visitor2;
            this.viewVisitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewVisitorToolStripMenuItem.Name = "viewVisitorToolStripMenuItem";
            this.viewVisitorToolStripMenuItem.Size = new System.Drawing.Size(186, 66);
            this.viewVisitorToolStripMenuItem.Text = "예약자 명단";
            this.viewVisitorToolStripMenuItem.Click += new System.EventHandler(this.viewVisitorToolStripMenuItem_Click);
            // 
            // updateVisitorToolStripMenuItem
            // 
            this.updateVisitorToolStripMenuItem.Image = global::GatePass.Properties.Resources.visitor3;
            this.updateVisitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateVisitorToolStripMenuItem.Name = "updateVisitorToolStripMenuItem";
            this.updateVisitorToolStripMenuItem.Size = new System.Drawing.Size(186, 66);
            this.updateVisitorToolStripMenuItem.Text = "예약자 수정";
            this.updateVisitorToolStripMenuItem.Click += new System.EventHandler(this.updateVisitorToolStripMenuItem_Click);
            // 
            // generatePassToolStripMenuItem
            // 
            this.generatePassToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePassToolStripMenuItem.Image = global::GatePass.Properties.Resources.gate_pass;
            this.generatePassToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.generatePassToolStripMenuItem.Name = "generatePassToolStripMenuItem";
            this.generatePassToolStripMenuItem.Size = new System.Drawing.Size(145, 64);
            this.generatePassToolStripMenuItem.Text = "통행증 발급";
            this.generatePassToolStripMenuItem.Click += new System.EventHandler(this.generatePassToolStripMenuItem_Click);
            // 
            // validatePasToolStripMenuItem
            // 
            this.validatePasToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.validatePasToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validatePasToolStripMenuItem.Image = global::GatePass.Properties.Resources.validate_gate_pass;
            this.validatePasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.validatePasToolStripMenuItem.Name = "validatePasToolStripMenuItem";
            this.validatePasToolStripMenuItem.Size = new System.Drawing.Size(157, 64);
            this.validatePasToolStripMenuItem.Text = "유효한 통행증";
            this.validatePasToolStripMenuItem.Click += new System.EventHandler(this.validatePasToolStripMenuItem_Click);
            // 
            // filterPassToolStripMenuItem
            // 
            this.filterPassToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPassToolStripMenuItem.Image = global::GatePass.Properties.Resources.filter_pass;
            this.filterPassToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.filterPassToolStripMenuItem.Name = "filterPassToolStripMenuItem";
            this.filterPassToolStripMenuItem.Size = new System.Drawing.Size(133, 64);
            this.filterPassToolStripMenuItem.Text = "빠른 조회";
            this.filterPassToolStripMenuItem.Click += new System.EventHandler(this.filterPassToolStripMenuItem_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Silver;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = global::GatePass.Properties.Resources.logout_60;
            this.btnLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(129, 64);
            this.btnLogOut.Text = "로그아웃";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::GatePass.Properties.Resources.exit;
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 64);
            this.btnExit.Text = "나가기";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelWelcomeText
            // 
            this.labelWelcomeText.AutoSize = true;
            this.labelWelcomeText.BackColor = System.Drawing.Color.White;
            this.labelWelcomeText.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeText.ForeColor = System.Drawing.Color.Black;
            this.labelWelcomeText.Location = new System.Drawing.Point(12, 9);
            this.labelWelcomeText.Name = "labelWelcomeText";
            this.labelWelcomeText.Size = new System.Drawing.Size(274, 45);
            this.labelWelcomeText.TabIndex = 1;
            this.labelWelcomeText.Text = "Welcome Admin";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 709);
            this.Controls.Add(this.labelWelcomeText);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 방문자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validatePasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVisitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVisitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateVisitorToolStripMenuItem;
        private System.Windows.Forms.Label labelWelcomeText;
    }
}