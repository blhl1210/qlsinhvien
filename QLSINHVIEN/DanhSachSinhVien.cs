using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            try
            {
                rowIndex = e.RowIndex;
            this.tb_MaSV.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            this.tb_HoTen.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            this.tb_DiaChi.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            
                DateTime dt = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString());
                this.dtp_NgaySinh.Value = dt;
           
            this.cb_Lop.SelectedValue = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            Console.WriteLine(dataGridView1.Rows[rowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void loadForm()
        {
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery("Select * From SinhVien");
        }

        private void loadCbb()
        {
            cb_Lop.DataSource = DataProvider.Instance.ExcuteQuery("Select * From Lop");
            cb_Lop.ValueMember = "MaLop";
            cb_Lop.DisplayMember = "TenLop";
        }

        private byte[] imageToBytes(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, ImageFormat.Bmp);
                return stream.ToArray();
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
      //      Console.WriteLine(Encoding.UTF8.GetString(imageToBytes(pb_AnhDaiDien.Image)));
            string cmd = "Insert into SinhVien values('" + tb_MaSV.Text + "','" + tb_HoTen.Text + "','" + tb_DiaChi.Text + "','" + dtp_NgaySinh.Value.ToString() + "','" + cb_Lop.SelectedValue.ToString() + "', @imgs )";
            int res = DataProvider.Instance.ExcuteNonQueryPic(cmd, imageToBytes(pb_AnhDaiDien.Image));
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
            String cmd = String.Format("UPDATE SinhVien SET MaSv = '{0:C2}', HoTen = '{1:C2}', DiaChi = '{2:C2}',NgaySinh = '{3:C2}', HinhAnh=@imgs WHERE MaSv = '{4}'", tb_MaSV.Text, tb_HoTen.Text, tb_DiaChi.Text, dtp_NgaySinh.Value.ToString() , tb_MaSV.Text);
            Console.WriteLine(cmd);
            int res = DataProvider.Instance.ExcuteNonQueryPic(cmd,imageToBytes(pb_AnhDaiDien.Image));
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


        private void btn_Duyet_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open file";
            openFileDialog.InitialDirectory = @"D:\Pb";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb_AnhDaiDien.Image = new Bitmap(openFileDialog.OpenFile());
            }

        }
    }
}
