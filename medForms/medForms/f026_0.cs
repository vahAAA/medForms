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
    public partial class f026_0 : Form
    {
        SQLiteConnection connection;
        mainForm mainForm;
        String query = "";

        public static TextBox[] tbArray;

        public f026_0(mainForm _mainForm, SQLiteConnection _connection, String query)
        {
            InitializeComponent();
            connection = _connection;
            mainForm = _mainForm;

                        
            if (query != null)
            {
               // foreach (TextBox textBox in this.Controls.OfType<TextBox>())
               // {
                //    textBox.Enabled = false;
                //}
                this.query = query;

                // tbArray={txtCodeZKYD};
                // double [] aaaa = {1,2};
                TextBox[] tbArray1 = { txtCodeZKYD, txtCodeZKPO, txtNameZakl, txtForm, txtClass1, txtClass2, txtClass3, txtAlergy1, txtAlergy2, txtAlergy3, txtNameChild, txtDate, txtAdress, txtHospital, txtPhone };

                SQLiteCommand CreateCommand = new SQLiteCommand(query, connection);
                SQLiteDataReader dr0 = CreateCommand.ExecuteReader();


                while (dr0.Read())
                {
                    txtCodeZKYD.Text = dr0.GetString(1);
                    txtCodeZKPO.Text = dr0.GetString(2);
                    txtNameZakl.Text = dr0.GetString(3);
                    txtForm.Text = dr0.GetString(4);
                    txtClass1.Text = dr0.GetString(5);
                    txtClass2.Text = dr0.GetString(6);
                    txtClass3.Text = dr0.GetString(7);
                    txtAlergy1.Text = dr0.GetString(8);
                    txtAlergy2.Text = dr0.GetString(9);
                    txtAlergy3.Text = dr0.GetString(10);
                    txtNameChild.Text = dr0.GetString(11);

                }
            }

        }

        private void btnWriteBD_Click(object sender, EventArgs e)
        {
            try
            {




                string query;
                SQLiteCommand command;
                File.Copy("DB\\base.sqlite", "DB\\base.old.sqlite", true);
                connection = new SQLiteConnection("Data Source=DB\\base.sqlite; Version=3;");
                connection.Open();
                query = @"  INSERT INTO f026_0 (CodeZKYD, CodeZKPO, NameMed, FormaNumber, Class1, Class2, Class3, Alergy1, Alergy2, Alergy3, FIO, Date, Adress, Policlinika, SexF, SexM, Num1, Num2, fDate, fEduc, fWork, fNum, mDate, mEduc, mWork, mNum, Umovu, Anamnez, Sport1, Sport2, TypeSport, tLang, fLang, tMusic, fMusic, other, Kip, Kashlyk, Skarlatina, Difteria, Vispa, Parotut, Krasnyha, Gepatut, Dizenteria, Tif, Tyberkyloz, Revmatuzm, curTime) VALUES ('" + txtCodeZKYD.Text + "', '" + txtCodeZKPO.Text + "', '" + txtNameZakl.Text + "', '" + txtForm.Text + "', '" + txtClass1.Text + "', '" + txtClass2.Text + "', '" + txtClass3.Text + "', '" + txtAlergy1.Text + "', '" + txtAlergy2.Text + "', '" + txtAlergy3.Text + "', '" + txtNameChild.Text + "', '" + dateBorn.Text + "', '" + txtAdress.Text + "', '" + txtHospital.Text + "', '" + chbFemale.Checked + "', '" + chbMale.Checked + "', '" + txtPhone.Text + "', '" + txtPhoneHosp.Text + "', '" + txtBornFather.Text + "', '" + txtEducationF.Text + "', '" + txtJobF.Text + "', '" + txtPhoneF.Text + "', '" + txtBornMother.Text + "', '" + txtEducationM.Text + "', '" + txtJobM.Text + "', '" + txtPhoneM.Text + "', '" + txtUmovy.Text + "', '" + txtAnamnez.Text + "', '" + chbYesSport.Checked + "', '" + chbNoSport.Checked + "', '" + txtSportKind.Text + "', '" + chbYesLanguage.Checked + "', '" + chbNoLanguage.Checked + "', '" + chbYesMusic.Text + "', '" + chbNoMusic.Checked + "', '" + txtOther.Text + "', '" + txtDateKir.Text + "', '" + txtDateKashluk.Text + "', '" + txtDateScar.Text + "','" + txtDateDyft.Text + "', '" + txtDateOspa.Text + "', '" + txtDateParotyt.Text + "', '" + txtDateRed.Text + "', '" + txtDateGepatyt.Text + "', '" + txtDateDyzen.Text + "', '" + txtDateTyf.Text + "', '" + txtDateTuber.Text + "', '" + txtDateRevma.Text + "', '" + DateTime.Today.ToString("d") + "');";
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
