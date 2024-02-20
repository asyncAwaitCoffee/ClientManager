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

CREATE OR ALTER PROCEDURE CLIENT_MANAGER.CREATE_CLIENT
(
	@CLIENT_NAME VARCHAR(50),
	@CLIENT_SURNAME VARCHAR(50),
	@GENDER BIT,
	@MANAGER_ID BIT,
	@CLIENT_ID INT OUTPUT
)
AS BEGIN

	INSERT INTO CLIENT_MANAGER.CLIENTS(CLIENT_SURNAME, CLIENT_NAME, GENDER, MANAGER_ID)
	VALUES (@CLIENT_SURNAME, @CLIENT_NAME, @GENDER, @MANAGER_ID)

	SELECT @CLIENT_ID = SCOPE_IDENTITY();

END;
GO

CREATE OR ALTER PROCEDURE CLIENT_MANAGER.GET_USER_CLIENTS
(
	@USER_ID VARCHAR(50),
	@PAGE_NO INT,
	@ITEMS_PER_PAGE INT
)
AS BEGIN
	SELECT @PAGE_NO = @PAGE_NO - 1

	SELECT
		C.ID,
		C.CLIENT_NAME,
		C.CLIENT_SURNAME,
		C.GENDER,
		CASE
			WHEN SUM(A.BALANCE) > 5000
		THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS IS_VIP
	FROM CLIENT_MANAGER.CLIENTS AS C
	LEFT JOIN CLIENT_MANAGER.CLIENT_ACCOUNTS AS A
		ON C.ID = A.CLIENT_ID
	WHERE MANAGER_ID = @USER_ID
	GROUP BY C.ID,
		C.CLIENT_NAME,
		C.CLIENT_SURNAME,
		C.GENDER
	ORDER BY C.ID
	OFFSET @PAGE_NO * @ITEMS_PER_PAGE ROWS
	FETCH NEXT @ITEMS_PER_PAGE ROWS ONLY
END;
GO

CREATE OR ALTER PROCEDURE CLIENT_MANAGER.GET_ALL_USERS
AS BEGIN
	SELECT
		USER_LOGIN,
		PERMISSIONS_LEVEL
	FROM CLIENT_MANAGER.USERS
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

CREATE OR ALTER PROCEDURE CLIENT_MANAGER.GET_CLIENT_ACCOUNTS
	@CLIENT_ID INT
AS BEGIN
	SELECT
		ID,
		CODE,
		BALANCE
	FROM CLIENT_MANAGER.CLIENT_ACCOUNTS
	WHERE CLIENT_ID = @CLIENT_ID
END;
GO

CREATE OR ALTER PROCEDURE CLIENT_MANAGER.UPDATE_CLIENT_INFO
	@CLIENT_ID INT,
	@CLIENT_NAME NVARCHAR(50),
	@CLIENT_SURNAME NVARCHAR(50)
AS BEGIN
	UPDATE CLIENT_MANAGER.CLIENTS
		SET CLIENT_NAME = @CLIENT_NAME,
		CLIENT_SURNAME = @CLIENT_SURNAME
	WHERE ID = @CLIENT_ID
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