-- Bảng Sách
CREATE TABLE Sach (
    MaSach INT IDENTITY(1,1) PRIMARY KEY,
    TenSach NVARCHAR(255) NOT NULL,
    MaTacGia INT,
    MaNXB INT,
    NamXuatBan INT,
    ISBN VARCHAR(20),
    SoLuong INT DEFAULT 0,
    CONSTRAINT CHK_SoLuong CHECK (SoLuong >= 0)
);

-- Bảng Tác giả
CREATE TABLE TacGia (
    MaTacGia INT IDENTITY(1,1) PRIMARY KEY,
    TenTacGia NVARCHAR(100) NOT NULL,
    QuocTich NVARCHAR(50)
);

-- Bảng Nhà xuất bản
CREATE TABLE NhaXuatBan (
    MaNXB INT IDENTITY(1,1) PRIMARY KEY,
    TenNXB NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(255),
    DienThoai VARCHAR(15)
);

-- Bảng Độc giả
CREATE TABLE DocGia (
    MaDocGia INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    DiaChi NVARCHAR(255),
    DienThoai VARCHAR(15),
    NgayDangKy DATE DEFAULT GETDATE(),
    LoaiDocGia NVARCHAR(20) CHECK (LoaiDocGia IN ('Sinh vien', 'Giao vien', 'Khac'))
);

-- Bảng Phiếu mượn
CREATE TABLE PhieuMuon (
    MaPhieu INT IDENTITY(1,1) PRIMARY KEY,
    MaDocGia INT NOT NULL,
    NgayMuon DATE DEFAULT GETDATE(),
    HanTra DATE,
    NgayTra DATE,
    CONSTRAINT FK_DocGia FOREIGN KEY (MaDocGia) REFERENCES DocGia(MaDocGia),
    CONSTRAINT CHK_HanTra CHECK (HanTra > NgayMuon)
);

-- Bảng Chi tiết mượn sách
CREATE TABLE ChiTietMuon (
    MaChiTiet INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieu INT NOT NULL,
    MaSach INT NOT NULL,
    SoLuong INT DEFAULT 1,
    CONSTRAINT FK_PhieuMuon FOREIGN KEY (MaPhieu) REFERENCES PhieuMuon(MaPhieu),
    CONSTRAINT FK_Sach FOREIGN KEY (MaSach) REFERENCES Sach(MaSach),
    CONSTRAINT CHK_SoLuongMuon CHECK (SoLuong > 0)
);
ALTER TABLE Sach
ADD CONSTRAINT FK_Sach_TacGia FOREIGN KEY (MaTacGia) REFERENCES TacGia(MaTacGia);

ALTER TABLE Sach
ADD CONSTRAINT FK_Sach_NXB FOREIGN KEY (MaNXB) REFERENCES NhaXuatBan(MaNXB);
-- Ràng buộc kiểm tra năm xuất bản
ALTER TABLE Sach
ADD CONSTRAINT CHK_NamXuatBan CHECK (NamXuatBan BETWEEN 1900 AND YEAR(GETDATE()));

-- Ràng buộc kiểm tra tuổi độc giả
ALTER TABLE DocGia
ADD CONSTRAINT CHK_TuoiDocGia CHECK (DATEDIFF(YEAR, NgaySinh, GETDATE()) >= 12);
-- View xem sách đang được mượn
CREATE VIEW vw_SachDangMuon AS
SELECT 
    s.MaSach, 
    s.TenSach, 
    dg.HoTen AS TenDocGia,
    pm.NgayMuon,
    pm.HanTra
FROM Sach s
JOIN ChiTietMuon ct ON s.MaSach = ct.MaSach
JOIN PhieuMuon pm ON ct.MaPhieu = pm.MaPhieu
JOIN DocGia dg ON pm.MaDocGia = dg.MaDocGia
WHERE pm.NgayTra IS NULL;
-- Thêm tác giả
INSERT INTO TacGia (TenTacGia, QuocTich) 
VALUES 
    (N'Nguyễn Nhật Ánh', N'Việt Nam'),
    (N'Haruki Murakami', N'Nhật Bản');

-- Thêm nhà xuất bản
INSERT INTO NhaXuatBan (TenNXB, DiaChi, DienThoai)
VALUES 
    (N'NXB Trẻ', N'161B Lý Chính Thắng, Q.3, TP.HCM', '02839316289'),
    (N'NXB Kim Đồng', N'55 Quang Trung, Hà Nội', '02439434753');

-- Thêm sách
INSERT INTO Sach (TenSach, MaTacGia, MaNXB, NamXuatBan, ISBN, SoLuong)
VALUES
    (N'Cho tôi xin một vé đi tuổi thơ', 1, 1, 2008, '978-604-1-00001-5', 10),
    (N'Rừng Na Uy', 2, 2, 2009, '978-604-2-00002-6', 5);

-- Thêm độc giả
INSERT INTO DocGia (HoTen, NgaySinh, DiaChi, DienThoai, LoaiDocGia)
VALUES
    (N'Nguyễn Văn A', '2000-05-15', N'Hà Nội', '0912345678', 'Sinh vien'),
    (N'Trần Thị B', '1995-10-20', N'TP.HCM', '0987654321', 'Giao vien');