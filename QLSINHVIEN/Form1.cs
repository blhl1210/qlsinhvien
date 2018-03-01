using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSINHVIEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isRun(string name)
        {
            foreach (var cl in this.MdiChildren)
            {
                if (cl.GetType().Name.Equals(name))
                    return true;
            }
            return false;
        }
        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isRun("DanhSachSinhVien"))
            {
                DanhSachSinhVien dssv = new DanhSachSinhVien();
                dssv.MdiParent = this;
                dssv.Show();
            }
        }
    }
}
