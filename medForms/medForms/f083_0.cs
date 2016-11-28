using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace medForms
{
    public partial class f083_0 : Form
    {
        SQLiteConnection connection;
        mainForm mainForm;

        public f083_0(mainForm _mainForm, SQLiteConnection _connection,String query)
        {
            InitializeComponent();
            connection = _connection;
            mainForm = _mainForm;
        }

        private void btnAddNewNote_Click(object sender, EventArgs e)
        {
            try
            {

                string query;
                SQLiteCommand command;
                File.Copy("DB\\base.sqlite", "DB\\base.old.sqlite", true);
                connection = new SQLiteConnection("Data Source=DB\\base.sqlite; Version=3;");
                connection.Open();
                query = @"  INSERT INTO f083_0 (CodeZKYD, CodeZKPO, NameMed, FormaNumber, ZatverNakaz, ZatvNakazNum, SerialNumber, Name, SurName, SecName, Birthday, Home, BloodGroup, PhBlood, SetMed, ExEnd, chbA, chbB, chbC, chbD, chbE, chbTramvai, chbTrollei, chbOther, curTime ) VALUES ('" + txtCodeZKYD.Text + "', '" + txtCodeZKPO.Text + "', '" + txtNameMed.Text + "', '" + txtFormaNumber.Text + "', '" + txtZatverNakaz.Text + "', '" + txtZatvNakazNum.Text + "', '" + txtSerialNumber.Text + "', '" + txtName.Text + "', '" + txtSurName.Text + "', '" + txtSecName.Text + "', '" + txtBirthday.Text + "', '" + txtHome.Text + "', '" + txtBloodGroup.Text + "','" + txtPhBlood.Text + "', '" + txtSetMed.Text + "', '" + txtExEnd.Text + "', '" + chbA.Checked + "', '" + chbB.Checked + "', '" + chbC.Checked + "', '" + chbD.Checked + "','" + chbE.Checked + "','" + chbTramvai.Checked + "','" + chbTrollei.Checked + "','" + chbOther.Checked + "', '" + DateTime.Today.ToString("d") + "');";

                /*
                 * CodeZKYD VARCHAR(100), CodeZKPO VARCHAR(100), NameMed VARCHAR(100), FormaNumber VARCHAR(100), ZatverNakaz VARCHAR(100), ZatvNakazNum VARCHAR(100), SerialNumber VARCHAR(100), Name VARCHAR(100), SurName VARCHAR(100), SecName VARCHAR(100), Birthday VARCHAR(100), Home VARCHAR(100), BloodGroup VARCHAR(100), PhBlood VARCHAR(100), SetMed VARCHAR(100), ExEnd VARCHAR(100), chbA BOOLEAN, chbB BOOLEAN, chbC BOOLEAN, chbD BOOLEAN, chbE BOOLEAN, chbTramvai BOOLEAN, chbTrollei BOOLEAN, chbOther BOOLEAN
                 * */

                command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Данні успішно додано");
                Close();
            }
            catch
            {
                MessageBox.Show("помилка при ИНСЁТРЕ");
                Close();
            }
            
        
        }
    }
}
