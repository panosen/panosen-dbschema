@echo off

dotnet restore

dotnet build --no-restore -c Release

dotnet nuget push Panosen.DBSchema.Mysql\bin\Release\Panosen.DBSchema.Mysql.*.nupkg -s https://package.savory.cn/v3/index.json --skip-duplicate
dotnet nuget push Panosen.DBSchema.Sqlite\bin\Release\Panosen.DBSchema.Sqlite.*.nupkg -s https://package.savory.cn/v3/index.json --skip-duplicate

move /Y Panosen.DBSchema.Mysql\bin\Release\Panosen.DBSchema.Mysql.*.nupkg D:\LocalSavoryNuget\
move /Y Panosen.DBSchema.Sqlite\bin\Release\Panosen.DBSchema.Sqlite.*.nupkg D:\LocalSavoryNuget\

pause