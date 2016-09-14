
using System;

using MySql.Data.MySqlClient;

namespace ConsoleApplication {

    public class Program {

        public static void Main(string[] args) {

            var conn = MySqlClientFactory.Instance.CreateConnection();
            conn.ConnectionString = "Server=127.0.0.1;Port=<port[3306]>;Uid=<username>;Pwd=<password>;";

            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM information_schema.SCHEMATA";

            var reader = cmd.ExecuteReader();

            Console.WriteLine("FieldCount: {0}", reader.FieldCount);

            for (int i = 0; i < reader.FieldCount; i++) {

                Console.Write("| {0} |", reader.GetName(i).ToUpper());

            }

            Console.WriteLine();
            Console.WriteLine();

            while (reader.Read()) {

                for (int i = 0; i < reader.FieldCount; i++) {

                    var fieldValue = reader.GetValue(i);

                    Console.Write(" {0} ", fieldValue);
                }

                Console.WriteLine();

            }

        }

    }

}
