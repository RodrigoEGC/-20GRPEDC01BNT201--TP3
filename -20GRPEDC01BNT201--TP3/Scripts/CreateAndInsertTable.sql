CREATE TABLE tbl_login (
	Admin_id nVARCHAR(100),
	Ad_Password nVARCHAR(50)
);

INSERT INTO tbl_login VALUES('admin', 'admin123');

SELECT * FROM tbl_login;