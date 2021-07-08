using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace proba5._5
{
    class SzerverData
    {
        //Listák Userek
        public static List<DolgozokAdmin> AdminUserLista = new List<DolgozokAdmin>();
        public static List<DolgozokBP> BPUserLista = new List<DolgozokBP>();
        public static List<DolgozokDebrecen> DebUserLista = new List<DolgozokDebrecen>();
        public static List<DolgozokGYOR> GyorUserLista = new List<DolgozokGYOR>();
        /// Listák Maszkok
        public static List<MaszkAruk> MaszInfokOsszes = new List<MaszkAruk>();
        
        ////Databases
        ///USEREK_Adatbázisa_INFO (rossz az elnevezés(Az összes user ott van))
        private static string FileUtvonalAdmin = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\DolgozokAdmin.mdf";
        public static string SzerverInfoAdmin = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + FileUtvonalAdmin + ";Integrated Security=True";


        // FUGGVENYEK

        /////////////Admin_Beolvasas_Listába
        public static void AdminListabaOlvasas()
        {
            string Lekeredezes = "SELECT * FROM DolgozokAdmin";
            using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        SzerverData.AdminUserLista.Add(new DolgozokAdmin(Convert.ToInt32(LekerdezesParancs["id"]), Convert.ToString(LekerdezesParancs["nev"]), Convert.ToString(LekerdezesParancs["jelszo"])));
                    }
                    Csatlakozas.Close();
                }
            }
        }

        ///////////Budapest_Beolvasás_Listába
        public static void BudapestUsersListabaOlvasas()
        {
            string Lekeredezes = "SELECT * FROM DolgozokBP";
            using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        SzerverData.BPUserLista.Add(new DolgozokBP(Convert.ToInt32(LekerdezesParancs["id"]), Convert.ToString(LekerdezesParancs["nev"]), Convert.ToString(LekerdezesParancs["jelszo"])));
                    }
                    Csatlakozas.Close();
                }
            }
        }

        //////////Győr_Beolvasás_Listába

        public static void GyorUsersListabaOlvasas()
        {
            string Lekeredezes = "SELECT * FROM DolgozokGY";
            using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        SzerverData.GyorUserLista.Add(new DolgozokGYOR(Convert.ToInt32(LekerdezesParancs["id"]), Convert.ToString(LekerdezesParancs["nev"]), Convert.ToString(LekerdezesParancs["jelszo"])));
                    }
                    Csatlakozas.Close();
                }
            }
        }

        //////////Debrecen_Beolvasás_Listába

        public static void DebrecenUsersListabaOlvasas()
        {
            string Lekeredezes = "SELECT * FROM DolgozokD";
            using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        SzerverData.DebUserLista.Add(new DolgozokDebrecen(Convert.ToInt32(LekerdezesParancs["id"]), Convert.ToString(LekerdezesParancs["nev"]), Convert.ToString(LekerdezesParancs["jelszo"])));
                    }
                    Csatlakozas.Close();
                }
            }
        }

        //Maszk áruk Az egész
        public static void MaszarukListabaOlvasas()
        {
            string Lekeredezes = "SELECT * FROM MaszkAruk";
            using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
            {
                using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                {
                    Csatlakozas.Open();
                    SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                    Parancs.Dispose();
                    while (LekerdezesParancs.Read())
                    {
                        SzerverData.MaszInfokOsszes.Add(new MaszkAruk(Convert.ToInt32(LekerdezesParancs["id"]), Convert.ToString(LekerdezesParancs["maszktipus"]), Convert.ToString(LekerdezesParancs["maszknev"]), Convert.ToInt32(LekerdezesParancs["keszletarubudapest"]), Convert.ToInt32(LekerdezesParancs["keszletarugyor"]), Convert.ToInt32(LekerdezesParancs["keszletarudebrecen"]), Convert.ToDouble(LekerdezesParancs["ar_db"]), Convert.ToDouble(LekerdezesParancs["akcio"]), Convert.ToString(LekerdezesParancs["barcode"])));
                    }
                    Csatlakozas.Close();
                }
            }
        }
    }
}

