using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace De01
{
    public partial class frmSinhvien : Form
    {
        public frmSinhvien()
        {
            this.Text = "DANH SÁCH SINH VIÊN";
            this.ClientSize = new System.Drawing.Size(800, 600);

            // Label for MaSV
            Label lblMaSV = new Label();
            lblMaSV.Text = "Mã Sinh Viên:";
            lblMaSV.Location = new System.Drawing.Point(20, 20);
            lblMaSV.AutoSize = true;

            // Label for HoTenSV
            Label lblHotenSV = new Label();
            lblHotenSV.Text = "Họ Tên Sinh Viên:";
            lblHotenSV.Location = new System.Drawing.Point(20, 60);
            lblHotenSV.AutoSize = true;

            // Label for NgaySinh
            Label lblNgaysinh = new Label();
            lblNgaysinh.Text = "Ngày Sinh:";
            lblNgaysinh.Location = new System.Drawing.Point(20, 100);
            lblNgaysinh.AutoSize = true;

            // Label for Lop
            Label lblLop = new Label();
            lblLop.Text = "Lớp:";
            lblLop.Location = new System.Drawing.Point(20, 140);
            lblLop.AutoSize = true;

            // TextBox for MaSV
            TextBox txtMaSV = new TextBox();
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Location = new System.Drawing.Point(150, 20);
            txtMaSV.Size = new System.Drawing.Size(200, 22);

            // TextBox for HoTenSV
            TextBox txtHotenSV = new TextBox();
            txtHotenSV.Name = "txtHotenSV";
            txtHotenSV.Location = new System.Drawing.Point(150, 60);
            txtHotenSV.Size = new System.Drawing.Size(200, 22);

            // DateTimePicker for NgaySinh
            DateTimePicker dtNgaysinh = new DateTimePicker();
            dtNgaysinh.Name = "dtNgaysinh";
            dtNgaysinh.Format = DateTimePickerFormat.Short;
            dtNgaysinh.Location = new System.Drawing.Point(150, 100);
            dtNgaysinh.Size = new System.Drawing.Size(200, 22);

            // ComboBox for Lop
            ComboBox cboLop = new ComboBox();
            cboLop.Name = "cboLop";
            cboLop.Location = new System.Drawing.Point(150, 140);
            cboLop.Size = new System.Drawing.Size(200, 22);

            // ListView for Sinhvien
            ListView vSinhvien = new ListView();
            vSinhvien.Name = "vSinhvien";
            vSinhvien.Location = new System.Drawing.Point(20, 180);
            vSinhvien.Size = new System.Drawing.Size(740, 300);
            vSinhvien.View = View.Details;
            vSinhvien.Columns.Add("Mã Sinh Viên", 150);
            vSinhvien.Columns.Add("Họ Tên", 250);
            vSinhvien.Columns.Add("Ngày Sinh", 100);
            vSinhvien.Columns.Add("Lớp", 100);

            // Button for Them
            Button btThem = new Button();
            btThem.Name = "btThem";
            btThem.Text = "Thêm";
            btThem.Location = new System.Drawing.Point(20, 500);
            btThem.Size = new System.Drawing.Size(100, 30);
            btThem.Click += new EventHandler(btThem_Click);

            // Button for Xoa
            Button btXoa = new Button();
            btXoa.Name = "btXoa";
            btXoa.Text = "Xóa";
            btXoa.Location = new System.Drawing.Point(130, 500);
            btXoa.Size = new System.Drawing.Size(100, 30);
            btXoa.Click += new EventHandler(btXoa_Click);

            // Button for Sua
            Button btSua = new Button();
            btSua.Name = "btSua";
            btSua.Text = "Sửa";
            btSua.Location = new System.Drawing.Point(240, 500);
            btSua.Size = new System.Drawing.Size(100, 30);
            btSua.Click += new EventHandler(btSua_Click);

            // Button for Luu
            Button btLuu = new Button();
            btLuu.Name = "btLuu";
            btLuu.Text = "Lưu";
            btLuu.Location = new System.Drawing.Point(350, 500);
            btLuu.Size = new System.Drawing.Size(100, 30);
            btLuu.Click += new EventHandler(btLuu_Click);

            // Button for Khong
            Button btKhong = new Button();
            btKhong.Name = "btKhong";
            btKhong.Text = "Không";
            btKhong.Location = new System.Drawing.Point(460, 500);
            btKhong.Size = new System.Drawing.Size(100, 30);
            btKhong.Click += new EventHandler(btKhong_Click);

            // Button for Thoat
            Button btThoat = new Button();
            btThoat.Name = "btThoat";
            btThoat.Text = "Thoát";
            btThoat.Location = new System.Drawing.Point(570, 500);
            btThoat.Size = new System.Drawing.Size(100, 30);
            btThoat.Click += new EventHandler(btThoat_Click);

            // Add controls to the Form
            this.Controls.Add(lblMaSV);
            this.Controls.Add(txtMaSV);
            this.Controls.Add(lblHotenSV);
            this.Controls.Add(txtHotenSV);
            this.Controls.Add(lblNgaysinh);
            this.Controls.Add(dtNgaysinh);
            this.Controls.Add(lblLop);
            this.Controls.Add(cboLop);
            this.Controls.Add(vSinhvien);
            this.Controls.Add(btThem);
            this.Controls.Add(btXoa);
            this.Controls.Add(btSua);
            this.Controls.Add(btLuu);
            this.Controls.Add(btKhong);
            this.Controls.Add(btThoat);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // Code to add a new student
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            // Code to delete selected student
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            // Code to edit selected student
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            // Code to save changes
        }

        private void btKhong_Click(object sender, EventArgs e)
        {
            // Code to cancel changes
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSinhvien_Load(object sender, EventArgs e)
        {

        }
        private System.Windows.Forms.DataGridView dtgvData;

        private void btnXem_Click(object sender, EventArgs e)
        {       
            QuanlySVEntities db = new QuanlySVEntities();        
            dtgvData.DataSource = db.Sinhvien.ToList(); 
        }
    }
}
