SELECT *, len(encrypted_password) FROM CLIENT_MANAGER.USERS


/*
SELECT  usecounts, cacheobjtype, objtype, text   
FROM sys.dm_exec_cached_plans   
CROSS APPLY sys.dm_exec_sql_text(plan_handle)
where text like '%CLIENT_MANAGER.USERS%'
*/