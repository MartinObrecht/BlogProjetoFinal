SET ANSI_NULLS ON
 
SET QUOTED_IDENTIFIER ON

UPDATE [dbo].[Settings]
   SET [SettingValue] = '02.01.00'
 WHERE [SettingName] = 'Versão inicial'