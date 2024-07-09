namespace GatePass
{
    partial class FilterPass
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtFilterType = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dataGridViewVisitor = new System.Windows.Forms.DataGridView();
            this.dgvvisitors_pk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvvisitorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(457, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 39);
            this.label1.TabIndex = 91;
            this.label1.Text = "빠른 조회";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(696, 88);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(309, 27);
            this.txtSearch.TabIndex = 96;
            this.txtSearch.Text = "  이름, 방문자 번호, 통행증 번호를 입력해주세요";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(692, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 97;
            this.label2.Text = "검색";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(19, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 13);
            this.panel1.TabIndex = 98;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(169, 89);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 99;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePickerValidFrom_ValueChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::GatePass.Properties.Resources.reset;
            this.btnReset.Location = new System.Drawing.Point(375, 88);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(34, 27);
            this.btnReset.TabIndex = 100;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Image = global::GatePass.Properties.Resources.close_602;
            this.btnExit.Location = new System.Drawing.Point(961, 21);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 37);
            this.btnExit.TabIndex = 94;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtFilterType
            // 
            this.txtFilterType.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFilterType.FormattingEnabled = true;
            this.txtFilterType.Items.AddRange(new object[] {
            "From",
            "To"});
            this.txtFilterType.Location = new System.Drawing.Point(19, 89);
            this.txtFilterType.Name = "txtFilterType";
            this.txtFilterType.Size = new System.Drawing.Size(144, 24);
            this.txtFilterType.TabIndex = 101;
            this.txtFilterType.SelectedIndexChanged += new System.EventHandler(this.txtFilterType_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(870, 440);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 19);
            this.lblStatus.TabIndex = 97;
            // 
            // dataGridViewVisitor
            // 
            this.dataGridViewVisitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvvisitors_pk,
            this.dgvname,
            this.dgvcon,
            this.dgvgender,
            this.dgvadd,
            this.dgvID,
            this.dgvvisitorID,
            this.dgvpassID,
            this.dgvstart,
            this.dgvend});
            this.dataGridViewVisitor.Location = new System.Drawing.Point(19, 121);
            this.dataGridViewVisitor.Name = "dataGridViewVisitor";
            this.dataGridViewVisitor.RowTemplate.Height = 23;
            this.dataGridViewVisitor.Size = new System.Drawing.Size(986, 297);
            this.dataGridViewVisitor.TabIndex = 102;
            this.dataGridViewVisitor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVisitor_CellClick);
            // 
            // dgvvisitors_pk
            // 
            this.dgvvisitors_pk.HeaderText = "";
            this.dgvvisitors_pk.Name = "dgvvisitors_pk";
            this.dgvvisitors_pk.Visible = false;
            // 
            // dgvname
            // 
            this.dgvname.HeaderText = "이름";
            this.dgvname.Name = "dgvname";
            // 
            // dgvcon
            // 
            this.dgvcon.HeaderText = "연락처";
            this.dgvcon.Name = "dgvcon";
            // 
            // dgvgender
            // 
            this.dgvgender.HeaderText = "성별";
            this.dgvgender.Name = "dgvgender";
            // 
            // dgvadd
            // 
            this.dgvadd.HeaderText = "주소";
            this.dgvadd.Name = "dgvadd";
            // 
            // dgvID
            // 
            this.dgvID.HeaderText = "고유 번호";
            this.dgvID.Name = "dgvID";
            // 
            // dgvvisitorID
            // 
            this.dgvvisitorID.HeaderText = "방문자 번호";
            this.dgvvisitorID.Name = "dgvvisitorID";
            // 
            // dgvpassID
            // 
            this.dgvpassID.HeaderText = "통행증번호";
            this.dgvpassID.Name = "dgvpassID";
            // 
            // dgvstart
            // 
            this.dgvstart.HeaderText = "시작일";
            this.dgvstart.Name = "dgvstart";
            // 
            // dgvend
            // 
            this.dgvend.HeaderText = "종료일";
            this.dgvend.Name = "dgvend";
            // 
            // FilterPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 495);
            this.Controls.Add(this.dataGridViewVisitor);
            this.Controls.Add(this.txtFilterType);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterPass";
            this.Load += new System.EventHandler(this.FilterPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox txtFilterType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dataGridViewVisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvvisitors_pk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvvisitorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvend;
    }
}