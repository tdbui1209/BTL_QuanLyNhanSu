create database BTL_QuanLyNhanSu

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

CREATE FUNCTION ufLayPhanQuyen(@tenDangNhap VARCHAR(30))
RETURNS TABLE
AS 
	RETURN (SELECT TenChucNang FROM ChucNang 
	INNER JOIN PhanQuyen ON PhanQuyen.MaChucNang=ChucNang.MaChucNang
	WHERE TenDangNhap=@tenDangNhap)

create procedure spThemNguoiDung @TenDangNhap varchar(30), @MatKhau varchar(10), @TrangThai bit
as begin
	declare @dem int
	set @dem = (select count(*) from NguoiDung where TenDangNhap=@TenDangNhap)
	if @dem > 0
		throw 50000, N'Tài khoản đã tồn tại',1;
	else
		insert into NguoiDung values (@TenDangNhap, @MatKhau, @TrangThai)
end

create procedure spPhanQuyen @TenDangNhap varchar(30), @MaChucNang int
as begin
	insert into PhanQuyen values (@TenDangNhap, @MaChucNang)
end