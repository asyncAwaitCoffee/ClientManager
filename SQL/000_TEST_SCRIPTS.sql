SELECT * FROM CLIENT_MANAGER.USERS
SELECT * FROM CLIENT_MANAGER.CLIENTS
SELECT * FROM CLIENT_MANAGER.CLIENT_ACCOUNTS


/*
SELECT  usecounts, cacheobjtype, objtype, text   
FROM sys.dm_exec_cached_plans   
CROSS APPLY sys.dm_exec_sql_text(plan_handle)
where text like '%CLIENT_MANAGER.USERS%'
*/