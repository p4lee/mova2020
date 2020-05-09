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
 * Tekijä: Tommi Puurunen
 * 
 * SQLite Wrapper
 * Tehty Microsoft.Data.SQLiten ympärille.
 * Mallityyppi on PHP -kielen PDO MySQL yhteyden mallinen.
 * On ns. muuttujapareja, joilla voidaan estää SQL injektio, 
 * joka pahimmassa tapauksessa voi tuhota koko tietokannan.
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
            //alustetaan tietokanta tiedosto
            File.WriteAllBytes(dbloc, new byte[0]);
            using (var conn = new SqliteConnection("Data Source=" + dbloc))
            {
                conn.Open();
                var command = conn.CreateCommand();
                //liitetään taulut ja postinumerot (ja testidata mikäli halutaan testata)
                command.CommandText = Properties.Resources.alustus+Properties.Resources.postinumerot;
                
                command.ExecuteReader();
                conn.Close();
            }
        }
        /*
         * 
         * DMQuery, tulee sanoista Data Manipulation Query
         * UPDATE, INSERT, DELETE, CREATE, ALTER komennot
         * Käytetään tässä ohjelmassa vain UPDATE, INSERT ja DELETE, muut mahdollisia.
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
                } catch(SqliteException e)
                {
                    ret = -1;
                }

                conn.Close();
            }
            return ret;
        }
        /*
         * Select Query
         */
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
    }
}

