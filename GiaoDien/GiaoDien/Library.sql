﻿CREATE DATABASE Library

USE Library
GO

CREATE TABLE UserAccount (
	TENDN VARCHAR(20) UNIQUE NOT NULL,
	MATKHAU VARCHAR(64) NOT NULL,
	HOTEN NVARCHAR(50) NOT NULL,
	TUOI INT NOT NULL,
	CMND INT NOT NULL,
	SDT CHAR(10) NOT NULL,
	EMAIL VARCHAR(50) NOT NULL,
	QUYENMUON BIT NOT NULL,
	QUYENQL BIT NOT NULL
)

CREATE TABLE Book (
	MASA CHAR(6) PRIMARY KEY NOT NULL,
	TENSA NVARCHAR(50) NOT NULL,
	LOAISA NVARCHAR(50) NOT NULL,
	NXB NVARCHAR(50) NOT NULL,
	TACGIA NVARCHAR(50) NOT NULL,
	TAIBAN INT NOT NULL,
	SOLUONG INT NOT NULL
)

CREATE TABLE Borrow (
	TENDN VARCHAR(20) FOREIGN KEY REFERENCES UserAccount(TENDN) NOT NULL,
	MASA CHAR(6) FOREIGN KEY REFERENCES Book(MASA) NOT NULL,
	NGAYMUON SMALLDATETIME,
	HANTRA SMALLDATETIME,
	NGAYTRA SMALLDATETIME,
	SOLUONG INT,
	DATRA BIT
)

CREATE TABLE LoginUser (
	TENDN VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES UserAccount(TENDN),
	MATKHAU VARCHAR(64) NOT NULL
)

CREATE TABLE MemberCard (
	MATV CHAR(6) PRIMARY KEY NOT NULL,
	TENDN VARCHAR(20) FOREIGN KEY REFERENCES UserAccount(TENDN) NOT NULL,
	HOTEN NVARCHAR(50) NOT NULL,
	CMND INT NOT NULL,
	HSD SMALLDATETIME
)
SET DATEFORMAT DMY

ALTER TABLE Borrow ADD CONSTRAINT fk_borrow PRIMARY KEY (TENDN, MASA)
ALTER TABLE UserAccount ADD CONSTRAINT fk_account PRIMARY KEY (TENDN)
ALTER TABLE LoginUser ADD CONSTRAINT fk_userlogin PRIMARY KEY(TENDN, MATKHAU) 

CREATE PROC Add_Book (@MASA CHAR(6), @TENSA NVARCHAR(50), @LOAISA NVARCHAR(50), @NXB NVARCHAR(50), @TACGIA NVARCHAR(50), @TAIBAN TINYINT, @SOLUONG INT)
AS INSERT INTO Book Values(@MASA, @TENSA, @LOAISA, @NXB, @TACGIA, @TAIBAN, @SOLUONG)

-- Thêm tài khỏa admin
INSERT INTO UserAccount VALUES ('sanpot' , '2a057642222a878bc360f52f8e1f0dfd2af93196f123269397423155a4ec4884', N'Lê Phúc', 20, 241744976, '0368341595', 'lethephuc2002@gmail.com', 1, 1)


