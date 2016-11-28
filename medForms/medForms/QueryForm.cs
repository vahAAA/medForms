using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medForms
{
    public partial class QueryForm : Form
    {
        SQLiteConnection connection;
        mainForm mainForm;
        SQLiteDataReader dr0 = null;
        SQLiteDataReader dr1 = null;
        SQLiteDataReader dr2 = null;
        SQLiteDataReader dr3 = null;
        SQLiteCommand CreateCommand = null;
        ArrayList records = new ArrayList();
        public static String genName = "";
        public static String genDate = "";

        public static string Query0 = "";
        public static string Query1 = "";
        public static string Query2 = "";
        public static string Query3 = "";


        bool recordIsFound = false;
        public QueryForm(mainForm _mainForm, SQLiteConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
            mainForm = _mainForm;
            boxIfDate.Checked = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!boxIfDate.Checked)
                genDate = dateBox.Text;

            genName = nameBox.Text;

            queryFunction(dateBox.Text, "curTime");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void actualQuery(String param, String table, String forName, int numName, int numDate, bool combinedName)
        {
            string name = "";
            string date = "";
            string zapis026 = "";
            Query0 = "";
            if (nameBox.Text != "")
                Query0 = "SELECT * FROM "+table+" Where "+forName+" LIKE '" + genName + "%" + "';";
          //  MessageBox.Show("FIRST "+Query0);
            if (!boxIfDate.Checked)
            {
                if (Query0 == "")
                    Query0 = "SELECT * FROM " +table+ " Where curTime LIKE '" + genDate + "%" + "';";
                else
                    Query0 = Query0.Substring(0, Query0.Length - 1) + " AND curTime LIKE '" + genDate + "%" + "';";
            }
           //  MessageBox.Show("SECOND "+Query0);
            CreateCommand = new SQLiteCommand(Query0, connection);
            dr0 = CreateCommand.ExecuteReader();
            while (dr0.Read())
            {
                name = dr0.GetString(numName);
                if (combinedName)
                {
                    name = name + " "+dr0.GetString(numName+1);
                    name = name + " "+dr0.GetString(numName + 2);
                }

                date = dr0.GetString(numDate);
                zapis026 = "Форма "+table+" " + name + " , дата создания: " + date;
                listBox1.Items.Add(zapis026);
                records.Add(Query0);
            }
            if (name != "")
                recordIsFound = true;
        }

        public void queryFunction(String nameQuery, String param)
        {
            //String nameQuery = nameBox.Text;
            String[] tables = { "f026_0", "f003_0", "f025_8_0", "f083_0" };
            File.Copy("DB\\base.sqlite", "DB\\base.old.sqlite", true);
            connection = new SQLiteConnection("Data Source=DB\\base.sqlite; Version=3;");
            connection.Open();//Открываем соединение с бд
            string param1=param;

            //string pattern = "(?<= ).*";

            //  int counter = 0;
            recordIsFound = false;
           // Query0 = "";
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    actualQuery(param1, tables[i],"FIO",11,49,false);
                }
                if (i == 1)
                {
                    actualQuery(param1, tables[i], "Surname",24,51,true);
                }
                if (i == 2)
                {
                    actualQuery(param1, tables[i], "Name1",5,75,false);
                }
                if (i == 3)
                {
                    actualQuery(param1, tables[i], "SurName",8,25,true);
                }
            }

            if (!recordIsFound)
            {
                MessageBox.Show("Данные по даному запросу не найдены");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            String whichForm = listBox1.SelectedItem.ToString();
           // MessageBox.Show(listBox1.SelectedItem.ToString());
            if (whichForm.StartsWith("Форма f026_0"))
            {
                String aa = records[i].ToString();
                var form026_0 = new f026_0(this.mainForm, connection, aa);
                form026_0.ShowDialog();
            }

            if (whichForm.StartsWith("Форма f003_0"))
            {
                String aa = records[i].ToString();
                var form003_0 = new f003_0(this.mainForm, connection, aa);
                form003_0.ShowDialog();
            }

            if (whichForm.StartsWith("Форма f025_8_0"))
            {
                String aa = records[i].ToString();
                var form025_8_0 = new f025_8_0(this.mainForm, connection, aa);
                form025_8_0.ShowDialog();
            }

            if (whichForm.StartsWith("Форма f083_0"))
            {
                String aa = records[i].ToString();
                var form083_0 = new f083_0(this.mainForm, connection, aa);
                form083_0.ShowDialog();
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (boxIfDate.Checked)
                dateBox.Enabled = false;
            else
                dateBox.Enabled = true;
        }


    }
}
