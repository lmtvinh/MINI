using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI.GUI
{
    public partial class trangChu : Form
    {
        public trangChu()
        {
            InitializeComponent();
        }
        
        //      Tạo chức năng cho button nhân viên

        private NhanVien nv=new NhanVien();
        //      Load form NhanVien
        private void loadFormNV()
        {
            if (nv == null || nv.IsDisposed)
            {
                // Nếu chưa, tạo một instance mới
                nv = new GUI.NhanVien();

                // Đặt MainForm làm cha của ChildForm
                nv.TopLevel = false;

                // Đặt thuộc tính Dock của ChildForm thành Fill để lấp đầy toàn bộ Panel
                nv.Dock = DockStyle.Fill;

                // Thêm ChildForm vào Panel
                panelContent.Controls.Add(nv);
                nv.Dock = DockStyle.Fill;

                // Hiển thị ChildForm
                nv.Show();
            }
            else
            {
                // Nếu đã mở, đưa ChildForm lên trước cùng
                nv.BringToFront();
            }
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            loadFormNV();
        }
        private void btnNhanVienThem_Click(object sender, EventArgs e)
        {
           nv.
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {

        }


    }
}
