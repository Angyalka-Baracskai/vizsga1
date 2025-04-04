using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace vizsga
{
    class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;
        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "magantanar";
            sb.Port = 3307;
            try
            {
                connection = new MySqlConnection(sb.ConnectionString);
                nyit();
                command = connection.CreateCommand();
                zar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        internal List<Tanar> getTanarRegisztraltak()
        {
            List<Tanar> vissza = new List<Tanar>();
            command.CommandText = "SELECT * FROM `tanar` WHERE `aktiv` = 'true' ORDER BY `tanar_id` ASC";
            try
            {
                nyit();
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Tanar uj = new Tanar();
                        uj.Adoszam = dr.GetString("Adoszam");
                        uj.Aktiv = bool.Parse( dr.GetString("Aktiv"));
                        uj.Bemutatkozas = dr.GetString("Bemutatkozas");
                        uj.BSzamla = dr.GetInt32("Bszamla");
                        uj.Dijszabas = int.Parse(dr.GetString("Dijszabas"));
                        uj.Email = dr.GetString("Email");
                        uj.Hazszam = int.Parse(dr.GetString("Hazszam"));
                        uj.IBAN = dr.GetString("IBAN");
                        uj.Iranyitoszam = dr.GetString("Iranyitoszam");
                        uj.Jelszo = dr.GetString("Jelszo");
                        uj.TanarId = dr.GetInt32("tanar_id");
                        uj.Telefonszam = dr.GetString("Telefonszam");
                        uj.TNev = dr.GetString("t_nev");
                        uj.Utca = dr.GetString("utca");
                        uj.Varos = dr.GetString("varos");
                        vissza.Add(uj);
                    }
                }
                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            return vissza;
        }

        internal List<Tanar> getTanarFolyamatban()
        {
            List<Tanar> visszafoly = new List<Tanar>();
            command.CommandText = "SELECT * FROM `tanar` WHERE `aktiv` = 'false' ORDER BY `tanar_id` ASC";
            try
            {
                nyit();
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Tanar uj = new Tanar();
                        uj.Adoszam = dr.GetString("Adoszam");
                        uj.Aktiv = bool.Parse(dr.GetString("Aktiv"));
                        uj.Bemutatkozas = dr.GetString("Bemutatkozas");
                        uj.BSzamla = dr.GetInt32("Bszamla");
                        uj.Dijszabas = int.Parse(dr.GetString("Dijszabas"));
                        uj.Email = dr.GetString("Email");
                        uj.Hazszam = int.Parse(dr.GetString("Hazszam"));
                        uj.IBAN = dr.GetString("IBAN");
                        uj.Iranyitoszam = dr.GetString("Iranyitoszam");
                        uj.Jelszo = dr.GetString("Jelszo");
                        uj.TanarId = dr.GetInt32("tanar_id");
                        uj.Telefonszam = dr.GetString("Telefonszam");
                        uj.TNev = dr.GetString("t_nev");
                        uj.Utca = dr.GetString("utca");
                        uj.Varos = dr.GetString("varos");
                        visszafoly.Add(uj);
                    }
                }
                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            return visszafoly;
        }

        internal List<Tantargy> getTantargyelfogadott()
        {
            List<Tantargy> visszafoly = new List<Tantargy>();
            command.CommandText = "SELECT * FROM `tantargyak` WHERE 1";
            try
            {
                nyit();
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Tantargy uj = new Tantargy();
                        uj.tantargy_id = dr.GetInt32("tantargy_id");
                        uj.tantargy_nev = dr.GetString("tantargy_nev");
                        uj.oradij = dr.GetInt32("oradij");
                        visszafoly.Add(uj);
                    }
                }
                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            return visszafoly;
        }
        internal List<Diak> getDiakRegisztraltak()
        {
            List<Diak> vissza = new List<Diak>();
            command.CommandText = "SELECT * FROM `diak` WHERE `aktiv` = 'true' ORDER BY `diak_id` ASC";
            try
            {
                nyit();
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Diak uj = new Diak();
                        uj.aktiv = bool.Parse(dr.GetString("Aktiv"));
                        uj.diak_id = dr.GetInt32("diak_id");
                        uj.d_nev = dr.GetString("d_nev");
                        uj.email = dr.GetString("email");
                        uj.jelszo = dr.GetString("jelszo");
                        vissza.Add(uj);
                    }
                }
                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            return vissza;
        }

        internal List<Diak> getDiakFolyamatban()
        {
            List<Diak> visszafoly = new List<Diak>();
            command.CommandText = "SELECT * FROM `diak` WHERE `aktiv` = 'false' ORDER BY `diak_id` ASC";
            try
            {
                nyit();
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Diak uj = new Diak();
                        uj.aktiv = bool.Parse(dr.GetString("Aktiv"));
                        uj.diak_id = dr.GetInt32("diak_id");
                        uj.d_nev = dr.GetString("d_nev");
                        uj.email = dr.GetString("email");
                        uj.jelszo = dr.GetString("jelszo");
                        visszafoly.Add(uj);
                    }
                }
                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            return visszafoly;
        }

        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void nyit()
        {
            if(connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
    }
}
