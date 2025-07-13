using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WindowsFormsApp1;


namespace WindowsFormsApp1
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            this.FormClosed += Menu_FormClosed;
            this.Load += MainMenuForm_Load;
            buttonXoa.FlatStyle = FlatStyle.Flat;
            buttonXoa.FlatAppearance.BorderSize = 0;
            buttonXoa.BackColor = Color.Firebrick;
            buttonXoa.ForeColor = Color.White;
            BoGocButton(buttonXoa, 15);
            buttonThem.FlatStyle = FlatStyle.Flat;
            buttonThem.FlatAppearance.BorderSize = 0;
            buttonThem.BackColor = Color.Gold;
            buttonThem.ForeColor = Color.Black;
            BoGocButton(buttonThem, 15);

            buttonThem2.FlatStyle = FlatStyle.Flat;
            buttonThem2.FlatAppearance.BorderSize = 0;
            buttonThem2.BackColor = Color.Gold;
            buttonThem2.ForeColor = Color.Black;
            BoGocButton(buttonThem2, 15);

            buttonThem3.FlatStyle = FlatStyle.Flat;
            buttonThem3.FlatAppearance.BorderSize = 0;
            buttonThem3.BackColor = Color.Gold;
            buttonThem3.ForeColor = Color.Black;
            BoGocButton(buttonThem3, 15);

            buttonThem4.FlatStyle = FlatStyle.Flat;
            buttonThem4.FlatAppearance.BorderSize = 0;
            buttonThem4.BackColor = Color.Gold;
            buttonThem4.ForeColor = Color.Black;
            BoGocButton(buttonThem4, 15);

            buttonThem5.FlatStyle = FlatStyle.Flat;
            buttonThem5.FlatAppearance.BorderSize = 0;
            buttonThem5.BackColor = Color.Gold;
            buttonThem5.ForeColor = Color.Black;
            BoGocButton(buttonThem5, 15);
            // Các nút XÓA - nền đỏ, chữ trắng
            buttonXoa.FlatStyle = FlatStyle.Flat;
            buttonXoa.FlatAppearance.BorderSize = 0;
            buttonXoa.BackColor = Color.Firebrick;
            buttonXoa.ForeColor = Color.White;
            BoGocButton(buttonXoa, 15);

            buttonXoa1.FlatStyle = FlatStyle.Flat;
            buttonXoa1.FlatAppearance.BorderSize = 0;
            buttonXoa1.BackColor = Color.Firebrick;
            buttonXoa1.ForeColor = Color.White;
            BoGocButton(buttonXoa1, 15);

            buttonXoa2.FlatStyle = FlatStyle.Flat;
            buttonXoa2.FlatAppearance.BorderSize = 0;
            buttonXoa2.BackColor = Color.Firebrick;
            buttonXoa2.ForeColor = Color.White;
            BoGocButton(buttonXoa2, 15);

            buttonXoa5.FlatStyle = FlatStyle.Flat;
            buttonXoa5.FlatAppearance.BorderSize = 0;
            buttonXoa5.BackColor = Color.Firebrick;   
            buttonXoa5.ForeColor = Color.White;  
            BoGocButton(buttonXoa5, 15);

            buttonXoa6.FlatStyle = FlatStyle.Flat;
            buttonXoa6.FlatAppearance.BorderSize = 0;
            buttonXoa6.BackColor = Color.Firebrick;   
            buttonXoa6.ForeColor = Color.White;  
            BoGocButton(buttonXoa6, 15);

            buttonSua.FlatStyle = FlatStyle.Flat;
            buttonSua.FlatAppearance.BorderSize = 0;
            buttonSua.BackColor = Color.Blue;   
            buttonSua.ForeColor = Color.White;  
            BoGocButton(buttonSua, 15);
            buttonSua2.FlatStyle = FlatStyle.Flat;
            buttonSua2.FlatAppearance.BorderSize = 0;
            buttonSua2.BackColor = Color.Blue;   
            buttonSua2.ForeColor = Color.White;  
            BoGocButton(buttonSua2, 15);
            buttonSua3.FlatStyle = FlatStyle.Flat;
            buttonSua3.FlatAppearance.BorderSize = 0;
            buttonSua3.BackColor = Color.Blue;   
            buttonSua3.ForeColor = Color.White;  
            BoGocButton(buttonSua3, 15);
            buttonSua4.FlatStyle = FlatStyle.Flat;
            buttonSua4.FlatAppearance.BorderSize = 0;
            buttonSua4.BackColor = Color.Blue;   
            buttonSua4.ForeColor = Color.White;  
            BoGocButton(buttonSua4, 15); 
            buttonSua5.FlatStyle = FlatStyle.Flat;
            buttonSua5.FlatAppearance.BorderSize = 0;
            buttonSua5.BackColor = Color.Blue;   
            buttonSua5.ForeColor = Color.White;  
            BoGocButton(buttonSua5, 15);
        }


        private void chiTietMuonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiTietMuonBindingSource.EndEdit();
            

        }

        private void chiTietMuonBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.chiTietMuonBindingSource.EndEdit();
           

        }

        private void menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlthuvvDataSet.TheLoaiSach' table. You can move, or remove it, as needed.
            this.theLoaiSachTableAdapter.Fill(this.qlthuvvDataSet.TheLoaiSach);
            // TODO: This line of code loads data into the 'qlthuvvDataSet.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter.Fill(this.qlthuvvDataSet.TheLoai);
            this.sachTableAdapter.Fill(this.qlthuvvDataSet.Sach);
            this.phieuMuonTableAdapter.Fill(this.qlthuvvDataSet.PhieuMuon);
            this.docGiaTableAdapter.Fill(this.qlthuvvDataSet.DocGia);
            this.chiTietPhieuMuonTableAdapter.Fill(this.qlthuvvDataSet.ChiTietPhieuMuon);
        }
        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void buttondangnhap_Click(object sender, EventArgs e)
        {
            MainMenuForm frmMenu = new MainMenuForm();
            frmMenu.Show();
            this.Hide();
        }
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
        }
        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            int maPhieu = (int)maPhieuNumericUpDown.Value;
            int maSach = (int)maSachNumericUpDown.Value;
            DateTime ngayTra = ngayTraDateTimePicker.Value;
            string tinhTrang = tinhTrangSachComboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(tinhTrang))
            {
                MessageBox.Show("Vui lòng nhập tình trạng sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=qlthuvv;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = @"
                INSERT INTO ChiTietPhieuMuon (MaPhieu, MaSach, NgayTra, TinhTrangSach)
                OUTPUT INSERTED.MaChiTiet
                VALUES (@MaPhieu, @MaSach, @NgayTra, @TinhTrangSach)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmd.Parameters.AddWithValue("@MaSach", maSach);
                        cmd.Parameters.AddWithValue("@NgayTra", ngayTra);
                        cmd.Parameters.AddWithValue("@TinhTrangSach", tinhTrang);
                        int newID = (int)cmd.ExecuteScalar();
                        if (newID > 0)
                        {
                            MessageBox.Show($"Thêm thành công! Mã chi tiết mới: {newID}",
                                            "Thông báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu nào được thêm.",
                                            "Cảnh báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                        }
                    }
                }
                this.chiTietPhieuMuonTableAdapter.Fill(this.qlthuvvDataSet.ChiTietPhieuMuon);
                chiTietPhieuMuonDataGridView.Refresh();
                if (chiTietPhieuMuonDataGridView.Rows.Count > 0)
                {
                    chiTietPhieuMuonDataGridView.FirstDisplayedScrollingRowIndex = chiTietPhieuMuonDataGridView.Rows.Count - 1;
                }
                this.chiTietPhieuMuonTableAdapter.Fill(this.qlthuvvDataSet.ChiTietPhieuMuon);
                maPhieuNumericUpDown.Value = 1;
                maSachNumericUpDown.Value = 1;
                tinhTrangSachComboBox.SelectedIndex = -1;
                ngayTraDateTimePicker.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            chiTietPhieuMuonDataGridView.FirstDisplayedScrollingRowIndex = chiTietPhieuMuonDataGridView.Rows.Count - 1;
        }
        private void chiTietPhieuMuonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void chiTietPhieuMuonDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            chiTietPhieuMuonDataGridView.ScrollBars = ScrollBars.Vertical;
            chiTietPhieuMuonDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.chiTietPhieuMuonDataGridView.FirstDisplayedScrollingRowIndex = this.chiTietPhieuMuonDataGridView.RowCount - 1;
            this.chiTietPhieuMuonDataGridView.Refresh();

        }
        private void buttonThem2_Click(object sender, EventArgs e)
        {
            int maDocGia = Convert.ToInt32(maDocGiaNumericUpDown.Value);
            string hoTen = hoTenTextBox.Text;
            DateTime ngaySinh = ngaySinhDateTimePicker.Value;
            DateTime ngayDangKy = ngayDangKyDateTimePicker.Value;
            string gioiTinh = gioiTinhTextBox.Text;
            string diaChi = diaChiTextBox.Text;
            string soDienThoai = soDienThoaiTextBox.Text;
            string email = emailTextBox.Text;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlthuvv;Integrated Security=True";
            string query = "INSERT INTO DocGia ( HoTen, NgaySinh, NgayDangKy, GioiTinh, DiaChi, SoDienThoai, Email) " +
                           "VALUES ( @HoTen, @NgaySinh, @NgayDangKy, @GioiTinh, @DiaChi, @SoDienThoai, @Email)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@NgayDangKy", ngayDangKy);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm độc giả thành công!");
                        LoadDocGiaData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void LoadDocGiaData()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlthuvv;Integrated Security=True";
            string query = "SELECT * FROM DocGia";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    docGiaDataGridView.DataSource = dt; 
                }
            }
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            LoadDocGiaData();
        }

        private void buttonThem3_Click(object sender, EventArgs e)
        {
            int maPhieu = (int)maPhieuNumericUpDown1.Value;
            int maDocGia = (int)maDocGiaNumericUpDown1.Value;
            DateTime ngayMuon = ngayMuonDateTimePicker.Value;
            DateTime hanTra = hanTraDateTimePicker.Value;
            string tinhTrang = tinhTrangTextBox.Text;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlthuvv;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PhieuMuon ( MaDocGia, NgayMuon, HanTra, TinhTrang) " +
                               "VALUES ( @MaDocGia, @NgayMuon, @HanTra, @TinhTrang)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaDocGia", maDocGia);
                    command.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                    command.Parameters.AddWithValue("@HanTra", hanTra);
                    command.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm dữ liệu thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
                    }
                }
            }
        }

        private void buttonThem4_Click(object sender, EventArgs e)
        {
            int maSach = (int)maSachNumericUpDown1.Value;
            string tenSach = tenSachTextBox.Text;
            string tenTacGia = tacGiaTextBox.Text;
            int maTheLoai = (int)maTheLoaiNumericUpDown.Value;
            string namXuatBan = namXuatBanTextBox.Text;
            string nhaXuatBan = nhaXuatBanTextBox.Text;
            string soTrang = soTrangTextBox.Text;
            int soLuong = (int)soLuongNumericUpDown.Value;

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlthuvv;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Sach ( TenSach, TacGia, MaTheLoai, NamXuatBan, NhaXuatBan, SoTrang, SoLuong) " +
                               "VALUES ( @TenSach, @TacGia, @MaTheLoai, @NamXuatBan, @NhaXuatBan, @SoTrang, @SoLuong)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenSach", tenSach);
                    command.Parameters.AddWithValue("@TacGia", tenTacGia);
                    command.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                    command.Parameters.AddWithValue("@NamXuatBan", namXuatBan);
                    command.Parameters.AddWithValue("@NhaXuatBan", nhaXuatBan);
                    command.Parameters.AddWithValue("@SoTrang", soTrang);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Thêm sách thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm sách.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (chiTietPhieuMuonDataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in chiTietPhieuMuonDataGridView.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            chiTietPhieuMuonDataGridView.Rows.Remove(row);
                        }
                    }
                    this.Validate();
                    chiTietMuonBindingSource.EndEdit();
                    chiTietPhieuMuonTableAdapter.Update(qlthuvvDataSet.ChiTietPhieuMuon);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonXoa1_Click(object sender, EventArgs e)
        {
            if (docGiaDataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa độc giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in docGiaDataGridView.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            docGiaDataGridView.Rows.Remove(row);
                        }
                    }
                    this.Validate();
                    docGiaBindingSource.EndEdit();
                    docGiaTableAdapter.Update(qlthuvvDataSet.DocGia);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonXoa2_Click(object sender, EventArgs e)
        {
            if (phieuMuonDataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa dòng này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in phieuMuonDataGridView.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            phieuMuonDataGridView.Rows.Remove(row);
                        }
                    }

                    try
                    {
                        this.Validate();
                        phieuMuonBindingSource.EndEdit();
                        phieuMuonTableAdapter.Update(qlthuvvDataSet.PhieuMuon);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BoGocButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            int d = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }
        private void buttonXoa5_Click_1(object sender, EventArgs e)
        {
            if (sachDataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa dòng này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in sachDataGridView.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            sachDataGridView.Rows.Remove(row);
                        }
                    }

                    try
                    {
                        this.Validate();
                        sachBindingSource.EndEdit(); 
                        sachTableAdapter.Update(qlthuvvDataSet.Sach); 
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonThem5_Click(object sender, EventArgs e)
        {
            int maTheLoai = (int)maTheLoaiNumericUpDown.Value; 
            string tenTheLoai = tenTheLoaiTextBox.Text;       
            string moTa = moTaTextBox.Text;                   

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlthuvv;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TheLoai ( TenTheLoai, MoTa) " +
                               "VALUES ( @TenTheLoai, @MoTa)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenTheLoai", tenTheLoai);
                    command.Parameters.AddWithValue("@MoTa", moTa);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Thêm thể loại thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm thể loại.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void buttonXoa6_Click(object sender, EventArgs e)
        {
            if (theLoaiDataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa dòng này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in theLoaiDataGridView.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            theLoaiDataGridView.Rows.Remove(row);
                        }
                    }

                    try
                    {
                        this.Validate();
                        theLoaiBindingSource.EndEdit();
                        theLoaiTableAdapter.Update(qlthuvvDataSet.TheLoai);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSua5_Click(object sender, EventArgs e)
        {

            int maTheLoai = (int)maTheLoaiNumericUpDown.Value;
            string tenTheLoai = tenTheLoaiTextBox.Text;
            string moTa = moTaTextBox.Text;

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlthuvv;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE TheLoai
                     SET TenTheLoai = @TenTheLoai,
                         MoTa = @MoTa
                     WHERE MaTheLoai = @MaTheLoai";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                    command.Parameters.AddWithValue("@TenTheLoai", tenTheLoai);
                    command.Parameters.AddWithValue("@MoTa", moTa);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Cập nhật thể loại thành công!");
                            // Optional: làm mới lại DataGridView nếu bạn có
                            // this.theLoaiTableAdapter.Fill(this.qlthuvvDataSet.TheLoai);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thể loại để cập nhật.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

        }
        private void theLoaiDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = theLoaiDataGridView.Rows[e.RowIndex];

                maTheLoaiNumericUpDown.Value = Convert.ToInt32(row.Cells["MaTheLoai"].Value);
                tenTheLoaiTextBox.Text = row.Cells["TenTheLoai"].Value.ToString();
                moTaTextBox.Text = row.Cells["MoTa"].Value.ToString();
            }
        }

        private void buttonSua2_Click(object sender, EventArgs e)
        {
            int maDocGia = Convert.ToInt32(maDocGiaNumericUpDown.Value);
            string hoTen = hoTenTextBox.Text.Trim();
            DateTime ngaySinh = ngaySinhDateTimePicker.Value;
            DateTime ngayDangKy = ngayDangKyDateTimePicker.Value;
            string gioiTinh = gioiTinhTextBox.Text.Trim();
            string diaChi = diaChiTextBox.Text.Trim();
            string soDienThoai = soDienThoaiTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();

            // Chuỗi kết nối
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlthuvv;Integrated Security=True";

            // Câu lệnh UPDATE để cập nhật thông tin độc giả
            string query = @"UPDATE DocGia 
                     SET HoTen = @HoTen,
                         NgaySinh = @NgaySinh,
                         NgayDangKy = @NgayDangKy,
                         GioiTinh = @GioiTinh,
                         DiaChi = @DiaChi,
                         SoDienThoai = @SoDienThoai,
                         Email = @Email
                     WHERE MaDocGia = @MaDocGia";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Gán giá trị tham số
                    cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@NgayDangKy", ngayDangKy);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã cập nhật thông tin độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDocGiaData(); // Làm mới DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy độc giả cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            int maChiTiet = (int)maChiTietTextBox.Value; // hoặc lấy từ dòng đang chọn
            int maPhieu = (int)maPhieuNumericUpDown.Value;
            int maSach = (int)maSachNumericUpDown.Value;
            DateTime ngayTra = ngayTraDateTimePicker.Value;
            string tinhTrang = tinhTrangSachComboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(tinhTrang))
            {
                MessageBox.Show("Vui lòng nhập tình trạng sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=qlthuvv;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = @"
            UPDATE ChiTietPhieuMuon
            SET MaPhieu = @MaPhieu,
                MaSach = @MaSach,
                NgayTra = @NgayTra,
                TinhTrangSach = @TinhTrangSach
            WHERE MaChiTiet = @MaChiTiet";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaChiTiet", maChiTiet);
                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmd.Parameters.AddWithValue("@MaSach", maSach);
                        cmd.Parameters.AddWithValue("@NgayTra", ngayTra);
                        cmd.Parameters.AddWithValue("@TinhTrangSach", tinhTrang);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!",
                                            "Thông báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu nào được cập nhật.",
                                            "Cảnh báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                        }
                    }
                }

                // Làm mới DataGridView
                this.chiTietPhieuMuonTableAdapter.Fill(this.qlthuvvDataSet.ChiTietPhieuMuon);
                chiTietPhieuMuonDataGridView.Refresh();

                if (chiTietPhieuMuonDataGridView.Rows.Count > 0)
                {
                    chiTietPhieuMuonDataGridView.FirstDisplayedScrollingRowIndex = chiTietPhieuMuonDataGridView.Rows.Count - 1;
                }

                // Reset form nhập liệu
                maChiTietTextBox.Value = 1;
                maPhieuNumericUpDown.Value = 1;
                maSachNumericUpDown.Value = 1;
                tinhTrangSachComboBox.SelectedIndex = -1;
                ngayTraDateTimePicker.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSua3_Click(object sender, EventArgs e)
        {
            // Kiểm tra có hàng nào được chọn không
            if (sachDataGridView.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn đầu tiên
                DataGridViewRow selectedRow = sachDataGridView.SelectedRows[0];

                // Cập nhật giá trị của hàng đó từ các ô nhập
                selectedRow.Cells["MaSach"].Value = (int)maSachNumericUpDown1.Value;
                selectedRow.Cells["TenSach"].Value = tenSachTextBox.Text;
                selectedRow.Cells["TacGia"].Value = tacGiaTextBox.Text;
                selectedRow.Cells["MaTheLoai"].Value = (int)maTheLoaiNumericUpDown.Value;
                selectedRow.Cells["NamXuatBan"].Value = namXuatBanTextBox.Text;

                MessageBox.Show("Đã sửa thông tin sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSua4_Click(object sender, EventArgs e)
        {
            int maSach = (int)maSachNumericUpDown1.Value;
            string tenSach = tenSachTextBox.Text;
            string tenTacGia = tacGiaTextBox.Text;
            int maTheLoai = (int)maTheLoaiNumericUpDown.Value;
            string namXuatBan = namXuatBanTextBox.Text;
            string nhaXuatBan = nhaXuatBanTextBox.Text;
            string soTrang = soTrangTextBox.Text;
            int soLuong = (int)soLuongNumericUpDown.Value;

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlthuvv;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Sach SET 
                        TenSach = @TenSach,
                        TacGia = @TacGia,
                        MaTheLoai = @MaTheLoai,
                        NamXuatBan = @NamXuatBan,
                        NhaXuatBan = @NhaXuatBan,
                        SoTrang = @SoTrang,
                        SoLuong = @SoLuong
                     WHERE MaSach = @MaSach";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Gán các giá trị tham số
                    command.Parameters.AddWithValue("@MaSach", maSach);
                    command.Parameters.AddWithValue("@TenSach", tenSach);
                    command.Parameters.AddWithValue("@TacGia", tenTacGia);
                    command.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                    command.Parameters.AddWithValue("@NamXuatBan", namXuatBan);
                    command.Parameters.AddWithValue("@NhaXuatBan", nhaXuatBan);
                    command.Parameters.AddWithValue("@SoTrang", soTrang);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin sách thành công!");
                            // Tùy chọn: làm mới lại DataGridView nếu có
                            // this.sachTableAdapter.Fill(this.qlthuvvDataSet.Sach);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sách để cập nhật.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

        }
    }
}
