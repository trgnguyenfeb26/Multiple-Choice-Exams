USE [TN_CSDLPT]
GO
/****** Object:  StoredProcedure [dbo].[SP_LayThongTinGiaoVien]    Script Date: 09/05/2022 8:46:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LayThongTinGiaoVien]
@TENLOGIN NVARCHAR( 100)
AS
DECLARE @UID INT
DECLARE @MANV NVARCHAR(100)
SELECT @UID= uid , @MANV= NAME FROM sys.sysusers 
  WHERE sid = SUSER_SID(@TENLOGIN)

SELECT MAGV= @MANV, 
       HOTEN = (SELECT HO+ ' '+TEN FROM dbo.GIAOVIEN WHERE MAGV=@MANV ), 
       TENNHOM=NAME
  FROM sys.sysusers
    WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@uid)
