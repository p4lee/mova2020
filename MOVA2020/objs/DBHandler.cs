using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Collections;
/*
 * 
 * DELETE FROM asiakas WHERE asiakas_id=$id;
 * UPDATE asiakas SET etunimi=$etunimi WHERE asiakas_id=$id;
 * INSERT INTO asiakas(postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro) VALUES($postinro, $etunimi, $lahiosoite, $email, $puhelinnro)
 * 
 * Dictionary<string, Object) paritAsiakas = new Dictionary<string, object>();
 * parit.add($id, asiakasid);
 * 
 * INSERTIN parit
 * Dictionary<string, Object) paritAsiakas = new Dictionary<string, object>();
 * parit.add("$postinro", tbPostinro.Text)
 * 
 */
namespace MOVA2020.objs
{
    public class DBHandler
    {
        private string dbloc;

        /*
         * Luo tietokannan projektin Debug kansioon source\repos\MOVA2020\MOVA2020\bin\Debug
         */
        public DBHandler(string dbloc = @".\tietokanta.db")
        {
            this.dbloc = dbloc;
            if (!File.Exists(dbloc))
            {
                this.CreateDb(dbloc);
            }
        }
        private void CreateDb(string dbloc)
        {
            File.WriteAllBytes(dbloc, new byte[0]);
            using (var conn = new SqliteConnection("Data Source=" + dbloc))
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = Properties.Resources.alustus+Properties.Resources.postinumerot+Properties.Resources.testidata;
                
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
                catch (SqliteException e) //moi
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

