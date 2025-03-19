using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiKhachSan.UserControlForm
{
    public partial class User_DichVu : UserControl
    {
        private DichVuManager dichVuManager;

        public User_DichVu()
        {
            InitializeComponent();
            dichVuManager = new DichVuManager();
        }

        private void LoadDichVuData()
        {
            DataTable dataTable = dichVuManager.GetAllDichVu();
            dataGridViewDichVu.DataSource = dataTable;
        }

        private void User_DichVu_Load(object sender, EventArgs e)
        {
            LoadDichVuData();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa dịch vụ
            string maDV = txtMaDV.Text;

            if (dichVuManager.DeleteDichVu(maDV))
            {
                MessageBox.Show("Xóa dịch vụ thành công.");
                LoadDichVuData(); // Làm mới DataGridView
            }
            else
            {
                MessageBox.Show("Xóa dịch vụ thất bại.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Cập nhật dịch vụ
            string maDV = txtMaDV.Text;
            string tenDV = txtTenDV.Text;
            string donGia = txtDonGia.Text;
            string moTa = txtMoTa.Text;

            if (dichVuManager.UpdateDichVu(maDV, tenDV, donGia, moTa))
            {
                MessageBox.Show("Cập nhật dịch vụ thành công.");
                LoadDichVuData(); // Làm mới DataGridView
            }
            else
            {
                MessageBox.Show("Cập nhật dịch vụ thất bại.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Thêm dịch vụ mới
            string tenDV = txtTenDV.Text;
            string donGia = txtDonGia.Text;
            string moTa = txtMoTa.Text;

            if (dichVuManager.AddDichVu(tenDV, donGia, moTa))
            {
                MessageBox.Show("Thêm dịch vụ thành công.");
                LoadDichVuData(); // Làm mới DataGridView
            }
            else
            {
                MessageBox.Show("Thêm dịch vụ thất bại.");
            }
        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            LoadDichVuData();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }
    }
}
