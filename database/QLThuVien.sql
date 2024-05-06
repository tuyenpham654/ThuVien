USE [master]
GO
CREATE DATABASE QuanLyThuVien;

go

USE QuanLyThuVien;

go

CREATE TABLE QuanTriVien(
	MaUS char(5) NOT NULL primary key,
	TenUS nvarchar(50)NOT NULL,
	MatKhau varchar(50)NOT NULL,
	Email nvarchar(50)NOT NULL,
	SDT int NOT NULL
)

go

CREATE TABLE TheThanhVien(
	MaTV varchar(5) NOT NULL primary key,
	TenTV nvarchar(50) NOT NULL,
	DiaChi nvarchar(200) NOT NULL,
	Email nvarchar(50) NULL,
	GioiTinh bit NOT NULL,
	SDT int NOT NULL
)

go

CREATE TABLE LoaiSach(
	Maloai varchar(5) NOT NULL primary key,
	TenLoai nvarchar(50) NOT NULL
)

go

CREATE TABLE TacGia(
	MaTG varchar(10) NOT NULL primary key,
	TenTG nvarchar(250) NOT NULL
)

go


CREATE TABLE Sach(
	MaSach varchar(20) NOT NULL primary key,
	TenSach nvarchar(50) NOT NULL,
	MaLoai varchar(5) NOT NULL,
	MaTG varchar(10) NOT NULL,
	NhaXB nvarchar(50) NOT NULL,
	SoLuong int NOT NULL,
	FOREIGN KEY (MaLoai) REFERENCES LoaiSach (MaLoai),
	FOREIGN KEY (MaTG) REFERENCES TacGia (MaTG),
)

go

CREATE TABLE PhieuMuon(
	MaPM varchar(5) NOT NULL primary key,
	MaTV varchar(5) NOT NULL,
	NgayMuon date NOT NULL,
	NgayTra date NOT NULL,
	FOREIGN KEY (MaTV) REFERENCES thethanhvien (maTV),
	check (ngaytra >= ngaymuon)
)

go


CREATE TABLE ChiTietPM(
	MAPM VARCHAR(5) NOT NULL,
	MASACH VARCHAR(20)NOT NULL,
	TRANGTHAI BIT DEFAULT 0,
	FOREIGN KEY (MAPM) REFERENCES PHIEUMUON(MAPM),
	FOREIGN KEY (MASACH) REFERENCES SACH(MASACH)
)
go

INSERT INTO  [dbo].[QuanTriVien] ([MaUS],[TenUS],[MatKhau],[Email],[SDT]) VALUES('US001','phong','123','phong123@gmail.com',0979687453)

go

INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV001',N'Nguyễn Văn Nam',N'Linh Tây, Thủ Đức, TP.HCM','nguyenvannam@gmail.com','1',0128493736)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV002',N'Trần Thị Mơ',N'Đông Thạnh, Hốc Môn, TP.HCM','tranthimo@gmail.com','0',0958376353)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV003',N'Trần Văn Ngọc',N'Đa Kao, Quận 1, TP.HCM','tranvanngoc@gmail.com','1',0969244797)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV004',N'Nguyễn Thị Vấn',N'Linh Đông, Thủ Đức, TP.HCM','nguyenthivan@gmail.com','0',0968367826)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV005',N'Nguyễn Đăng Nhân',N'An Phú, Quận 2, TP.HCM','nguyendangnhan@gmail.com','1',0967867588)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV006',N'Lê thị Mỹ Dung',N'Lái Thêu, Thuận An, Bình Dương','lethimyxuyen@gmail.com','0',0328794367)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV007',N'Phan Văn Đức',N'Phú Thạnh, Tân Phú, TP.HCM','phanvanduc@gmail.com','1',0336847263)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV008',N'Hoàng Xuân Tuân',N'Cát Lái, Quận 2, TP.HCM','hoanxuantuan@gmail.com','1',0966847867)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV009',N'Trần Thị Hiệp',N'Linh Trung, Thủ Đức, TP.HCM','tranthihiep@gmail.com','0',0577839736)
INSERT INTO  [dbo].[TheThanhVien] ([MaTV],[TenTV],[DiaChi],[Email],[GioiTinh],[SDT]) VALUES('TV010',N'Nguyễn Văn Tài',N'BÌnh Hưng, Bình Chánh, TP.HCM','nguyenvantai@gmail.com','1',0577839736)


go


INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS001',N'Chính trị – Pháp luật')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS002',N'Khoa học công nghệ - Kinh tế')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS003',N'Lập trình')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS004',N'Giáo trình')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS005',N'Tiểu thuyết')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS006',N'Văn học')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS007',N'Lịch Sử')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS008',N'Sách thiếu nhi')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS009',N'Truyện tranh')
INSERT INTO [dbo].[LoaiSach] ([Maloai],[TenLoai]) VALUES('LS010',N'Ngôn Tình')

go

INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG001',N'Phạm Đoan Trang')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG002',N'Phạm Huy Hoàng')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG003',N'Leong Sheng Ying')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG004',N'Nguyễn Văn Hùng')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG005',N'Nhiêu Tuyết Mạn')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG006',N'Trần Đình Sử')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG007',N'Khuyết Danh')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG008',N'Hải Minh')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG009',N'Minh Long')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG010',N'Phỉ Ngã Tư Đồn')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG011',N'Aristotle')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG012',N'Nguyễn Hữu Hưng')
INSERT INTO [dbo].[tacGia] ([MaTG],[TenTG]) VALUES('TG013',N'Khánh Hòa')

go

INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS001',N'Chính Trị Bình Dân','LS001','TG001',N'Nhà xuất bản Luật Khoa Tập Chí',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS002',N'Học Chính Sách Công Qua Chuyện Đặc Khu','LS001','TG001',N'nhà xuất bản Luật Khoa Tập Chí',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS003',N'Chính Trị Luật','LS001','TG011',N'nhà xuất bản thế giới',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS004',N'The Nicomachean Ethics','LS001','TG011',N'nhà xuất bản thế giới',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS005',N'Lập Trình Đâu Phải Chỉ Biết Code','LS003','TG002',N'Nhà Xuất Bản Dân Chí',100)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS006',N'Cuộc Sống Code và Lập Trình','LS003','TG002',N'Nhà xuất bản dân chí',100)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS007',N'Sách Lập Trình Với Scratch 3.0','LS003','TG012',N'Nhà Xuất Bản đại học quốc gia hà nội',100)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS008',N'Lập Trình Với C#','LS003','TG012',N'Nhà Xuất Bản đại học quốc gia hà nội',100)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS009',N'Nhà Khoa Học Trẻ - Cấp Độ 2','LS002','TG003',N'Nhà xuất bản giáo dục Việt Nam',300)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS010',N'Nhà Khoa Học Trẻ - Cấp Độ 3','LS002','TG003',N'Nhà xuất bản giáo dục Việt Nam',300)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS011',N'Giáo Trình Marketing Căn Bản','LS004','TG004',N'Nhà xuất bản Kinh Tế TPHCM',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS012',N'Thương Mại Điện Tử','LS004','TG004',N'Nhà xuất bản Kinh Tế TPHCM',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS013',N'Bí Mật Thanh Xuân','LS005','TG005',N'Nhà xuất bản thanh niên',150)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS014',N'Tay Trái','LS005','TG005',N'Nhà xuất bản thanh niên',150)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS015',N'Đọc Văn Học Hay','LS006','TG006',N'Nhà xuất bản tri thức',5)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS016',N'Trên Đường Biên Của Lý Luận Văn','LS006','TG006',N'Nhà xuất bản phụ nữ',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS017',N'Sơn Kinh Hải','LS007','TG007',N'Nhà xuất bản văn học',150)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS018',N'Sơn Kinh Hải Đồ','LS007','TG007',N'Nhà xuất bản văn học',150)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS019',N'Đồng Dao Thơ','LS008','TG008',N'Nhà xuất bản phụ nữ',100)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS020',N'Thơ Cho Bé Tập Nói','LS008','TG008',N'Nhà xuất bản phụ nữ',100)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS021',N'Truyện Tranh Tuổi Thần Tiên - Món Quà Của Cô Giáo','LS009','TG009',N'Nhà xuất bản văn học',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS022',N'Truyện Tranh Tuổi Thần Tiên - Cây Táo Thần','LS009','TG009',N'Nhà xuất bản văn học',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS023',N'Thất Tịch Không Mưa','LS010','TG010',N'Nhà xuất bản văn học',50)
INSERT INTO [dbo].[sach] ([MaSach],[TenSach],[MaLoai],[MaTG],[NhaXB],[SoLuong]) VALUES('MS024',N'Đông Cung','LS010','TG010',N'Nhà xuất bản văn học',50)


go

INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM001','TV001','2019-2-3','2019-3-2')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM002','TV002','2019-2-23','2019-2-26')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM003','TV003','2019-3-1','2019-3-15')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM004','TV004','2019-3-2','2019-3-20')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM005','TV005','2019-4-10','2019-4-20')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM006','TV006','2019-6-5','2019-6-29')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM007','TV007','2019-2-10','2019-2-20')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM008','TV008','2019-2-15','2019-2-25')
INSERT INTO [dbo].[PhieuMuon] ([MaPM],[MaTV],[NgayMuon],[NgayTra]) VALUES('PM009','TV009','2019-6-14','2019-6-22')


go


INSERT INTO [dbo].[ChiTietPM] ([MaPM],[MaSach],[TrangThai]) VALUES('PM001','MS001',0)
INSERT INTO [dbo].[ChiTietPM] ([MaPM],[MaSach],[TrangThai]) VALUES('PM001','MS004',1)
INSERT INTO [dbo].[ChiTietPM] ([MaPM],[MaSach],[TrangThai]) VALUES('PM001','MS002',0)
INSERT INTO [dbo].[ChiTietPM] ([MaPM],[MaSach],[TrangThai]) VALUES('PM001','MS003',1)

go

-- trigger thành viên

CREATE TRIGGER Check_TheThanhVien
ON TheThanhVien
INSTEAD OF insert
AS
BEGIN
    SET NOCOUNT ON;

	  -- Kiểm tra sự trùng lặp của mã
    IF EXISTS (SELECT 1 FROM inserted i INNER JOIN TheThanhVien t ON i.MaTV = t.MaTV)
    BEGIN
        RAISERROR('Mã thành viên đã tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra sự trùng lặp của Email
    IF EXISTS (SELECT 1 FROM inserted i INNER JOIN TheThanhVien t ON i.Email = t.Email)
    BEGIN
        RAISERROR('Email đã tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra sự trùng lặp của Số điện thoại
    IF EXISTS (SELECT 1 FROM inserted i INNER JOIN TheThanhVien t ON i.SDT = t.SDT)
    BEGIN
        RAISERROR('Số điện thoại đã tồn tại.', 16, 1);
        RETURN;
    END;

    -- Thực hiện INSERT vào bảng TheThanhVien nếu không có sự trùng lặp
    INSERT INTO TheThanhVien (MaTV, TenTV, DiaChi, Email, GioiTinh, SDT)
    SELECT MaTV, TenTV, DiaChi, Email, GioiTinh, SDT
    FROM inserted;
END;

go
-- trigger mã loại k được trùng

CREATE TRIGGER Check_MaLoai
ON LoaiSach
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra mã loại đã tồn tại
    IF EXISTS (SELECT 1 FROM inserted i INNER JOIN LoaiSach b ON i.Maloai = b.Maloai)
    BEGIN
        RAISERROR ('Mã loại đã tồn tại trong bảng.', 16, 1);
        RETURN; 
    END

	else
	BEGIN
        --thực hiện lệnh INSERT
        INSERT INTO LoaiSach (Maloai, TenLoai)
        SELECT Maloai, TenLoai
        FROM INSERTED;
    END
END;

go
-- trigger mã tác giả k được trùng

CREATE TRIGGER Check_MaTG
ON TacGia
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra tác giả đã tồn tại
    IF EXISTS (SELECT 1 FROM inserted i INNER JOIN TacGia b ON i.MaTG = b.MaTG)
    BEGIN
        RAISERROR ('Mã loại đã tồn tại trong bảng.', 16, 1);
        RETURN; 
    END

	else
	BEGIN
        --thực hiện lệnh INSERT
        INSERT INTO TacGia(MaTG, TenTG)
        SELECT MaTG, TenTG
        FROM INSERTED;
    END
END;

go
-- viết trigger khi insert kiểm tra lỗi Mã Sách đã tồn tại và Số Lượng nhỏ hơn 0 của bảng sách
CREATE TRIGGER Check_MaSach_SoLuong
ON Sach
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra MaSach đã tồn tại
    IF EXISTS (SELECT 1 FROM inserted i INNER JOIN Sach b ON i.MaSach = b.MaSach)
    BEGIN
        RAISERROR ('Mã sách đã tồn tại trong bảng.', 16, 1);
		ROLLBACK TRANSACTION;
        RETURN; 
    END

	---- Kiểm tra SoLuong
    else if EXISTS (SELECT 1 FROM inserted WHERE SoLuong <= 0)
    BEGIN
        RAISERROR ('Giá trị của số lượng phải lớn hơn 0.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
	else
	BEGIN
        --thực hiện lệnh INSERT
        INSERT INTO Sach(MaSach, TenSach,MaLoai,MaTG,NhaXB,SoLuong)
        SELECT MaSach, TenSach,MaLoai,MaTG,NhaXB,SoLuong
        FROM INSERTED;
    END
END;


go

-- viết trigger khi update. Số lượng phải lớn hơn 0 của bảng sách
CREATE TRIGGER Check_SoLuong_update ON Sach
AFTER UPDATE
AS
BEGIN
    -- Kiểm tra SoLuong
   IF EXISTS (SELECT 1 FROM inserted WHERE SoLuong <= 0 OR ISNUMERIC(SoLuong) = 0)
    BEGIN
        RAISERROR ('Giá trị của số lượng phải lớn hơn 0.', 16, 1);
        ROLLBACK TRANSACTION; 
        RETURN;
    END
END;

go
-- trigger kiểm tra mã sách đã tồn tại trong 1 phiếu mượn

CREATE TRIGGER LimitSach_Phieu ON ChiTietPM
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @SoSach INT
    SELECT @SoSach = COUNT(*) FROM inserted

    IF @SoSach > 5
    BEGIN
        RAISERROR ('Chỉ được thuê tối đa 5 cuốn sách thôi.', 16, 1)
        RETURN
    END
    
    IF EXISTS (SELECT 1 FROM inserted i WHERE EXISTS (SELECT 1 FROM ChiTietPM WHERE ChiTietPM.MAPM = i.MAPM AND ChiTietPM.MASACH = i.MASACH))
    BEGIN
        RAISERROR ('Không được thuê 2 sách giống nhau trong cùng một phiếu mượn.', 16, 1)
        RETURN
    END

    INSERT INTO ChiTietPM (MAPM, MASACH, TRANGTHAI)
    SELECT MAPM, MASACH, TRANGTHAI
    FROM inserted
END

go

CREATE TRIGGER Check_Ma_Ngay
ON PhieuMuon
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra sự trùng lặp của Mã phiếu mượn
    IF EXISTS (SELECT 1 FROM inserted i INNER JOIN PhieuMuon p ON i.MaPM = p.MaPM)
    BEGIN
        RAISERROR('Mã phiếu mượn đã tồn tại.', 16, 1);
        RETURN;
    END;

	 -- Kiểm tra mã thành viên tồn tại
    IF EXISTS ( SELECT 1 FROM inserted i LEFT JOIN TheThanhVien tv ON i.MaTV = tv.MaTV WHERE tv.MaTV IS NULL
    )
    BEGIN
        RAISERROR('Mã thành viên không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra ngày trả phải lớn hơn hoặc bằng ngày mượn
   IF EXISTS (SELECT 1 FROM inserted WHERE DATEDIFF(day, NgayMuon, NgayTra) < 7 OR DATEDIFF(day, NgayMuon, NgayTra) > 30
    )
    BEGIN
        RAISERROR('Ngày trả phải lớn hơn ngày mượn ít nhất 1 tuần và không quá 1 tháng.', 16, 1);
        RETURN;
    END;

    -- Thực hiện insert
    INSERT INTO PhieuMuon (MaPM, MaTV, NgayMuon, NgayTra)
    SELECT MaPM, MaTV, NgayMuon, NgayTra
    FROM inserted;
END;


go

-- view thẻ thành viên

CREATE VIEW View_TheThanhVien AS
SELECT MaTV, TenTV, DiaChi, Email, GioiTinh, SDT
	   FROM TheThanhVien;



go
--- view phiếu mượn và chi tiết phiếu 
CREATE VIEW View_PhieuMuon_CT AS
	SELECT PM.MaPM, PM.MaTV, TV.TenTV, TV.SDT, S.TenSach, CT.MASACH, PM.NgayMuon, PM.NgayTra,
    CASE WHEN CT.TRANGTHAI = 'True' THEN N'Đã trả' ELSE N'Đang thuê' END AS [TrangThai]
	FROM PhieuMuon PM JOIN ChiTietPM CT ON PM.MaPM = CT.MAPM JOIN TheThanhVien TV ON PM.MaTV = TV.MaTV JOIN Sach S ON CT.MASACH = S.MaSach;


go

-- tạo views của Sách
CREATE VIEW SachList AS
SELECT s.MaSach, s.TenSach, ls.TenLoai, s.NhaXB, s.SoLuong, s.MaTG, s.MaLoai, tg.TenTG
FROM Sach s
INNER JOIN LoaiSach ls ON s.MaLoai = ls.Maloai Left join TacGia tg ON tg.MaTG = s.MaTG


go

CREATE FUNCTION ThongKe()
RETURNS @KetQua TABLE (
    TongSachKhiNhapVe INT,
	SoSachConTrongKho INT,
    SoSachDangMuon INT,
    SoLuongThanhVien INT,
    SoLuongThanhVienDaMuonSach INT,
	SoPhieu INT
)
AS
BEGIN
   
    DECLARE @TongSachKhiNhapVe INT;
	DECLARE @SoSachConTrongKho INT;
    DECLARE @SoSachDangMuon INT;
    DECLARE @SoLuongThanhVien INT;
    DECLARE @SoLuongThanhVienDaMuonSach INT;
	DECLARE @SoPhieu INT;

    -- Tính tổng số sách khi nhập về
    SELECT @TongSachKhiNhapVe = SUM(SoLuong) + ISNULL((SELECT COUNT(*) FROM ChiTietPM WHERE TrangThai = 0), 0)
    FROM Sach;

	-- Tính số sách còn trong kho
    SELECT @SoSachConTrongKho = SUM(SoLuong)
    FROM Sach;

    -- Tính số sách đang mượn chưa trả
    SELECT @SoSachDangMuon = ISNULL((SELECT COUNT(*) FROM ChiTietPM WHERE TrangThai = 0), 0)
    FROM Sach;

    -- Tính số lượng thành viên
    SELECT @SoLuongThanhVien = COUNT(MaTV)
    FROM TheThanhVien;

    -- Tính số lượng thành viên đã mượn sách
    SELECT @SoLuongThanhVienDaMuonSach = COUNT(DISTINCT MaTV)
    FROM PhieuMuon;

	-- Đếm phiếu mượn 
	SELECT @SoPhieu = COUNT(MaPM)
    FROM PhieuMuon;

    -- Chèn kết quả vào bảng kết quả
    INSERT INTO @KetQua (TongSachKhiNhapVe, SoSachConTrongKho, SoSachDangMuon, SoLuongThanhVien, SoLuongThanhVienDaMuonSach, SoPhieu)
    VALUES ( @TongSachKhiNhapVe, @SoSachConTrongKho, @SoSachDangMuon, @SoLuongThanhVien, @SoLuongThanhVienDaMuonSach, @SoPhieu);

    -- Trả về bảng kết quả
    RETURN;
END;

go



-- stored đăng nhập
CREATE PROCEDURE CheckLogin
    @Username NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

   

    -- Kiểm tra xem tài khoản đăng nhập có hợp lệ không
    SELECT * FROM QuanTriVien WHERE MaUS = @Username AND MatKhau = @Password
  
END;



go


-- sách 
-- stored inser sách
CREATE PROCEDURE InsertSach
    @MaSach varchar(20),
    @TenSach nvarchar(50),
    @MaLoai varchar(5),
    @MaTG varchar(10),
    @NhaXB nvarchar(50),
    @SoLuong int
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem MaLoai và MaTG có tồn tại trong bảng LoaiSach và TacGia hay không

	 IF EXISTS (SELECT 1 FROM Sach WHERE MaSach = @MaSach)
    BEGIN
        RAISERROR('Mã sách đã tồn tại.', 16, 1);
        RETURN;
    END;

    IF NOT EXISTS (SELECT 1 FROM LoaiSach WHERE MaLoai = @MaLoai)
    BEGIN
        RAISERROR('MaLoai không hợp lệ.', 16, 1);
        RETURN;
    END;

    IF NOT EXISTS (SELECT 1 FROM TacGia WHERE MaTG = @MaTG)
    BEGIN
        RAISERROR('MaTG không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Chèn dữ liệu vào bảng Sach
	BEGIN
        INSERT INTO Sach (MaSach, TenSach, MaLoai, MaTG, NhaXB, SoLuong)
        VALUES (@MaSach, @TenSach, @MaLoai, @MaTG, @NhaXB, @SoLuong);
        
        IF @@ROWCOUNT > 0
        BEGIN
            RAISERROR('Thêm thành công.', 16, 1);
            RETURN;
        END;
        ELSE
        BEGIN
            RAISERROR('Thêm thất bại.', 16, 1);
            RETURN;
        END;
    END;
END;



go

-- xóa sách

CREATE PROCEDURE DeleteSach
    @MaSach varchar(20)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem sách có tồn tại trong bảng Sach không
    IF NOT EXISTS (SELECT 1 FROM Sach WHERE MaSach = @MaSach)
    BEGIN
        RAISERROR('Mã sách không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra xem sách có tồn tại trong bảng ChiTietPM không
    IF EXISTS (SELECT 1 FROM ChiTietPM WHERE MASACH = @MaSach)
    BEGIN
        RAISERROR('Không thể xóa sách đã được ghi vào phiếu mượn.', 16, 1);
        RETURN;
    END;

    -- Xóa sách từ bảng Sach
    DELETE FROM Sach WHERE MaSach = @MaSach;
	  IF @@ROWCOUNT > 0

    BEGIN
        -- Trả về thông báo thành công
         RAISERROR('Xóa sách thành công.', 16, 1);
    END
    ELSE
    BEGIN
        -- Trường hợp không có sách nào bị xóa
        RAISERROR('Không có sách nào bị xóa.', 16, 1);
    END;
END;


go


-- stored cập nhật sách
CREATE PROCEDURE UpdateSach
    @MaSach varchar(20),
    @TenSach nvarchar(50),
    @MaLoai varchar(5),
    @MaTG varchar(10),
    @NhaXB nvarchar(50),
    @SoLuong int
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem sách có tồn tại trong bảng Sach không
    IF NOT EXISTS (SELECT 1 FROM Sach WHERE MaSach = @MaSach)
    BEGIN
        RAISERROR('Mã sách không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Cập nhật thông tin sách trong bảng Sach
    UPDATE Sach
    SET TenSach = @TenSach,
        MaLoai = @MaLoai,
        MaTG = @MaTG,
        NhaXB = @NhaXB,
        SoLuong = @SoLuong
    WHERE MaSach = @MaSach;

    -- Trả về thông báo thành công
    RAISERROR('Cập nhật sách thành công.', 16, 1);
END;



go


-- stored tìm kiếm theo tên sách
CREATE PROCEDURE SearchByNameSach
    @TenSach nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Tìm kiếm thông tin của sách dựa trên tên sách
    SELECT * FROM SachList WHERE TenSach LIKE '%' + @TenSach + '%';
END;


EXEC SearchByNameSach d



go


-- stored tìm kiếm theo id sách
CREATE PROCEDURE SearchByIdSach
    @MaSach varchar(20)
AS
BEGIN
    SET NOCOUNT ON;

    -- Tìm kiếm thông tin của sách dựa trên mã sách
    SELECT * FROM SachList WHERE MaSach = @MaSach;
END;

go

-- stored thêm phiếu mượn chi tiết

CREATE PROCEDURE InsertPhieuMuonCT
    @MaPM varchar(5),
    @MaSach varchar(20),
    @TrangThai bit
AS
BEGIN
    BEGIN 
        IF @MaPM IS NULL OR @MaSach IS NULL OR @MaPM = '' OR @MaSach = ''
        BEGIN
            RAISERROR ('Mã phiếu mượn hoặc mã sách không được để trống', 16, 1);
            RETURN;
        END

		-- Kiểm tra số lượng sách trong một phiếu mượn
        DECLARE @SoLuongSachTrongPhieu INT;
        SELECT @SoLuongSachTrongPhieu = COUNT(*)
        FROM ChiTietPM
        WHERE MAPM = @MaPM;

        IF @SoLuongSachTrongPhieu >= 5
        BEGIN
            RAISERROR ('Số lượng sách trong một phiếu mượn không được vượt quá 5 cuốn.', 16, 1);
            RETURN;
        END


		IF EXISTS (SELECT 1 FROM ChiTietPM WHERE MAPM = @MaPM AND MASACH = @MaSach)
		BEGIN
			RAISERROR ('Không được thuê 2 sách giống nhau trong cùng một phiếu mượn.', 16, 1)
			RETURN;
		END

        BEGIN TRANSACTION;
        
        IF @TrangThai = 0
        BEGIN
            DECLARE @SoLuongSach int;
            SELECT @SoLuongSach = SoLuong
            FROM Sach
            WHERE MaSach = @MaSach;
            
            IF @SoLuongSach > 1
            BEGIN
                UPDATE Sach
                SET SoLuong = SoLuong - 1
                WHERE MaSach = @MaSach;
            END
            ELSE
            BEGIN
                RAISERROR ('Sách này đã hết, vui lòng thuê sách khác.', 16, 1);
                ROLLBACK TRANSACTION;
                RETURN;
            END
        END

        INSERT INTO ChiTietPM (MaPM, MaSach, TrangThai)
        VALUES (@MaPM, @MaSach, @TrangThai);

        COMMIT TRANSACTION;
        RAISERROR ('Thêm thành công', 16, 1);

        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;
            RAISERROR ('Thêm thất bại', 16, 1);
        END
    END 
END;


go
-- cập nhật phiếu mượn chi tiết

CREATE PROCEDURE UpdatePhieuMuonCT
    @MaPM varchar(5),
    @MaSach varchar(20),
    @TrangThai bit
AS
BEGIN
    BEGIN

        DECLARE @TrangThaiCu bit;

        -- Lấy trạng thái hiện tại của phiếu trước khi cập nhật
        SELECT @TrangThaiCu = TrangThai 
        FROM ChiTietPM 
        WHERE MaPM = @MaPM AND MaSach = @MaSach;

        IF @TrangThaiCu != @TrangThai
        BEGIN
			
            BEGIN TRANSACTION; 

            -- kiểm tra số lượng sách và cập nhật bảng sách trước khi giảm số lượng, nếu số lượng < 1 thì hủy lệnh
            IF @TrangThai = 0
            BEGIN
                DECLARE @SoLuongSach int;
                SELECT @SoLuongSach = SoLuong
                FROM Sach
                WHERE MaSach = @MaSach;

                IF @SoLuongSach > 1
                BEGIN
                    -- cập nhật số lượng của sách
                    UPDATE Sach
                    SET SoLuong = SoLuong - 1
                    WHERE MaSach = @MaSach;
                END
                ELSE
                BEGIN
                    -- số lượng sách không đủ, rollback
                    RAISERROR ('Số lượng sách không đủ hủy cập nhật', 16, 1);
                    ROLLBACK TRANSACTION;
                    RETURN;
                END
            END

            ELSE IF @TrangThai = 1
            BEGIN
                UPDATE Sach
                SET SoLuong = SoLuong + 1
                WHERE MaSach = @MaSach;
            END

            -- cập nhật bảng chi tiết
            UPDATE ChiTietPM
            SET TrangThai = @TrangThai
            WHERE MaPM = @MaPM AND MaSach = @MaSach;

            COMMIT TRANSACTION;
            RAISERROR ('Cập nhật thành công', 16, 1);

			 IF @@TRANCOUNT > 0
			BEGIN
            ROLLBACK TRANSACTION;
            RAISERROR ('Lỗi khi thực hiện cập nhật:', 16, 1);
			END
        END
        ELSE
        BEGIN
            RAISERROR ('Không có thay đổi về cập nhật.', 16, 1);
            RETURN;
        END
    END 
END;



go

-- xóa chi tiết phiếu mượn

CREATE PROCEDURE DeletePhieuMuonCT
    @MaPM varchar(5),
    @MaSach varchar(20)

AS
BEGIN
	
    DECLARE @TrangThai bit;
    -- Lấy trạng thái của phiếu để kiểm tra, nếu đã trả thì số lượng sách k thay đổi, nếu chưa trả thì số lượng sách + 1 khi xóa
    SELECT @TrangThai = TrangThai 
    FROM ChiTietPM 
    WHERE MaPM = @MaPM AND MaSach = @MaSach;
    BEGIN TRANSACTION;
     -- trạng thái chưa trả khi xóa số lượng sách + 1   
    IF @TrangThai = 0
		BEGIN           
           UPDATE Sach
           SET SoLuong = SoLuong + 1
           WHERE MaSach = @MaSach;           
        END
    Delete ChiTietPM where MaPM = @MaPM  and MaSach = @MaSach
	COMMIT TRANSACTION;
    RAISERROR ('Xóa thành công', 16, 1);
	IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;
            RAISERROR ('Xóa thất bại', 16, 1);
        END 
END;

go 
-- thêm thành viên

-- thẻ thành viên

CREATE PROCEDURE InsertTV
    @MaTV varchar(5),
    @TenTV nvarchar(50),
    @DiaChi nvarchar(200),
    @Email varchar(50),
    @GioiTinh bit,
    @SDT int
AS
BEGIN
     -- Kiểm tra xem MaTV có tồn tại trong bảng TheThanhVien không
    IF EXISTS (SELECT 1 FROM TheThanhVien WHERE MaTV = @MaTV)
    BEGIN
        RAISERROR('Mã thành viên đã tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra xem SDT có tồn tại trong bảng TheThanhVien không
    IF EXISTS (SELECT 1 FROM TheThanhVien WHERE SDT = @SDT)
    BEGIN
        RAISERROR('Số điện thoại đã tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra định dạng của Email
    IF @Email IS NOT NULL AND @Email NOT LIKE '%_@__%.__%'
    BEGIN
        RAISERROR('Định dạng email không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra định dạng của Số điện thoại
    IF @SDT IS NOT NULL AND @SDT NOT LIKE '%[0-9]%' OR LEN(@SDT) < 9 OR LEN(@SDT) > 15
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Thêm dữ liệu vào bảng TheThanhVien
    INSERT INTO TheThanhVien (MaTV, TenTV, DiaChi, Email, GioiTinh, SDT)
    VALUES (@MaTV, @TenTV, @DiaChi, @Email, @GioiTinh, @SDT);

    PRINT 'Thêm thành viên thành công.';
END;

go

-- update thẻ thành viên

CREATE PROCEDURE UpdateTV
    @MaTV varchar(5),
    @TenTV nvarchar(50),
    @DiaChi nvarchar(200),
    @Email nvarchar(50),
    @GioiTinh bit,
    @SDT int
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem Mã thành viên có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM TheThanhVien WHERE MaTV = @MaTV)
    BEGIN
        RAISERROR('Mã thành viên không tồn tại.', 16, 1);
        RETURN;
    END;

 	-- Kiểm tra định dạng của email
    IF @Email IS NOT NULL AND @Email NOT LIKE '%_@__%.__%'
    BEGIN
        RAISERROR('Định dạng email không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra định dạng của sdt
    IF @SDT IS NOT NULL AND @SDT NOT LIKE '%[0-9]%' OR LEN(@SDT) < 9 OR LEN(@SDT) > 15
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ.', 16, 1);
        RETURN;
    END;

	-- kiểm tra trùng email
	IF EXISTS (SELECT 1 FROM TheThanhVien WHERE Email = @Email AND MaTV != @MaTV)
    BEGIN
        RAISERROR('Email đã tồn tại cho thành viên khác.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra sự trùng sdt
    IF EXISTS (SELECT 1 FROM TheThanhVien WHERE SDT = @SDT AND MaTV != @MaTV)
    BEGIN
        RAISERROR('Số điện thoại đã tồn tại cho thành viên khác.', 16, 1);
        RETURN;
    END;


    -- Cập nhật thông tin thành viên
    UPDATE TheThanhVien
    SET TenTV = @TenTV,
        DiaChi = @DiaChi,
        Email = @Email,
        GioiTinh = @GioiTinh,
        SDT = @SDT
    WHERE MaTV = @MaTV;
	RAISERROR('Cập nhật thành công.', 16, 1);
END;

-- xóa thành viên
go

CREATE PROCEDURE DeleteTV
    @MaTV varchar(5)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem Mã thành viên có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM TheThanhVien WHERE MaTV = @MaTV)
    BEGIN
        RAISERROR('Mã thành viên không tồn tại.', 16, 1);
        RETURN;
    END;
	-- kiểm tra thành viên có tồn tại ở bảng phiếu mượn không
	IF EXISTS (SELECT 1 FROM PhieuMuon WHERE MaTV = @MaTV)
    BEGIN
        RAISERROR('Không thể xóa thành viên đã mượn sách.', 16, 1);
        RETURN;
    END;

    -- Xóa thành viên
    DELETE FROM TheThanhVien WHERE MaTV = @MaTV;

    RAISERROR('Đã xóa thành viên thành công.', 16, 1);
END;

go

CREATE PROCEDURE UpdatePhieuMuon
    @MaPM varchar(5),
    @MaTV varchar(5),
    @NgayMuon date,
    @NgayTra date
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem Mã phiếu mượn có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM PhieuMuon WHERE MaPM = @MaPM)
    BEGIN
        RAISERROR('Mã phiếu mượn không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra xem Mã thành viên có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM TheThanhVien WHERE MaTV = @MaTV)
    BEGIN
        RAISERROR('Mã thành viên không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra ngày trả phải lớn hơn ngày mượn ít nhất 1 tuần và không quá 1 tháng
    IF DATEDIFF(day, @NgayMuon, @NgayTra) < 7 OR DATEDIFF(day, @NgayMuon, @NgayTra) > 30
    BEGIN
        RAISERROR('Ngày trả phải lớn hơn ngày mượn ít nhất 1 tuần và không quá 1 tháng.', 16, 1);
        RETURN;
    END;

    -- Cập nhật thông tin phiếu mượn
    UPDATE PhieuMuon
    SET MaTV = @MaTV,
        NgayMuon = @NgayMuon,
        NgayTra = @NgayTra
    WHERE MaPM = @MaPM;
	RAISERROR('Thông tin phiếu mượn đã được cập nhật.', 16, 1);
END;

go

-- xóa phiếu

CREATE PROCEDURE DeletePhieuMuon
    @MaPM varchar(5)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem Mã phiếu mượn có tồn tại trong bảng PhieuMuon không
    IF NOT EXISTS (SELECT 1 FROM PhieuMuon WHERE MaPM = @MaPM)
    BEGIN
        RAISERROR('Mã phiếu mượn không tồn tại.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra xem Mã phiếu mượn có tồn tại trong bảng PhieuMuonChiTiet không
    IF EXISTS (SELECT 1 FROM ChiTietPM WHERE MaPM = @MaPM)
    BEGIN
        RAISERROR('Không thể xóa phiếu mượn khi đã xuất phiếu chi tiết.', 16, 1);
        RETURN;
    END;

    -- Xóa phiếu mượn
    DELETE FROM PhieuMuon WHERE MaPM = @MaPM;

    RAISERROR('Đã xóa phiếu mượn thành công.', 16, 1);
END;


go
-- stored cập nhật quản trị viên

CREATE PROCEDURE UpdateQTV
    @MaUS CHAR(5),
    @TenUS NVARCHAR(50),
    @MatKhau VARCHAR(50),
    @Email NVARCHAR(50),
    @SDT VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;

	-- Kiểm tra định dạng của email
    IF @Email IS NOT NULL AND @Email NOT LIKE '%_@__%.__%'
    BEGIN
        RAISERROR('Định dạng email không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra định dạng của sdt
    IF @SDT IS NOT NULL AND @SDT NOT LIKE '%[0-9]%' OR LEN(@SDT) < 9 OR LEN(@SDT) > 15
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ.', 16, 1);
        RETURN;
    END;

    -- Kiểm tra sự trùng lặp của số điện thoại 
    IF EXISTS (SELECT 1 FROM QuanTriVien WHERE SDT = @SDT AND MaUS != @MaUS)
    BEGIN
        RAISERROR ('Số điện thoại đã tồn tại.', 16, 1); -- Nếu trùng lặp, hiển thị lỗi
        RETURN;
    END;

	  IF EXISTS (SELECT 1 FROM QuanTriVien WHERE Email = @Email AND MaUS != @MaUS)
    BEGIN
        RAISERROR ('Email đã tồn tại.', 16, 1); -- Nếu trùng lặp, hiển thị lỗi
        RETURN;
    END;

    -- Nếu không có trùng lặp, cập nhật thông tin quản trị viên
    UPDATE QuanTriVien
    SET TenUS = @TenUS,
        MatKhau = @MatKhau,
        Email = @Email,
        SDT = @SDT
    WHERE MaUS = @MaUS;

	 RAISERROR ('Cập nhật thành công.', 16, 1);

END;
