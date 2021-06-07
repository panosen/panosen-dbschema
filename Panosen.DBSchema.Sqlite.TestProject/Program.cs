using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.DBSchema.Sqlite.TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddSingleton<IConfiguration>(v =>
            {
                var configurationBuilder = new ConfigurationBuilder();
                configurationBuilder.AddUserSecrets("0c84795b-d594-4a77-a08e-09830ed5caae");
                return configurationBuilder.Build();
            });

            services.AddScoped<SQLiteConnection>(servicePrivider =>
            {
                var configuration = servicePrivider.GetRequiredService<IConfiguration>();
                var connectionString = configuration["SampleDatabase"];
                SQLiteConnection sqliteConn = new SQLiteConnection(connectionString);
                sqliteConn.Open();

                return sqliteConn;
            });

            var servicePrivider = services.BuildServiceProvider();


            using (var sqliteConn = servicePrivider.GetRequiredService<SQLiteConnection>())
            {
                {
                    var tableList = SchemaRepository.GetTableEntityList(sqliteConn);
                    foreach (var table in tableList)
                    {
                        Console.WriteLine(table.Name);
                    }
                }

                {
                    var fieldList = SchemaRepository.GetFieldEntityList(sqliteConn, "student");
                    foreach (var field in fieldList)
                    {
                        var json = JsonConvert.SerializeObject(field);

                        Console.WriteLine(json);
                    }
                }
            }

            Console.Read();
        }
    }
}
