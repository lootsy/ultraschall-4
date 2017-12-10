USE master;
GO

IF DB_ID('ultraschall') IS NOT NULL
BEGIN
   ALTER DATABASE ultraschall SET OFFLINE WITH ROLLBACK IMMEDIATE;
END
GO

IF DB_ID('ultraschall') IS NOT NULL
BEGIN
   DROP DATABASE ultraschall
END
GO

CREATE DATABASE ultraschall
   ON (
      NAME = ultraschall_data,
      FILENAME = '/opt/var/mssql/ultraschall/data/ultraschall.mdf',
      SIZE = 100MB,
      FILEGROWTH = 100MB)
   LOG ON (
      NAME = ultraschall_log,
      FILENAME = '/opt/var/mssql/ultraschall/data/ultraschall.ldf',
      SIZE = 100MB,
      FILEGROWTH = 100MB);
GO

