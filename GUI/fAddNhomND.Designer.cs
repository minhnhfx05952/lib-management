namespace GUI
{
    partial class fAddNhomND
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.dsChucNang = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.isChoosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNhom = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cHUCNANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCNANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.siticoneControlBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.Location = new System.Drawing.Point(568, -2);
            this.siticoneControlBox2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(41, 37);
            this.siticoneControlBox2.TabIndex = 10;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.Location = new System.Drawing.Point(611, -2);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(43, 37);
            this.siticoneControlBox1.TabIndex = 11;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.MistyRose;
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.dsChucNang);
            this.siticonePanel1.Controls.Add(this.butSave);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.txtTenNhom);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Location = new System.Drawing.Point(66, 47);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(522, 528);
            this.siticonePanel1.TabIndex = 12;
            // 
            // dsChucNang
            // 
            this.dsChucNang.AllowUserToAddRows = false;
            this.dsChucNang.AllowUserToDeleteRows = false;
            this.dsChucNang.AllowUserToResizeColumns = false;
            this.dsChucNang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dsChucNang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dsChucNang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsChucNang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dsChucNang.ColumnHeadersHeight = 45;
            this.dsChucNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dsChucNang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChoosen,
            this.MaChucNang,
            this.TenChucNang,
            this.TenManHinh});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsChucNang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dsChucNang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dsChucNang.Location = new System.Drawing.Point(65, 205);
            this.dsChucNang.Margin = new System.Windows.Forms.Padding(2);
            this.dsChucNang.Name = "dsChucNang";
            this.dsChucNang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsChucNang.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dsChucNang.RowHeadersVisible = false;
            this.dsChucNang.RowHeadersWidth = 51;
            this.dsChucNang.RowTemplate.Height = 30;
            this.dsChucNang.Size = new System.Drawing.Size(399, 227);
            this.dsChucNang.TabIndex = 40;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dsChucNang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dsChucNang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dsChucNang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dsChucNang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dsChucNang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsChucNang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsChucNang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dsChucNang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dsChucNang.ThemeStyle.HeaderStyle.Height = 45;
            this.dsChucNang.ThemeStyle.ReadOnly = false;
            this.dsChucNang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dsChucNang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dsChucNang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsChucNang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dsChucNang.ThemeStyle.RowsStyle.Height = 30;
            this.dsChucNang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dsChucNang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dsChucNang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsChucNang_CellContentClick);
            // 
            // isChoosen
            // 
            this.isChoosen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.isChoosen.FalseValue = "0";
            this.isChoosen.HeaderText = "";
            this.isChoosen.IndeterminateValue = "0";
            this.isChoosen.MinimumWidth = 6;
            this.isChoosen.Name = "isChoosen";
            this.isChoosen.TrueValue = "1";
            this.isChoosen.Width = 30;
            // 
            // MaChucNang
            // 
            this.MaChucNang.HeaderText = "Number of Functions";
            this.MaChucNang.MinimumWidth = 6;
            this.MaChucNang.Name = "MaChucNang";
            this.MaChucNang.ReadOnly = true;
            // 
            // TenChucNang
            // 
            this.TenChucNang.HeaderText = "Function Name";
            this.TenChucNang.MinimumWidth = 6;
            this.TenChucNang.Name = "TenChucNang";
            this.TenChucNang.ReadOnly = true;
            // 
            // TenManHinh
            // 
            this.TenManHinh.HeaderText = "Screen Name";
            this.TenManHinh.MinimumWidth = 6;
            this.TenManHinh.Name = "TenManHinh";
            this.TenManHinh.ReadOnly = true;
            // 
            // butSave
            // 
            this.butSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSave.FillColor = System.Drawing.Color.SlateBlue;
            this.butSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.Location = new System.Drawing.Point(205, 464);
            this.butSave.Margin = new System.Windows.Forms.Padding(2);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(112, 41);
            this.butSave.TabIndex = 4;
            this.butSave.Text = "Lưu";
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(58, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADD USER GROUP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhom.DefaultText = "";
            this.txtTenNhom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.txtTenNhom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNhom.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtTenNhom.Location = new System.Drawing.Point(103, 127);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.PasswordChar = '\0';
            this.txtTenNhom.PlaceholderText = "";
            this.txtTenNhom.SelectedText = "";
            this.txtTenNhom.Size = new System.Drawing.Size(320, 32);
            this.txtTenNhom.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(99, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "User Group Name*";
            // 
            // cHUCNANGBindingSource
            // 
            this.cHUCNANGBindingSource.DataSource = typeof(DTO.CHUCNANG);
            // 
            // fAddNhomND
            // 
            this.AcceptButton = this.butSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(654, 623);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fAddNhomND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddNhomND";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCNANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butSave;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTenNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cHUCNANGBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dsChucNang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChoosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenManHinh;
    }
}