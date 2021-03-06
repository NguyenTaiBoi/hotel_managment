/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Nguyễn Công Hoan' ******/

USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLTC')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLTC') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLTC]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLTC]
GO
USE [QLTC]
GO

CREATE TABLE [dbo].[tblKieuNau](
	[maKieuNau] [int] NOT NULL,
	[tenKieuNau] [nvarchar](50) NOT NULL,
	[mota] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblKieuNau] PRIMARY KEY CLUSTERED 
(
	[maKieuNau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [QLTC]
GO
INSERT INTO[dbo].[tblKieuNau]([maKieuNau],[tenKieuNau],[mota]) VALUES(1,N'Kiểu xào',N'Xào ngon lắm' )
GO
INSERT INTO[dbo].[tblKieuNau]([maKieuNau],[tenKieuNau],[mota]) VALUES(2,N'Kiểu chiên',N'chiên ngon lắm' )
GO
INSERT INTO[dbo].[tblKieuNau]([maKieuNau],[tenKieuNau],[mota]) VALUES(3,N'Kieu hấp',N'hấp ngon lắm' )


CREATE TABLE [dbo].[tblMonAn](
	[maMonAn] [int] NOT NULL,
	[tenMonAn] [nvarchar](50) NOT NULL,
	[mota] [nvarchar](50) NOT NULL,
	[maKieuNau] [int] NOT NULL,
 CONSTRAINT [PK_tblMonAn] PRIMARY KEY CLUSTERED 
(
	[maMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT INTO[dbo].[tblMonAn]([maMonAn],[tenMonAn],[mota],[maKieuNau] ) VALUES(1,N'Gà chiên',N'Gà chiên ngon lắm', 2 )
GO
INSERT INTO[dbo].[tblMonAn]([maMonAn],[tenMonAn],[mota],[maKieuNau] ) VALUES(2,N'Gà hấp',N'Gà hấp ngon lắm', 3 )
GO
INSERT INTO[dbo].[tblMonAn]([maMonAn],[tenMonAn],[mota],[maKieuNau] ) VALUES(3,N'Gà xào',N'Gà xào ngon lắm', 1 )