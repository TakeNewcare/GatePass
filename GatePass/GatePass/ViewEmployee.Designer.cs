namespace GatePass
{
    partial class ViewEmployee
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_pk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvhire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_fk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(747, 93);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 27);
            this.txtSearch.TabIndex = 41;
            this.txtSearch.Text = "  아이디 검색";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(708, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "검색";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Image = global::GatePass.Properties.Resources.close_602;
            this.btnExit.Location = new System.Drawing.Point(948, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 37);
            this.btnExit.TabIndex = 40;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(415, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 39);
            this.label1.TabIndex = 39;
            this.label1.Text = "직원 정보";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_pk,
            this.dgvname,
            this.dgvhire,
            this.dgvcon,
            this.dgvgen,
            this.dgvadd,
            this.dgvde,
            this.dgvstate,
            this.dgv_fk,
            this.dgvid});
            this.dataGridView1.Location = new System.Drawing.Point(36, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(956, 411);
            this.dataGridView1.TabIndex = 43;
            // 
            // dgv_pk
            // 
            this.dgv_pk.HeaderText = "";
            this.dgv_pk.Name = "dgv_pk";
            this.dgv_pk.Visible = false;
            // 
            // dgvname
            // 
            this.dgvname.HeaderText = "이름";
            this.dgvname.Name = "dgvname";
            // 
            // dgvhire
            // 
            this.dgvhire.HeaderText = "고용일";
            this.dgvhire.Name = "dgvhire";
            // 
            // dgvcon
            // 
            this.dgvcon.HeaderText = "연락처";
            this.dgvcon.Name = "dgvcon";
            // 
            // dgvgen
            // 
            this.dgvgen.HeaderText = "성별";
            this.dgvgen.Name = "dgvgen";
            // 
            // dgvadd
            // 
            this.dgvadd.HeaderText = "주소";
            this.dgvadd.Name = "dgvadd";
            // 
            // dgvde
            // 
            this.dgvde.HeaderText = "상세주소";
            this.dgvde.Name = "dgvde";
            // 
            // dgvstate
            // 
            this.dgvstate.HeaderText = "상태";
            this.dgvstate.Name = "dgvstate";
            // 
            // dgv_fk
            // 
            this.dgv_fk.HeaderText = "";
            this.dgv_fk.Name = "dgv_fk";
            this.dgv_fk.Visible = false;
            // 
            // dgvid
            // 
            this.dgvid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvid.HeaderText = "아이디";
            this.dgvid.Name = "dgvid";
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployee";
            this.Load += new System.EventHandler(this.ViewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_pk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvhire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvde;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_fk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
    }
}