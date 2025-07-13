using System;
using WindowsFormsApp1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quanlythuvien1
{
    public partial class Form1 : Form
    {

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();

            // Ẩn mật khẩu
            matkhau.PasswordChar = '*';

            // Gắn sự kiện nút
            buttondangnhap.Click += buttondangnhap_Click;
        }

        private void buttondangnhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đăng nhập (nếu cần)
            string username = tendangnhap.Text;
            string password = matkhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu");
                return;
            }
            // Tạo và hiển thị form menu
             MainMenuForm mainMenu = new MainMenuForm();  // Tạo instance của form menu
            mainMenu.Show();             // Hiển thị form menu

            this.Hide();                 // Ẩn form đăng nhập hiện tại

            // Xử lý khi đóng form menu
            mainMenu.FormClosed += (s, args) => this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Mã chuyển sang form menu
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
