using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _SEC_USERS
{
    class ScriptGetRoles
    {
//		USE[clinic10]
//GO
///****** Object:  UserDefinedFunction [dbo].[GetRoles]    Script Date: 16.01.2023 17:51:32 ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO

//-- =============================================
//-- Author:		<Domashnev>
//-- Create date: <14.03.2022>
//-- Description:	<Получение списка ролей>
//-- @SEC_USER_ID INT		--ID пользователя
//-- =============================================
//ALTER FUNCTION[dbo].[GetRoles]
//		(
//   @SEC_USER_ID int
//)
//RETURNS VARCHAR(MAX)
//AS
//BEGIN
//	DECLARE @SEC_ROLE_ID INT;
//	DECLARE @SEC_ROLE_NAME VARCHAR(MAX);
//		DECLARE @SEC_ROLE_NAMES VARCHAR(MAX);
//		SET @SEC_ROLE_NAMES = '';
//		BEGIN
//        --Получаем информацию о продукции
//		DECLARE roles_cursor CURSOR LOCAL FAST_FORWARD READ_ONLY
//			FOR
//				SELECT DISTINCT R.SEC_ROLE_ID, R.SEC_ROLE_NAME
//					FROM SEC_USER_ROLE UR INNER JOIN
//						SEC_ROLE R ON UR.SEC_ROLE_ID = R.SEC_ROLE_ID
//					WHERE UR.SEC_USER_ID = @SEC_USER_ID
//					ORDER BY R.SEC_ROLE_NAME;
//		OPEN roles_cursor;

//		FETCH NEXT FROM roles_cursor INTO @SEC_ROLE_ID, @SEC_ROLE_NAME;
//		WHILE(@@FETCH_STATUS<> -1)
//		BEGIN
//			IF(@@FETCH_STATUS<> -2)
//			BEGIN
//				IF LEN(@SEC_ROLE_NAMES) > 0
//					SET @SEC_ROLE_NAMES = @SEC_ROLE_NAMES + ',';
//		SET @SEC_ROLE_NAMES = @SEC_ROLE_NAMES + @SEC_ROLE_NAME;
//		END;	
//			FETCH NEXT FROM roles_cursor INTO @SEC_ROLE_ID, @SEC_ROLE_NAME;
//		END;
//		CLOSE roles_cursor;
//		DEALLOCATE roles_cursor;
//		END;
//	RETURN @SEC_ROLE_NAMES;
//		END;
    }
}
