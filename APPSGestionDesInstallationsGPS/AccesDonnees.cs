﻿using System;
using System.Data;
using MySql.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.HtmlControls;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Net;

namespace APPSGestionDesInstallationsGPS
{
    public class AccesDonnees
    {
        public String ChaineConnexion;
        public MySqlCommand Commande;
        public MySqlConnection Cnx;
        public  static string erreur;
        public static string login;
        public static string confirmation;
        public void Connexion()
        {
            Initialisation();

            try
            {
                Cnx.Open();
            }
            catch
            {
                MessageBox.Show("Connexion echouée");
            }
        }

        public void Initialisation()
        {
            String chaine;
            //chaine = "SERVER = 127.0.0.1; uid = ismael; pwd = ismael; database = bd_tontine;";
            chaine = "SERVER=localhost;uid=root; pwd=; database=gestions_des_installations;command timeout=20000";

            ChaineConnexion = chaine;

            Cnx = new MySqlConnection(getChaineConnexion());
            Commande = new MySqlCommand();
            Commande.Connection = Cnx;
        }

        public String getChaineConnexion()
        {
            return ChaineConnexion;
        }

        public void Deconnecter()
        {
            try
            {
                Cnx.Close();
            }
            catch
            {
                MessageBox.Show("Erreur de déconnexion");
            }
        }

        public void Mouchard(int codeuser, String operation)
        {
            String requette = "";
            requette = "call administration.mouchard(" + codeuser + ",'" + operation + "')";
            ExecuteRequette(requette);
        }

        public void ExecuteRequette(String requette)
        {

            Connexion();

            Commande.CommandText = requette;
            MySqlDataReader oReader;
            try
            {
                oReader = Commande.ExecuteReader(CommandBehavior.CloseConnection);
                oReader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Deconnecter();
            }
        }

        public Boolean EnVoiSMS(string message, string dest, string expedt)
        {
            Boolean trouve = false;
            string gApi = "http://121.241.242.114:8080/bulksms/bulksms?";
            string expediteur = expedt;

            /* string compte = ResultatRequette("select compte_sms from parametre");
             string psw = ResultatRequette("select psw_sms from parametre");
             */
            string compte = "Jordan";
            string psw = "LJ";
            string strUrl = "";
            strUrl = gApi + "username=" + compte + "&password=" + psw + "&type=0&dlr=1&destination=237" + dest + "&source=" + expedt + "&message=" + message;

            try
            {
                WebRequest request = HttpWebRequest.Create(strUrl);
                WebResponse response = request.GetResponse();
                var stream_response = response.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(stream_response);

                StreamReader readStream = new StreamReader(stream_response);
                string dataString = readStream.ReadToEnd();
                response.Close();
                stream_response.Close();
                readStream.Close();
                trouve = true;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                trouve = false;
            }

            return trouve;
        }




        public String ResultatRequette(String requette)
        {

            Connexion();
            Commande.CommandText = requette;
            Commande.Connection = Cnx;
            MySqlDataReader lecture;
            lecture = Commande.ExecuteReader();

            String le_resultat = "";

            while (lecture.Read())
            {
                le_resultat = (String)lecture[0];
            }

            lecture.Close();
            Deconnecter();
            return le_resultat;

        }

        public int ResultatRequette1(String requette)
        {

            Connexion();
            Commande.CommandText = requette;
            Commande.Connection = Cnx;
            MySqlDataReader lecture;
            lecture = Commande.ExecuteReader();

            int le_resultat = 0;

            while (lecture.Read())
            {
                le_resultat = Convert.ToInt32((lecture[0]));
            }

            lecture.Close();
            Deconnecter();
            return le_resultat;

        }


        public long ResultatRequette2(String requette)
        {

            Connexion();
            Commande.CommandText = requette;
            Commande.Connection = Cnx;
            MySqlDataReader lecture;
            lecture = Commande.ExecuteReader();

            long le_resultat = 0;

            while (lecture.Read())
            {
                le_resultat = Convert.ToInt64((lecture[0]));
            }

            lecture.Close();
            Deconnecter();
            return le_resultat;

        }
        public Double ResultatRequette3(String requette)
        {

            Connexion();
            Commande.CommandText = requette;
            Commande.Connection = Cnx;
            MySqlDataReader lecture;
            lecture = Commande.ExecuteReader();

            double le_resultat = 0;

            while (lecture.Read())
            {
                // le_resultat = Convert.ToInt64((lecture[0]));
                le_resultat = Convert.ToDouble((lecture[0]));
            }

            lecture.Close();
            Deconnecter();
            return le_resultat;

        }

        public String setChaineConnexion(String Chaine)
        {
            return Chaine;
        }

        public DataSet RecuperationTable(String requette)
        {
            DataSet le_data_set = new DataSet();
            Connexion();

            MySqlDataAdapter da;
            da = new MySqlDataAdapter(requette, Cnx);
            Deconnecter();
            da.FillSchema(le_data_set, SchemaType.Source);
            da.Fill(le_data_set);

            return le_data_set;
        }


        public void ChargeTable(DataGridView datagridv, String requette)
        {
            Connexion();
            datagridv.AutoGenerateColumns = false;
            DataSet le_data_set = new DataSet();

            MySqlDataAdapter da;
            da = new MySqlDataAdapter(requette, Cnx);
            da.Fill(le_data_set);

            datagridv.DataSource = le_data_set.Tables[0];
            datagridv.ReadOnly = true;
            datagridv.MultiSelect = false;

            DataGridViewCellStyle CelluleAlternee = new DataGridViewCellStyle();

            CelluleAlternee.ForeColor = System.Drawing.Color.Black;
            CelluleAlternee.BackColor = System.Drawing.Color.LightGray;

            datagridv.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            datagridv.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            datagridv.AlternatingRowsDefaultCellStyle = CelluleAlternee;
            Deconnecter();

        }


        public void ChargeTable1(DataGridView datagridv, String requette)
        {
            Connexion();
            datagridv.AutoGenerateColumns = false;
            DataSet le_data_set = new DataSet();

            MySqlDataAdapter da;
            da = new MySqlDataAdapter(requette, Cnx);

            // je cree une connection a la DB pour l'image
            //da = new MySqlDataAdapter();
            // suite de ma classe


            da.Fill(le_data_set);

            datagridv.DataSource = le_data_set.Tables[0];

            datagridv.MultiSelect = false;

            DataGridViewCellStyle CelluleAlternee = new DataGridViewCellStyle();

            CelluleAlternee.ForeColor = System.Drawing.Color.Black;
            CelluleAlternee.BackColor = System.Drawing.Color.LightGray;

            datagridv.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            datagridv.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            datagridv.AlternatingRowsDefaultCellStyle = CelluleAlternee;
            Deconnecter();

        }

        public void ChargeCombo(ComboBox combo, string requette)
        {
            Connexion();
            combo.Items.Clear();
            Commande.CommandText = requette;
            Commande.Connection = Cnx;
            MySqlDataReader lecture = Commande.ExecuteReader();

            while (lecture.Read())
            {
                combo.Items.Add((string)lecture.GetValue(0).ToString());
            }
            Deconnecter();
            lecture.Close();
        }


        public void copie_fichier(string nom_fichier, string chemin_fichier_source)
        {
            string nom_rep = "d:\\doc";
            string nom_fichier_dest = nom_rep + "\\" + nom_fichier;
            File.Copy(chemin_fichier_source, nom_fichier_dest, true);

        }


        //public string CryptageMD5(string Str )
        //{
        //MD5CryptoServiceProvider provider=new MD5CryptoServiceProvider();
        //Byte[] bytValue;
        //Byte[] bytHash;
        //string strOutput= "";

        //bytValue = System.Text.Encoding.UTF8.GetBytes(Str);
        //bytHash = provider.ComputeHash(bytValue);
        //provider.Clear();

        //for(int i = 0;i<bytHash.Length - 1;i++)
        //    strOutput &= bytHash[i].ToString("x").PadLeft[2, "0"];


        //return strOutput;
        //}

        public string CryptageMD5(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        public string date_vers_mysql(string ladate)
        {
            return ResultatRequette("SELECT CONCAT(SUBSTR('" + ladate + "',7,4),'-',SUBSTR('" + ladate + "',4,2),'-',SUBSTR('" + ladate + "',1,2)) FROM dual");
        }



    }
}



