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

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKH = textBox1.Text;
            kh.Hoten = textBox2.Text;
            kh.Tuoi = int.Parse(textBox3.Text);
            kh.Email = textBox4.Text;
            kh.Cmnd = textBox5.Text;
            kh.Sdt = textBox6.Text;
            kh.Quoctich = textBox7.Text;
            kh.Gioitinh = textBox8.Text;
            KhachHangBUS khbus = new KhachHangBUS();
            khbus.them(kh);
        }
    }
}
