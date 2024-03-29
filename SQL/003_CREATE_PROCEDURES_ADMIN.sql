CREATE OR ALTER PROCEDURE CLIENT_MANAGER.USER_AUTHORIZATION
(
	@USERNAME NVARCHAR(50),
	@CRYPTPASSWORD NVARCHAR(50),
	@USER_ID INT OUTPUT,
	@PERMISSIONS_LEVEL INT OUTPUT
)
AS BEGIN

	SELECT
		@USER_ID = ID,
		@PERMISSIONS_LEVEL = PERMISSIONS_LEVEL
	FROM CLIENT_MANAGER.USERS
	WHERE USER_LOGIN = @USERNAME AND ENCRYPTED_PASSWORD = @CRYPTPASSWORD

END;
GO

CREATE OR ALTER PROCEDURE CLIENT_MANAGER.GET_ALL_USERS
AS BEGIN
	SELECT
		ID,
		USER_LOGIN,
		PERMISSIONS_LEVEL
	FROM CLIENT_MANAGER.USERS
END;
GO

CREATE OR ALTER PROCEDURE CLIENT_MANAGER.GET_ALL_USERS_FOR_MANAGER
	@USER_LOGIN NVARCHAR(50)
AS BEGIN

	SELECT
		ID,
		USER_LOGIN,
		ISNULL(M.MANAGER_USER_ID, 0) AS MANAGER_USER_ID
	FROM CLIENT_MANAGER.USERS AS U
	LEFT JOIN (
		SELECT _M.MANAGER_USER_ID
		FROM CLIENT_MANAGER.MANAGERS AS _M
			JOIN CLIENT_MANAGER.USERS AS _U
			ON _M.SUPER_MANAGER_ID = _U.ID
		WHERE _U.USER_LOGIN = @USER_LOGIN) AS M
	ON U.ID = M.MANAGER_USER_ID
	WHERE U.USER_LOGIN <> @USER_LOGIN
END;
GO

CREATE OR ALTER PROCEDURE CLIENT_MANAGER.UPDATE_USER_PERMISSIONS_LEVEL
	@USER_LOGIN NVARCHAR(50),
	@PERMISSIONS_LEVEL TINYINT
AS BEGIN
	UPDATE CLIENT_MANAGER.USERS
		SET PERMISSIONS_LEVEL = @PERMISSIONS_LEVEL
	WHERE USER_LOGIN = @USER_LOGIN
END;
GO

CREATE OR ALTER PROCEDURE CLIENT_MANAGER.IS_USER_EXISTS
	@USER_LOGIN NVARCHAR(50)
AS BEGIN
	IF EXISTS ( SELECT 1 FROM CLIENT_MANAGER.USERS WHERE USER_LOGIN = @USER_LOGIN )
		SELECT CAST(1 AS BIT)
	ELSE
		SELECT CAST(0 AS BIT)
END;
GO

CREATE OR ALTER PROCEDURE CLIENT_MANAGER.USER_REGISTRATION
(
	@USER_LOGIN VARCHAR(50),
	@CRYPTPASSWORD NVARCHAR(50)
)
AS BEGIN

	INSERT INTO CLIENT_MANAGER.USERS(USER_LOGIN, ENCRYPTED_PASSWORD)
	VALUES (@USER_LOGIN, @CRYPTPASSWORD)

END;
GO

CREATE OR ALTER PROCEDURE CLIENT_MANAGER.SET_SUPER_MANAGER
	@MANAGER_ID INT,
	@SUPER_MANAGER_ID INT
AS BEGIN

	UPDATE CLIENT_MANAGER.MANAGERS
		SET SUPER_MANAGER_ID = @SUPER_MANAGER_ID
	WHERE MANAGER_USER_ID = @MANAGER_ID

END;
GO

CREATE OR ALTER PROCEDURE CLIENT_MANAGER.ASSIGN_MANAGERS
	@USER_LOGIN VARCHAR(50),
	@MANAGERS_TO_ASSIGN NVARCHAR(MAX),
	@MANAGERS_TO_UNASSIGN NVARCHAR(MAX)
AS BEGIN

	DECLARE @SUPER_MANAGER_ID INT = (SELECT ID FROM CLIENT_MANAGER.USERS WHERE USER_LOGIN = @USER_LOGIN)

	SELECT
				@SUPER_MANAGER_ID AS SUPER_MANAGER_ID,
				VALUE AS MANAGER_USER_ID
			FROM STRING_SPLIT(@MANAGERS_TO_ASSIGN, N',')
	SELECT VALUE FROM STRING_SPLIT(@MANAGERS_TO_UNASSIGN, N',')

	DELETE FROM CLIENT_MANAGER.MANAGERS
	WHERE SUPER_MANAGER_ID = @SUPER_MANAGER_ID
		AND MANAGER_USER_ID IN (
			SELECT VALUE FROM STRING_SPLIT(@MANAGERS_TO_UNASSIGN, ',')
		)

	MERGE CLIENT_MANAGER.MANAGERS AS M
	USING (SELECT
				@SUPER_MANAGER_ID AS SUPER_MANAGER_ID,
				VALUE AS MANAGER_USER_ID
			FROM STRING_SPLIT(@MANAGERS_TO_ASSIGN, N',')) AS U
	ON M.SUPER_MANAGER_ID = U.SUPER_MANAGER_ID AND M.MANAGER_USER_ID = U.MANAGER_USER_ID
	WHEN NOT MATCHED BY TARGET
	THEN INSERT (SUPER_MANAGER_ID, MANAGER_USER_ID) VALUES (U.SUPER_MANAGER_ID, U.MANAGER_USER_ID);

END;
GO