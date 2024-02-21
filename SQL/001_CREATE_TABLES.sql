/*
	CREATE SCHEMA CLIENT_MANAGER
*/
DROP TABLE IF EXISTS CLIENT_MANAGER.USERS
CREATE TABLE CLIENT_MANAGER.USERS
(
	ID INT IDENTITY(1,1),
	USER_LOGIN NVARCHAR(50),
	ENCRYPTED_PASSWORD NVARCHAR(50),
	IS_LOGED_IN BIT,
	PERMISSIONS_LEVEL TINYINT DEFAULT 0
)
GO
CREATE UNIQUE CLUSTERED INDEX USERS_UCI ON CLIENT_MANAGER.USERS
(
	USER_LOGIN ASC
)
GO

DROP TABLE IF EXISTS CLIENT_MANAGER.MANAGERS
CREATE TABLE CLIENT_MANAGER.MANAGERS
(
	ID INT IDENTITY(1,1),
	SURNAME NVARCHAR(50),
	FULL_NAME NVARCHAR(250),
	MANAGER_USER_ID INT
)
GO
CREATE UNIQUE CLUSTERED INDEX MANAGERS_UCI ON CLIENT_MANAGER.MANAGERS
(
	ID ASC
)
GO
CREATE NONCLUSTERED INDEX MANAGERS__NCI ON CLIENT_MANAGER.MANAGERS
(
	SURNAME ASC
)
GO

DROP TABLE IF EXISTS CLIENT_MANAGER.CLIENTS
CREATE TABLE CLIENT_MANAGER.CLIENTS
(
	ID INT IDENTITY(1,1),
	CLIENT_SURNAME NVARCHAR(50),
	CLIENT_NAME NVARCHAR(250),
	GENDER BIT,
	MANAGER_ID INT
)
GO

CREATE UNIQUE CLUSTERED INDEX CLIENTS_UCI ON CLIENT_MANAGER.CLIENTS
(
	ID ASC
)
GO
CREATE NONCLUSTERED INDEX CLIENTS_NCI ON CLIENT_MANAGER.CLIENTS
(
	CLIENT_SURNAME ASC
)
GO

DROP TABLE IF EXISTS CLIENT_MANAGER.CLIENT_ACCOUNTS
CREATE TABLE CLIENT_MANAGER.CLIENT_ACCOUNTS
(
	ID INT IDENTITY(1,1),
	CLIENT_ID NVARCHAR(50),
	CODE NVARCHAR(10),
	BALANCE DECIMAL(20, 4)
)
GO

CREATE CLUSTERED INDEX CLIENT_ACCOUNTS_CI ON CLIENT_MANAGER.CLIENT_ACCOUNTS
(
	CLIENT_ID ASC
)
GO

CREATE UNIQUE NONCLUSTERED INDEX CLIENT_ACCOUNTS_CODE_UNCI ON CLIENT_MANAGER.CLIENT_ACCOUNTS
(
	CODE ASC
)
GO

DROP TABLE IF EXISTS CLIENT_MANAGER.TRANSACTIONS
CREATE TABLE CLIENT_MANAGER.TRANSACTIONS
(
	ID INT IDENTITY(1,1),
	CLIENT_FROM INT,
	CLIENT_TO INT,
	ACCOUNT_FROM NVARCHAR(10),
	ACCOUNT_TO NVARCHAR(10),
	AMOUNT DECIMAL(20, 4),
	CREATION_DATE_TIME DATETIME,
	TRANSFER_DATE_TIME DATETIME
)

CREATE CLUSTERED INDEX TRANSACTIONS_CI ON CLIENT_MANAGER.TRANSACTIONS
(
	CLIENT_FROM ASC
)
GO

CREATE NONCLUSTERED INDEX TRANSACTIONS_NCI ON CLIENT_MANAGER.TRANSACTIONS
(
	CLIENT_TO ASC
)
GO