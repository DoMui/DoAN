using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace Đồ_án
{
    public partial class GUI_CTHoaDonNhap : Form
    {
        BUS_CTHoaDonNhap busCTHDN = new BUS_CTHoaDonNhap();
        private BUS_HoaDonNhap busHDN = new BUS_HoaDonNhap();
        private BUS_SanPham bussp = new BUS_SanPham();
        public GUI_CTHoaDonNhap()
        {
            InitializeComponent();
            txtMaHDN.Text = maHDN.ToString();
        }

        private void GUI_CTHoaDonNhap_Load(object sender, EventArgs e)
        {
            dgvCTHDN.DataSource = busCTHDN.getCTHDN();
            //
            txtMaHDN.Text = maHDN.ToString();
            //
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            int maCTHDN = int.Parse(txtMaCTHDN.Text);
            int maHDN = int.Parse(txtMaHDN.Text);
            string masp = txtSP.Text;
            int sl = int.Parse(txtSL.Text);
            //decimal gia = decimal.Parse(txtGia.Text);

            // Kiểm tra sự tồn tại của mã hóa đơn nhập và mã sản phẩm trong cơ sở dữ liệu
            if (!busHDN.KiemTraTonTaiHoaDonNhap(maHDN))
            {
                MessageBox.Show("Mã hóa đơn nhập không tồn tại!");
                return;
            }

            decimal gia = bussp.LayGiaSanPham(masp);

            if (!bussp.KiemTraTonTaiSanPham(masp))
            {
                MessageBox.Show("Mã sản phẩm không tồn tại!");
                return;
            }

            // Tính tổng tiền
            decimal tongTien = sl * gia;

            // Tạo đối tượng DTO_ChiTietHoaDonNhap
            DTO_CTHoaDonNhap CTHDN = new DTO_CTHoaDonNhap(maCTHDN, maHDN, masp, sl, gia, tongTien);

            // Kiểm tra mã trùng
            if (busCTHDN.kiemtramatrung(maCTHDN) == 1)
            {
                MessageBox.Show("Mã trùng!");
                return;
            }

            // Thực hiện thêm chi tiết hóa đơn nhập vào cơ sở dữ liệu
            if (busCTHDN.themCTHDN(CTHDN))
            {
                MessageBox.Show("Thêm thành công!");
                dgvCTHDN.DataSource = busCTHDN.getCTHDN();
            }
        }

        private void dgvCTHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaCTHDN.Text = dgvCTHDN[0, hang].Value.ToString();
            txtMaHDN.Text = dgvCTHDN[1, hang].Value.ToString();
            txtSP.Text = dgvCTHDN[2, hang].Value.ToString();
            txtSL.Text = dgvCTHDN[3, hang].Value.ToString();
            txtGia.Text = dgvCTHDN[4, hang].Value.ToString();
            txtTong.Text = dgvCTHDN[5, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maCTHDN = int.Parse(txtMaCTHDN.Text);
            int maHDN = int.Parse(txtMaHDN.Text);
            string masp = txtSP.Text;
            int sl = int.Parse(txtSL.Text);
            //decimal gia = decimal.Parse(txtGia.Text);

            decimal gia = bussp.LayGiaSanPham(masp);

            bool isMaHDNValid = busHDN.KiemTraTonTaiHoaDonNhap(maHDN);
            bool isMaSPValid = bussp.KiemTraTonTaiSanPham(masp);

            if (!isMaHDNValid)
            {
                MessageBox.Show("Mã hóa đơn nhập không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            if (!isMaSPValid)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại trong cơ sở dữ liệu!");
                return;
            }


            // Tính tổng tiền
            decimal tongTien = sl * gia;

            // Tạo đối tượng DTO_ChiTietHoaDonNhap
            DTO_CTHoaDonNhap CTHDN = new DTO_CTHoaDonNhap(maCTHDN, maHDN, masp, sl, gia, tongTien);

            // Thực hiện thêm chi tiết hóa đơn nhập vào cơ sở dữ liệu
            if (busCTHDN.suaCTHDN(CTHDN))
            {
                MessageBox.Show("Sửa thành công!");
                dgvCTHDN.DataSource = busCTHDN.getCTHDN();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maCTHDN = int.Parse(txtMaCTHDN.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (busCTHDN.xoaCTHDN(maCTHDN) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvCTHDN.DataSource = busCTHDN.getCTHDN();
                }
            }
        }
        public int maHDN { get; set; }
    }
}
