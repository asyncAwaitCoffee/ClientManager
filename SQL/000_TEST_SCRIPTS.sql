SELECT * FROM CLIENT_MANAGER.USERS
SELECT * FROM CLIENT_MANAGER.MANAGERS
SELECT * FROM CLIENT_MANAGER.CLIENTS
SELECT * FROM CLIENT_MANAGER.CLIENT_ACCOUNTS
SELECT * FROM CLIENT_MANAGER.TRANSACTIONS

/*
--TRUNCATE TABLE CLIENT_MANAGER.MANAGERS
INSERT INTO CLIENT_MANAGER.MANAGERS(SUPER_MANAGER_ID, MANAGER_USER_ID)
VALUES
(1, 3)
*/
/*
UPDATE CLIENT_MANAGER.TRANSACTIONS
SET TRANSFER_DATE_TIME = NULL
*/
/*
SELECT  usecounts, cacheobjtype, objtype, text   
FROM sys.dm_exec_cached_plans   
CROSS APPLY sys.dm_exec_sql_text(plan_handle)
where text like '%CLIENT_MANAGER.USERS%'
*/