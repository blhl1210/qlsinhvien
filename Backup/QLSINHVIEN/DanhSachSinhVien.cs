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
    public partial class DanhSachSinhVien : Form
    {
        int rowIndex;
        public DanhSachSinhVien()
        {
            InitializeComponent();
            dtp_NgaySinh.Format = DateTimePickerFormat.Custom;
            dtp_NgaySinh.CustomFormat = "MMMM dd, yyyy - dddd";
            loadForm();
            loadCbb();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            this.tb_MaSV.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            this.tb_HoTen.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            this.tb_Lop.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            this.cb_Khoa.SelectedValue = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            DateTime dt = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString());
            this.dtp_NgaySinh.Value = dt;
        }

        private void loadForm()
        {
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery("Select * From SinhVien");
        }

        private void loadCbb()
        {
            cb_Khoa.DataSource = DataProvider.Instance.ExcuteQuery("Select * From KHOA");
            cb_Khoa.ValueMember = "MaKhoa";
            cb_Khoa.DisplayMember = "TenKhoa";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string cmd = "Insert into SinhVien values('" + tb_MaSV.Text + "','" + tb_HoTen.Text + "','" + tb_Lop.Text + "','" + dtp_NgaySinh.Value.ToString() + "','" + cb_Khoa.SelectedValue.ToString() + "')";
            int res = DataProvider.Instance.ExcuteNonQuery(cmd);
            if (res != 0)
            {
                MessageBox.Show("Đã thêm sinh viên");
                loadForm();
            }
            else
            {
                MessageBox.Show("Không thêm được! ");
            }
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String cmd = String.Format("UPDATE SinhVien SET MaSv = '{0:C2}', HoTen = '{1:C2}', Lop = '{2:C2}',NgaySinh = '{3:C2}', MaKhoa = '{4:C2}' WHERE MaSv = '{5}'", tb_MaSV.Text, tb_HoTen.Text, tb_Lop.Text, dtp_NgaySinh.Value.ToString(), cb_Khoa.SelectedValue.ToString(), tb_MaSV.Text);
            int res = DataProvider.Instance.ExcuteNonQuery(cmd);
            if (res != 0)
            {
                MessageBox.Show("Đã sửa sinh viên");
                loadForm();
            }
            else
            {
                MessageBox.Show("Không sửa được! ");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            String cmd = "Delete FROM  SINHVIEN Where MaSv = '" + tb_MaSV.Text + "'";
            int res = DataProvider.Instance.ExcuteNonQuery(cmd);
            if (res != 0)
            {
                MessageBox.Show("Đã xóa sinh viên");
                loadForm();
            }
            else
            {
                MessageBox.Show("Không xóa được! ");
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
