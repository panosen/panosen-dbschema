@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.DBSchema.Mysql\bin\Release\Panosen.DBSchema.Mysql.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.DBSchema.Sqlite\bin\Release\Panosen.DBSchema.Sqlite.*.nupkg D:\LocalSavoryNuget\

pause