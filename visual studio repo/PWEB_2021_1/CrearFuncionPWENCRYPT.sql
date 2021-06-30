USE [C:\USERS\LEDER\SOURCE\REPOS\PWEB_2021_1\DB\LOGINDB.MDF]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [dbo].[PSWD_ENCRYPT] 
(
	-- Add the parameters for the function here
	@contrasenha varchar(50)

)
returns varchar(50)
AS
BEGIN
	-- Declare the return variable here
	declare @contrasenhaEncrypt varchar(50);
		declare @hexbin varbinary(max)
	set @hexbin = HASHBYTES('SHA1',HashBytes('SHA1', @contrasenha));
	set @contrasenhaEncrypt = (select  cast('' as xml).value('xs:hexBinary(sql:variable("@hexbin") )', 'varchar(max)'));
	-- Return the result of the function
	RETURN  @contrasenhaEncrypt

END