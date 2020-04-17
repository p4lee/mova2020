using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Collections;

namespace MOVA2020.objs
{
    public class DBHandler
    {
        private string dbloc;
        public DBHandler(string dbloc = @"D:\temp\test.db", string dbdata = @"D:\temp\villagenewbies.sql")
        {

            this.dbloc = dbloc;
            if (!File.Exists(dbloc))
            {
                this.CreateDb(dbloc, dbdata);
            }
        }
        private void CreateDb(string dbloc, string dbdata)
        {
            File.WriteAllBytes(dbloc, new byte[0]);
            using (var conn = new SqliteConnection("Data Source=" + dbloc))
            {
                conn.Open();
                var command = conn.CreateCommand();
                var insertstr = "INSERT INTO posti(postinro, toimipaikka) VALUES($nro, $toimipaikka);";
                insertstr += "INSERT INTO asiakas(etunimi, sukunimi, lahiosoite, email, puhelinnro, postinro) VALUES($etunimi, $sukunimi, $lahiosoite, $email, $puh, $postinro);";

                command.CommandText = File.ReadAllText(dbdata) + insertstr;
                command.Parameters.AddWithValue("$nro", "70500");
                command.Parameters.AddWithValue("$toimipaikka", "Kuopio");
                command.Parameters.AddWithValue("$etunimi", "asd");
                command.Parameters.AddWithValue("$sukunimi", "asd");
                command.Parameters.AddWithValue("$lahiosoite", "asd");
                command.Parameters.AddWithValue("$email", "asdsad");
                command.Parameters.AddWithValue("$puh", "sadads");
                command.Parameters.AddWithValue("$postinro", "70500");
                command.ExecuteReader();
                conn.Close();
            }
        }
        /*
         * 
         * @params string query, Dictionary<string, string> pairs
         * returns amounts of row affected by data manipulation queries
         * returns -1 if exception is encountered
         */
        public int DMquery(string query, Dictionary<string, Object> pairs)
        {
            int ret;
            using (var conn = new SqliteConnection("Data Source=" + dbloc))
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = query;
                foreach (KeyValuePair<string, Object> kvp in pairs)
                {
                    command.Parameters.AddWithValue(kvp.Key, kvp.Value);
                }
                try
                {
                    ret = command.ExecuteNonQuery();
                }
                catch (SqliteException)
                {
                    ret = -1;
                }
                conn.Close();
            }
            return ret;
        }
        public List<Object[]> SelectQuery(string select, Dictionary<string, Object> valuePairs=null)
        {
            List<Object[]> lista = new List<Object[]>();
            using (var conn = new SqliteConnection("Data Source=" + dbloc))
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = select;
                if (valuePairs != null)
                {
                    foreach (KeyValuePair<string, Object> kvp in valuePairs)
                    {
                        command.Parameters.AddWithValue(kvp.Key, kvp.Value);
                    }
                }
                using (var reader = command.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        Object[] asd = new object[reader.FieldCount];
                        reader.GetValues(asd);
                        lista.Add(asd);
                        i++;
                    }
                }
                conn.Close();
            }
            return lista;
        }
        public string ObjToQuery(ArrayList list, string type="update")
        {
            //todo
            return null;
        }

        public ArrayList SelectToObjs()
        {
            //todo
            ArrayList list = new ArrayList();
            return list;
        }
    }
}

