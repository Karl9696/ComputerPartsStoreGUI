@echo off
REM -- MySQL Configuration Script After Unattended Install --
REM Assumes MySQL is installed in the default location and mysql.exe is accessible

set MYSQL_PATH="C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe"

echo Setting root password and user privileges...
%MYSQL_PATH% -u root --connect-expired-password < "%~dp0init_db.sql"

echo Restoring computerparts_db.sql into demodb...
%MYSQL_PATH% -u root -pmike demodb < "%~dp0computerparts_db.sql"

echo MySQL setup and database restoration complete.
pause
