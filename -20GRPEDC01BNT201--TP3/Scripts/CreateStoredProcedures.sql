CREATE PROC Sp_Login
@Admin_id nVARCHAR(100),
@Password nVARCHAR(100),
@Isvalid BIT OUT
AS
BEGIN
SET @Isvalid = (SELECT COUNT(1) FROM tbl_login WHERE Admin_Id = @Admin_id and Ad_Password = @Password)
end
