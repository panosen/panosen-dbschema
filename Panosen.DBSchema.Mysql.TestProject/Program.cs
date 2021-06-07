using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.DBSchema.Mysql.TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddSingleton<IConfiguration>(v =>
            {
                var configurationBuilder = new ConfigurationBuilder();
                configurationBuilder.AddUserSecrets("15960fe2-4dcc-4775-bcf5-fc9aa6f0b768");
                return configurationBuilder.Build();
            });

            services.AddScoped<MySqlConnection>(servicePrivider =>
            {
                var configuration = servicePrivider.GetRequiredService<IConfiguration>();
                var connectionString = configuration["SampleDatabase"];
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                return connection;
            });

            var servicePrivider = services.BuildServiceProvider();

            using (var sqliteConn = servicePrivider.GetRequiredService<MySqlConnection>())
            {
                SchemaRepository schemaRepository = new SchemaRepository(sqliteConn);
                {
                    var tableList = schemaRepository.GetTables("sampledatabase");
                    foreach (var table in tableList)
                    {
                        Console.WriteLine(table.TABLE_NAME);
                    }
                }

                {
                    StringBuilder builder = new StringBuilder();

                    var fieldList = schemaRepository.GetColumns("sampledatabase", "student");

                    var json = JsonConvert.SerializeObject(fieldList, Formatting.Indented);
                    builder.Append(json).AppendLine();

                    Console.WriteLine(builder.ToString());
                }

                {
                    StringBuilder builder = new StringBuilder();

                    var fieldList = schemaRepository.GetKeyColumnUsages("sampledatabase", "lesson");

                    var json = JsonConvert.SerializeObject(fieldList, Formatting.Indented);
                    builder.Append(json).AppendLine();

                    Console.WriteLine(builder.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
