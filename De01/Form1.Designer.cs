using System.Windows.Forms;
using System;

namespace De01
{
    partial class frmSinhvien
    {
        private void InitializeComponent()
        {
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHotenSV = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHotenSV = new System.Windows.Forms.TextBox();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.vSinhvien = new System.Windows.Forms.ListView();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btKhong = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(127, 38);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(88, 16);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã Sinh Viên:";
            // 
            // lblHotenSV
            // 
            this.lblHotenSV.AutoSize = true;
            this.lblHotenSV.Location = new System.Drawing.Point(457, 41);
            this.lblHotenSV.Name = "lblHotenSV";
            this.lblHotenSV.Size = new System.Drawing.Size(114, 16);
            this.lblHotenSV.TabIndex = 2;
            this.lblHotenSV.Text = "Họ Tên Sinh Viên:";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(143, 88);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(72, 16);
            this.lblNgaysinh.TabIndex = 4;
            this.lblNgaysinh.Text = "Ngày Sinh:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(498, 88);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(33, 16);
            this.lblLop.TabIndex = 6;
            this.lblLop.Text = "Lớp:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(240, 35);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(200, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // txtHotenSV
            // 
            this.txtHotenSV.Location = new System.Drawing.Point(577, 35);
            this.txtHotenSV.Name = "txtHotenSV";
            this.txtHotenSV.Size = new System.Drawing.Size(200, 22);
            this.txtHotenSV.TabIndex = 3;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaysinh.Location = new System.Drawing.Point(240, 83);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(200, 22);
            this.dtNgaysinh.TabIndex = 5;
            // 
            // cboLop
            // 
            this.cboLop.Location = new System.Drawing.Point(577, 85);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(200, 24);
            this.cboLop.TabIndex = 7;
            // 
            // vSinhvien
            // 
            this.vSinhvien.HideSelection = false;
            this.vSinhvien.Location = new System.Drawing.Point(28, 237);
            this.vSinhvien.Name = "vSinhvien";
            this.vSinhvien.Size = new System.Drawing.Size(740, 300);
            this.vSinhvien.TabIndex = 8;
            this.vSinhvien.UseCompatibleStateImageBehavior = false;
            this.vSinhvien.View = System.Windows.Forms.View.Details;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(130, 189);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 30);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(240, 189);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 30);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(346, 189);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 30);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(460, 189);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 30);
            this.btLuu.TabIndex = 12;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btKhong
            // 
            this.btKhong.Location = new System.Drawing.Point(566, 189);
            this.btKhong.Name = "btKhong";
            this.btKhong.Size = new System.Drawing.Size(100, 30);
            this.btKhong.TabIndex = 13;
            this.btKhong.Text = "Không";
            this.btKhong.Click += new System.EventHandler(this.btKhong_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(677, 189);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 30);
            this.btThoat.TabIndex = 14;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "THÔNG TIN CHI TIẾT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 16;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(130, 142);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 30);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "TÌM";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(240, 142);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 30);
            this.btnXem.TabIndex = 18;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // frmSinhvien
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblHotenSV);
            this.Controls.Add(this.txtHotenSV);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.dtNgaysinh);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.vSinhvien);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btKhong);
            this.Controls.Add(this.btThoat);
            this.Name = "frmSinhvien";
            this.Text = "DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.frmSinhvien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblMaSV;
        private Label lblHotenSV;
        private Label lblNgaysinh;
        private Label lblLop;
        private TextBox txtMaSV;
        private TextBox txtHotenSV;
        private DateTimePicker dtNgaysinh;
        private ComboBox cboLop;
        private ListView vSinhvien;
        private Button btThem;
        private Button btXoa;
        private Button btSua;
        private Button btLuu;
        private Button btKhong;
        private Button btThoat;
        private Label label1;
        private TextBox textBox1;
        private Button btnTim;
        private Button btnXem;
    }
}

