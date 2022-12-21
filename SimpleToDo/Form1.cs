using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimpleToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
	     	ListeLaden();
        }

        #region  Buttons 

        //---------------------------< #region Buttons >---------------------------

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            eintrag_loeschen();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            eintrag_anfuegen();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            eintrag_Updaten();
        }

        //---------------------------</ #region Buttons >---------------------------

        #endregion /Buttons



        #region  Controls 

        //---------------------------< #region Controls >---------------------------

        private void lstAutos_SelectedIndexChanged(object sender, EventArgs e)

        {

            DataRowView row = lstToDo.SelectedItem as DataRowView;

            string sText = row["Item"].ToString();



            tbxEingabe.Text = sText;

            //MessageBox.Show(sText);

            //---------------------------< #region Controls >---------------------------

        }

        #endregion /Controls


        #region Methods

        //---------------------------< #region Methods >---------------------------

        private void ListeLaden()

        {

            //--------------< liste_laden() >--------------

            //< Daten >

            string sql_Text = "SELECT * FROM tbl_ToDo";

            DataTable tblData = db_get_Table(sql_Text);

            //</ Daten >



            //-------< Anzeigen >-------

            lstToDo.DisplayMember = "Item";

            lstToDo.ValueMember = "[Id]";



            lstToDo.DataSource = tblData;

            //-------</ Anzeigen >-------

            //--------------</ liste_laden() >--------------

        }



        private void eintrag_anfuegen()

        {

            //--------------< liste_laden() >--------------

            //< Daten >



            string sNeuer_Wert = tbxEingabe.Text;



            string sql_Text = "INSERT INTO tbl_ToDo ([Item]) VALUES('" + sNeuer_Wert + "')";

            db_execute(sql_Text);



            ListeLaden();

            //</ Daten >

            //--------------</ liste_laden() >--------------

        }



        private void eintrag_loeschen()

        {

            //--------------< liste_laden() >--------------

            //< Daten >



            DataRowView row = lstToDo.SelectedItem as DataRowView;

            string ItemID = row["Id"].ToString();

            string sql_Text = "DELETE FROM tbl_ToDo WHERE(Id = " + ItemID + ")";



            db_execute(sql_Text);



            ListeLaden();

            //</ Daten >



            //--------------</ liste_laden() >--------------

        }



        private void eintrag_Updaten()

        {

            //--------------< liste_laden() >--------------

            //< Daten >

            DataRowView row = lstToDo.SelectedItem as DataRowView;

            string ItemID = row["Id"].ToString();

            string sql_Text = "UPDATE tbl_ToDo SET [Item] = '" + tbxEingabe.Text + "' WHERE Id = " + ItemID;

            db_execute(sql_Text);



            ListeLaden();

            //</ Daten >



            //--------------</ liste_laden() >--------------

        }

        //---------------------------</ #region Methods >---------------------------

        #endregion /Methods


        #region Methods: Database

        //---------------------------< #region Methods: Database >---------------------------

        private DataTable db_get_Table(string sql_Text)

        {

            //--------------------< db_get_Table() >---------------

            //*Anzeigen von Daten

            //< init >

            //via app-Settings

            string cn_string = Properties.Settings.Default.app_ConnectionString;

            //</ init >



            SqlConnection cn = new SqlConnection(cn_string);

            if (cn.State != ConnectionState.Open) cn.Open();

            SqlDataAdapter sql_adapt = new SqlDataAdapter(sql_Text, cn);



            DataTable tblData = new DataTable();

            sql_adapt.Fill(tblData);

            cn.Close();

            return tblData;

            //--------------------</ db_get_Table() >---------------

        }



        private int db_execute(string sql_Text)

        {

            //--------------------< db_get_Table() >---------------

            //*Ausfuehren von SQL Befehlen wie INSERT, DELETE, UPDATE

            //< init >

            //via app-Settings

            string cn_string = Properties.Settings.Default.app_ConnectionString;

            //</ init >



            SqlConnection cn = new SqlConnection(cn_string);

            if (cn.State != ConnectionState.Open) cn.Open();



            SqlCommand cmd = new SqlCommand(sql_Text, cn);

            int intResult = cmd.ExecuteNonQuery();

            cn.Close();



            return intResult;

            //--------------------</ db_get_Table() >---------------

        }



        //---------------------------</ #region Methods: Database >---------------------------

        #endregion /Methods: Database 

        
    }
}
