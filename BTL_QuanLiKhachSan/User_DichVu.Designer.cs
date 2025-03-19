namespace BTL_QuanLiKhachSan.UserControlForm
{
    partial class User_DichVu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.dataGridViewDichVu = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(112, 73);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(176, 22);
            this.txtMaDV.TabIndex = 0;
            // 
            // txtTenDV
            // 
            this.txtTenDV.FormattingEnabled = true;
            this.txtTenDV.Items.AddRange(new object[] {
            "Dịch vụ giặt là",
            "Dịch vụ ăn sáng",
            "Dịch vụ đưa đón sân bay",
            "Dịch vụ spa",
            "Dịch vụ phòng họp",
            "Dịch vụ internet",
            "Dịch vụ cho thuê xe",
            "Dịch vụ tour du lịch",
            "Dịch vụ đặt vé máy bay",
            "Dịch vụ giặt ủi",
            "Dịch vụ truyền hình cáp",
            "Dịch vụ bảo trì phòng",
            "Dịch vụ bảo vệ 24/7",
            "Dịch vụ gọi taxi",
            "Dịch vụ tổ chức sự kiện",
            "Dịch vụ karaoke",
            "Dịch vụ phục vụ tại phòng",
            "Dịch vụ đặt vé tham quan",
            "Dịch vụ chăm sóc trẻ em",
            "Dịch vụ tiệc cưới",
            "Dịch vụ làm đẹp"});
            this.txtTenDV.Location = new System.Drawing.Point(112, 25);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(224, 24);
            this.txtTenDV.TabIndex = 1;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(112, 176);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(176, 22);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(112, 123);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(176, 22);
            this.txtDonGia.TabIndex = 3;
            // 
            // dataGridViewDichVu
            // 
            this.dataGridViewDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDichVu.Location = new System.Drawing.Point(3, 204);
            this.dataGridViewDichVu.Name = "dataGridViewDichVu";
            this.dataGridViewDichVu.ReadOnly = true;
            this.dataGridViewDichVu.RowHeadersWidth = 51;
            this.dataGridViewDichVu.RowTemplate.Height = 24;
            this.dataGridViewDichVu.Size = new System.Drawing.Size(980, 301);
            this.dataGridViewDichVu.TabIndex = 4;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(364, 101);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(364, 57);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(364, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(364, 26);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 9;
            this.btnReload.Text = "Load";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Dịch Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Dịch Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mô Tả";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(364, 176);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // User_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dataGridViewDichVu);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.txtMaDV);
            this.Name = "User_DichVu";
            this.Size = new System.Drawing.Size(1011, 508);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.ComboBox txtTenDV;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DataGridView dataGridViewDichVu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReport;
    }
}
