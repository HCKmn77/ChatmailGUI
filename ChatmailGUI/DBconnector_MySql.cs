using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;



namespace it.schule
{
    class DBconnector
    {
       
        MySqlConnection verbindung = new MySqlConnection();
        MySqlCommand befehl = new MySqlCommand();


        public void Connector(string server, string database, string userid, string pw)
        {
            verbindung.ConnectionString = "server=" + server + ";database=" + database + ";userid=" + userid + ";password=" + pw;

        }

        public void Open()
        {
            if (verbindung.State != ConnectionState.Open)
				verbindung.Open();
        }
        public void Close()
        {
            verbindung.Close();
        }
        public MySqlDataReader Execute(string Query)
        {
            befehl.CommandText = Query;
            befehl.Connection = verbindung;
            return befehl.ExecuteReader();
        }


        public int ExecuteScalar(string Query)
        {
            befehl.CommandText = Query;
            befehl.Connection = verbindung;
			object buffer = befehl.ExecuteScalar();
            return Convert.ToInt32(buffer);
        }



        public DataTable ExecuteTable(string Query)
        {
            DataTable Tabelle = new DataTable();
			Open();
            Tabelle.Load( Execute(Query) );
			Close();
            return Tabelle;
        }
    }
}
