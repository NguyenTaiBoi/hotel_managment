using QLTCBUS;
using QLTCDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTCDemo
{
    public partial class frmThemKieuNau : Form
    {
        private KieuNauBUS knBus;
        public frmThemKieuNau()
        {
            InitializeComponent();
        }

        private void frmThemKieuNau_Load(object sender, EventArgs e)
        {
            knBus = new KieuNauBUS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            KieuNauDTO kn = new KieuNauDTO();
            kn.Ma = int.Parse(txtMa.Text);
            kn.Ten = txtTen.Text;
            kn.Mota = txtMoTa.Text;

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = knBus.them(kn);
            if (kq == false)
                MessageBox.Show("Thêm Kiểu nấu thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thêm Kiểu nấu thành công");
        }
    }
}
