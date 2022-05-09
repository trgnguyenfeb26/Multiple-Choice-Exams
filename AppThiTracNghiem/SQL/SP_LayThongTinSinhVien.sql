USE [TN_CSDLPT]
GO
/****** Object:  StoredProcedure [dbo].[SP_LayThongTinSinhVien]    Script Date: 09/05/2022 8:53:41 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LayThongTinSinhVien] @login_name nvarchar(20), @password nvarchar(50)
as
begin
	if exists(select masv from sinhvien where masv=@login_name AND MATKHAU=@password)
				select masv, hoten=ho+' '+ten, GROUPNAME='SinhVien' from sinhvien where masv=@login_name
			else
				RAISERROR (N'Mã sinh viên hoặc mật khẩu không chính xác', 16, 1)
end
