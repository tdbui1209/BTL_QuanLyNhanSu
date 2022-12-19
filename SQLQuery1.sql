create database BTL_QuanLyNhanSu

CREATE TABLE PhongBan
(
	MaPhongBan VARCHAR(3) PRIMARY KEY,
	TenPhongBan NVARCHAR(30) NOT NULL UNIQUE
)
CREATE TABLE ChucVu
(
	MaChucVu VARCHAR(3) PRIMARY KEY,
	TenChucVu NVARCHAR(30) NOT NULL UNIQUE
)
CREATE TABLE TinhThanh
(
	MaTinhThanh VARCHAR(3) PRIMARY KEY,
	TenTinhThanh NVARCHAR(30) NOT NULL UNIQUE
)
CREATE TABLE DanToc
(
	MaDanToc VARCHAR(3) PRIMARY KEY,
	TenDanToc NVARCHAR(30) NOT NULL UNIQUE
)
CREATE TABLE TonGiao
(
	MaTonGiao VARCHAR(3) PRIMARY KEY,
	TenTonGiao NVARCHAR(30) NOT NULL UNIQUE
)
CREATE TABLE ChuyenMon
(
	MaChuyenMon VARCHAR(3) PRIMARY KEY,
	TenChuyenMon NVARCHAR(30) NOT NULL UNIQUE
)
CREATE TABLE NgoaiNgu
(
	MaNgoaiNgu VARCHAR(3) PRIMARY KEY,
	TenNgoaiNgu NVARCHAR(30) NOT NULL UNIQUE
)
CREATE TABLE NhanVien
(
	MaNhanVien INT IDENTITY PRIMARY KEY,
	Ho NVARCHAR(15) NOT NULL,
	Ten NVARCHAR(15) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh BIT,
	MaQueQuan VARCHAR(3) NOT NULL REFERENCES TinhThanh(MaTinhThanh),
	MaDanToc VARCHAR(3) NOT NULL REFERENCES DanToc(MaDanToc),
	MaTonGiao VARCHAR(3) NOT NULL REFERENCES TonGiao(MaTonGiao),
	DiaChi NVARCHAR(100) NOT NULL,
	MaTinhThanh VARCHAR(3) NOT NULL REFERENCES TinhThanh(MaTinhThanh),
	DienThoai VARCHAR(10) NOT NULL UNIQUE,
	Email VARCHAR(50) NOT NULL UNIQUE,
	MaPhongBan VARCHAR(3) NOT NULL REFERENCES PhongBan(MaPhongBan),
	MaChucVu VARCHAR(3) NOT NULL REFERENCES ChucVu(MaChucVu),
)

create table NguoiDung
(
	TenDangNhap varchar(30) primary key,
	MatKhau varchar(10) not null,
	TrangThai bit not null
)

create table ChucNang
(
	MaChucNang int primary key,
	TenChucNang varchar(50) not null unique,
	TrangThai bit not null
)

create table PhanQuyen
(
	TenDangNhap varchar(30) not null references NguoiDung(TenDangNhap),
	MaChucNang int not null references ChucNang(MaChucNang),
	primary key(TenDangNhap, MaChucNang)
)

CREATE PROCEDURE spDangNhap @tenDangNhap VARCHAR(30),@matKhau VARCHAR(10)
AS BEGIN
	DECLARE @dem INT;
	SET @dem = (SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap=@tenDangNhap);
	IF @dem > 0 BEGIN
		DECLARE @matKhauDung VARCHAR(10);
		SET @matKhauDung = (SELECT MatKhau FROM NguoiDung 
		WHERE TenDangNhap=@tenDangNhap);
		IF @matKhauDung <> @matKhau
			THROW 50000,N'Sai mật khẩu',1;
		ELSE BEGIN 
			DECLARE @trangThai BIT;
			SET @trangThai = (SELECT TrangThai FROM NguoiDung 
			WHERE TenDangNhap=@tenDangNhap);
			IF @trangThai = 0
				THROW 50001,N'Người dùng đã bị khóa',1;
		END
	END
	ELSE
		THROW 50002,N'Tên đăng nhập không tồn tại',1;
END
GO

CREATE FUNCTION ufLayPhanQuyen(@tenDangNhap VARCHAR(30))
RETURNS TABLE
AS 
	RETURN (SELECT TenChucNang FROM ChucNang 
	INNER JOIN PhanQuyen ON PhanQuyen.MaChucNang=ChucNang.MaChucNang
	WHERE TenDangNhap=@tenDangNhap)
GO

create procedure spThemNguoiDung @TenDangNhap varchar(30), @MatKhau varchar(10), @TrangThai bit
as begin
	declare @dem int
	set @dem = (select count(*) from NguoiDung where TenDangNhap=@TenDangNhap)
	if @dem > 0
		throw 50000, N'Tài khoản đã tồn tại',1;
	else
		insert into NguoiDung values (@TenDangNhap, @MatKhau, @TrangThai, default, default)
end
GO

create procedure spPhanQuyen @TenDangNhap varchar(30), @MaChucNang int
as begin
	insert into PhanQuyen values (@TenDangNhap, @MaChucNang)
end
GO

create function ufLayTaiKhoan(@tenDangNhap nvarchar(30), @active bit)
returns table
as
	return (select TenDangNhap, IIF(TrangThai='true', N'Hoạt động', N'Bị khóa') AS TrangThai from NguoiDung
	where TenDangNhap=@tenDangNhap and TrangThai=@active)

create procedure spKhoaTaiKhoan @tenDangNhap varchar(30), @trangThai bit
as begin
	declare @dem int
	set @dem = (select count(*) from NguoiDung where TenDangNhap=@tenDangNhap)
	if @dem > 0
		update NguoiDung set TrangThai='false' where TenDangNhap=@tenDangNhap
	else 
		throw 50000, N'Tài khoản không tồn tại', 1;
	end

create procedure spMoTaiKhoan @tenDangNhap varchar(30), @trangThai bit
as begin
	declare @dem int
	set @dem = (select count(*) from NguoiDung where TenDangNhap=@tenDangNhap)
	if @dem > 0
		update NguoiDung set TrangThai='true' where TenDangNhap=@tenDangNhap
	else 
		throw 50000, N'Tài khoản không tồn tại', 1;
	end

create procedure spDoiMatKhau @tenDangNhap varchar(30), @matKhau varchar(10), @matKhauMoi varchar(10)
as begin
	declare @dem int
	set @dem = (select count(*) from NguoiDung where TenDangNhap=@tenDangNhap)
	if @dem > 0 begin
		set @dem = (select count(*) from NguoiDung where TenDangNhap=@tenDangNhap and MatKhau=@matKhau)
		if @dem > 0
			update NguoiDung set MatKhau=@matKhauMoi where TenDangNhap=@tenDangNhap and MatKhau=@matKhau
		else
			throw 50000, N'Sai mật khẩu', 1
	end
	else
		throw 50001, N'Tài khoản không tồn tại', 1
end

create table NhatKy
(
	MaNhatKy int identity primary key,
	TenDangNhap varchar(30) not null references NguoiDung(TenDangNhap),
	ThoiDiem datetime not null,
	NoiDung nvarchar(200) not null
)

ALTER TABLE NguoiDung
ADD NguoiSua VARCHAR(30) NOT NULL REFERENCES NguoiDung(TenDangNhap) DEFAULT('admin')
ALTER TABLE NguoiDung
ADD ThoiDiemSua DATETIME NOT NULL DEFAULT(GETDATE())

create function ufLayNhatKy()
returns table
as return (select * from NhatKy)

CREATE TRIGGER tgThemNguoiDung
ON NguoiDung
FOR INSERT
AS BEGIN
	DECLARE @tenDangNhap VARCHAR(30);
	DECLARE @tenDangNhapMoi VARCHAR(30);
	SET @tenDangNhap = (SELECT NguoiSua FROM INSERTED);
	SET @tenDangNhapMoi = (SELECT TenDangNhap FROM INSERTED);
	INSERT NhatKy(TenDangNhap, ThoiDiem, NoiDung)
	VALUES (@tenDangNhap, GETDATE(), N'Thêm tài khoản mới: ' + @tenDangNhapMoi)
END

alter trigger tgKhoaNguoiDung
on NguoiDung
for update
as begin
	declare @tenDangNhap varchar(30)
	declare @tenDangNhapKhoa varchar(30)
	set @tenDangNhap = (select NguoiSua from inserted)
	set @tenDangNhapKhoa = (select TenDangNhap from inserted)
	
	If (SELECT TrangThai FROM INSERTED) LIKE 0
		insert NhatKy(TenDangNhap, ThoiDiem, NoiDung)
		values (@tenDangNhap, GETDATE(), N'Khóa tài khoản: ' + @tenDangNhapKhoa)
	else
		insert NhatKy(TenDangNhap, ThoiDiem, NoiDung)
		values (@tenDangNhap, GETDATE(), N'Mở tài khoản: ' + @tenDangNhapKhoa)
end

create procedure spThemPhongBan @maPhongBan varchar(3), @tenPhongBan nvarchar(30), @tenDangNhap varchar(30)
as begin
	declare @dem int
	set @dem = (select count(*) from PhongBan where @maPhongBan=MaPhongBan)
	if @dem > 0
		throw 50000, N'Trùng mã phòng ban', 1
	else begin
		set @dem = (select count(*) from PhongBan where @tenPhongBan=TenPhongBan)
		if @dem > 0
			throw 50001, N'Trùng tên phòng ban', 1
		else
			insert into PhongBan values (@maPhongBan, @tenPhongBan, @tenDangNhap, default)
	end
end

create procedure spXoaPhongBan @maPhongBan varchar(3)
as begin
	declare @dem int
	set @dem = (select count(*) from PhongBan where MaPhongBan=@maPhongBan)
	if @dem > 0
		delete from PhongBan where MaPhongBan=@maPhongBan
end

create procedure spThemChucVu @maChucVu varchar(3), @tenChucVu nvarchar(30), @tenDangNhap varchar(30)
as begin
	declare @dem int
	set @dem = (select count(*) from ChucVu where MaChucVu=@maChucVu)
	if @dem > 0
		throw 50000, N'Trùng mã chức vụ', 1
	else
		set @dem = (select count(*) from ChucVu where TenChucVu=@tenChucVu)
		if @dem > 0
			throw 50001, N'Trùng tên chức vụ', 1
		else
			insert into ChucVu values (@maChucVu, @tenChucVu, @tenDangNhap, default)
end

create procedure spXoaChucVu @maChucVu varchar(3)
as begin
	declare @dem int
	set @dem = (select count(*) from ChucVu where MaChucVu=@maChucVu)
	if @dem > 0
		delete ChucVu where MaChucVu=@maChucVu
	else
		throw 50000, N'Không tồn tại mã chức vụ này', 1
end

alter table NhanVien
add NguoiSua varchar(30) not null references NguoiDung(TenDangNhap) default 'admin'
ALTER TABLE NhanVien
ADD ThoiDiemSua DATETIME NOT NULL DEFAULT(GETDATE())

create trigger tgThemNhanVien
on NhanVien
for insert
as begin
	declare @tenDangNhap varchar(30)
	declare @Ho nvarchar(15)
	declare @Ten NVARCHAR(15)
	set @tenDangNhap = (select NguoiSua from inserted)
	set @Ho = (select Ho from inserted)
	set @Ten = (select Ten from inserted)
	insert NhatKy(TenDangNhap, ThoiDiem, NoiDung)
	values (@tenDangNhap, getdate(), N'Thêm nhân viên mới: ' + @Ho + ' ' + @Ten)
end

create trigger tgXoaNhanVien
on NhanVien
for delete
as begin
	declare @tenDangNhap varchar(30)
	declare @Ho nvarchar(15)
	declare @Ten NVARCHAR(15)
	set @tenDangNhap = (select NguoiSua from inserted)
	set @Ho = (select Ho from inserted)
	set @Ten = (select Ten from inserted)
	insert NhatKy(TenDangNhap, ThoiDiem, NoiDung)
	values (@tenDangNhap, getdate(), N'Xóa nhân viên: ' + @Ho + ' ' + @Ten)
end

create trigger tgSuaNhanVien
on NhanVien
for update
as begin
	declare @tenDangNhap varchar(30)
	declare @Ho nvarchar(15)
	declare @Ten NVARCHAR(15)
	set @tenDangNhap = (select NguoiSua from inserted)
	set @Ho = (select Ho from inserted)
	set @Ten = (select Ten from inserted)
	insert NhatKy(TenDangNhap, ThoiDiem, NoiDung)
	values (@tenDangNhap, getdate(), N'Sửa nhân viên: ' + @Ho + ' ' + @Ten)
end

alter table PhongBan
add NguoiSua varchar(30) not null references NguoiDung(TenDangNhap) default 'admin'
alter table PhongBan
add ThoiDiemSua datetime not null default(getdate())

create trigger tgThemPhongBan
on PhongBan
for insert
as begin
	declare @tenDangNhap varchar(30)
	declare @phongBanMoi nvarchar(30)
	set @tenDangNhap = (select NguoiSua from inserted)
	set @phongBanMoi = (select TenPhongBan from inserted)
	insert NhatKy(TenDangNhap, ThoiDiem, NoiDung)
	values (@tenDangNhap, getdate(), N'Thêm phòng ban mới: ' + @phongBanMoi)
end

alter table ChucVu
add NguoiSua varchar(30) not null references NguoiDung(TenDangNhap) default 'admin'
alter table ChucVu
add ThoiDiemSua datetime not null default(getdate())

create trigger tgThemChucVu
on ChucVu
for insert
as begin
	declare @tenDangNhap varchar(30)
	declare @chucVuMoi nvarchar(30)
	set @tenDangNhap = (select NguoiSua from inserted)
	set @chucVuMoi = (select TenChucVu from inserted)
	insert NhatKy(TenDangNhap, ThoiDiem, NoiDung)
	values (@tenDangNhap, getdate(), N'Thêm chức vụ mới: ' + @chucVuMoi)
end

create procedure spXoaQuyen @tenDangNhap varchar(30), @chucNang varchar(30)
as begin
	declare @maChucNang int
	set @maChucNang = 
		(select PhanQuyen.MaChucNang from ChucNang inner join PhanQuyen on ChucNang.MaChucNang=PhanQuyen.MaChucNang
		where TenDangNhap=@tenDangNhap and TenChucNang=@chucNang)
	delete PhanQuyen where TenDangNhap=@tenDangNhap and MaChucNang=@maChucNang
end

create procedure spThemQuyen @tenDangNhap varchar(30), @chucNang varchar(30), @nguoiSua varchar(30)
as begin
	declare @maChucNang int
	set @maChucNang = 
		(select MaChucNang from ChucNang where TenChucNang=@chucNang)
	insert into PhanQuyen values(@tenDangNhap, @maChucNang, getdate(), @nguoiSua)
end

alter table PhanQuyen
add NguoiSua varchar(30) not null references NguoiDung(TenDangNhap) default 'admin'
alter table PhanQuyen
add ThoiDiemSua datetime not null default(getdate())

alter trigger tgThemQuyen
on PhanQuyen
for insert
as begin
	declare @tenDangNhap varchar(30)
	declare @tenNguoiDung varchar(30)
	declare @tenChucNang varchar(50)
	set @tenDangNhap = (select NguoiSua from inserted)
	set @tenNguoiDung = (select TenDangNhap from inserted)
	set @tenChucNang = (select TenChucNang from inserted inner join ChucNang on inserted.MaChucNang = ChucNang.MaChucNang)
	insert NhatKy(TenDangNhap, ThoiDiem, NoiDung)
	values (@tenDangNhap, getdate(), N'Thêm chức năng ' + @tenChucNang + N' cho tài khoản ' + @tenNguoiDung)
end

alter trigger tgXoaQuyen
on PhanQuyen
for delete
as begin
	declare @tenDangNhap varchar(30)
	declare @tenNguoiDung varchar(30)
	declare @tenChucNang varchar(50)
	set @tenDangNhap = (select NguoiSua from deleted)
	set @tenNguoiDung = (select TenDangNhap from deleted)
	set @tenChucNang = (select TenChucNang from deleted inner join ChucNang on deleted.MaChucNang = ChucNang.MaChucNang)
	insert NhatKy(TenDangNhap, ThoiDiem, NoiDung)
	values (@tenDangNhap, getdate(), N'Xóa chức năng ' + @tenChucNang + N' của tài khoản ' + @tenNguoiDung)
end

create procedure spLuuNhatKyDangNhap @tenDangNhap varchar(30)
as begin
	insert into NhatKy values (@tenDangNhap, getdate(), N'Đăng nhập')
end

create procedure spLuuNhatKyDangXuat @tenDangNhap varchar(30)
as begin
	insert into NhatKy values (@tenDangNhap, getdate(), N'Đăng xuất')
end