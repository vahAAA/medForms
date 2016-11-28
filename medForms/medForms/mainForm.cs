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
    public partial class mainForm : Form
    {
        SQLiteConnection connection;
        public mainForm()
        {
            InitializeComponent();
            
            //MessageBox.Show( DateTime.Today.ToString("d"));
        }
        
        private void mainForm_Load(object sender, EventArgs e)
        {
            ConnectToDB();
        }

        private void ConnectToDB()
        {
            try
            {
                bool CreatingNew = false;
                string query;
                SQLiteCommand command;

                if (!File.Exists("DB\\base.sqlite"))
                {
                    if (!Directory.Exists("DB"))
                        Directory.CreateDirectory("DB");
                    SQLiteConnection.CreateFile("DB\\base.sqlite");
                    CreatingNew = true;
                    MessageBox.Show("База даних не знайдена, створено новий файл.");
                }
                if (!CreatingNew)
                    File.Copy("DB\\base.sqlite", "DB\\base.old.sqlite", true);
                connection = new SQLiteConnection("Data Source=DB\\base.sqlite; Version=3;");
                connection.Open();
                if (!CreatingNew)
                {
                    query = @"SELECT COUNT(*) FROM sqlite_master WHERE type = 'table' AND name = 'All_patients' OR name = 'f003_0' OR name='f025_8_0' 
                             OR name='f026_0' OR name='f083_0';";
                    command = new SQLiteCommand(query, connection);
                    command.ExecuteNonQuery();
                    long tablesCount = 0;
                    using (SQLiteDataReader r = command.ExecuteReader())
                    {
                        r.Read();
                        tablesCount = (long)r["COUNT(*)"];
                    }
                    if (tablesCount != 5)
                    {
                        MessageBox.Show("База даних була пошкоджена. "+tablesCount.ToString());
                        
                        Close();
                    }
                }
               
                else
                {
                    query =
                        @"  CREATE TABLE All_patients(id INTEGER PRIMARY KEY AUTOINCREMENT, name1 VARCHAR(20), name2 VARCHAR(20), male  VARCHAR(20), age VARCHAR(20));
                            CREATE TABLE f003_0(id INTEGER PRIMARY KEY AUTOINCREMENT, Code1 VARCHAR(100), Code2 VARCHAR(100), NameInst VARCHAR(100), NumMap VARCHAR(100),D1 VARCHAR(100), D2 VARCHAR(100), M1 VARCHAR(100), M2 VARCHAR(100), Y1 VARCHAR(100), Y2 VARCHAR(100), Hours VARCHAR(100), Minutes VARCHAR(100), Depart VARCHAR(100), NumCabinet VARCHAR(100), rdb1 VARCHAR(100), rdb2 VARCHAR(100), Count VARCHAR(100), DaysinBed VARCHAR(100), InDepart VARCHAR(100), Group1 VARCHAR(100), Rhesus VARCHAR(100), RW VARCHAR(100), HyperSensib VARCHAR(100), Surname VARCHAR(100), Name VARCHAR(100), Patronymic VARCHAR(100), Gender VARCHAR(100),N4 VARCHAR(100), Age VARCHAR(100), Birthday VARCHAR(100), FullAge VARCHAR(100), City VARCHAR(100), Adress VARCHAR(100), Phone VARCHAR(100), Work VARCHAR(100), chbIVVy VARCHAR(100), chbIVVn VARCHAR(100), Referral VARCHAR(100), NumHours VARCHAR(100), Hospitalization VARCHAR(100), Diagnosis1 VARCHAR(100), Diagnosis2 VARCHAR(100), Diagnosis3 VARCHAR(100), Data VARCHAR(100), Doctor VARCHAR(100), Diagnosis4 VARCHAR(100), Diagnosis4_1 VARCHAR(100), Diagnosis4_2 VARCHAR(100), Diagnosis4_3 VARCHAR(100), Code VARCHAR(100),curTime VARCHAR(100));
                            CREATE TABLE f025_8_0(id INTEGER PRIMARY KEY AUTOINCREMENT,  CodeZKYD VARCHAR(100), CodeZKPO VARCHAR(100), NameZakl VARCHAR(100), N1 VARCHAR(100), Name1 VARCHAR(100), Born1 VARCHAR(100), Relation1 VARCHAR(100), Privileges1 VARCHAR(100), Educ1 VARCHAR(100), Job1 VARCHAR(100), Ambul1 VARCHAR(100), N2 VARCHAR(100), Name2 VARCHAR(100), Born2 VARCHAR(100), Relation2 VARCHAR(100), Privileges2 VARCHAR(100), Educ2 VARCHAR(100), Job2 VARCHAR(100), Ambul2 VARCHAR(100),N3 VARCHAR(100), Name3 VARCHAR(100), Born3 VARCHAR(100), Relation3 VARCHAR(100), Privileges3 VARCHAR(100), Educ3 VARCHAR(100), Job3 VARCHAR(100), Ambul3 VARCHAR(100),N4 VARCHAR(100), Name4 VARCHAR(100), Born4 VARCHAR(100), Relation4 VARCHAR(100), Privileges4 VARCHAR(100), Educ4 VARCHAR(100), Job4 VARCHAR(100), Ambul4 VARCHAR(100),N5 VARCHAR(100), Name5 VARCHAR(100), Born5 VARCHAR(100), Relation5 VARCHAR(100), Privileges5 VARCHAR(100), Educ5 VARCHAR(100), Job5 VARCHAR(100), Ambul5 VARCHAR(100),N6 VARCHAR(100), Name6 VARCHAR(100), Born6 VARCHAR(100), Relation6 VARCHAR(100), Privileges6 VARCHAR(100), Educ6 VARCHAR(100), Job6 VARCHAR(100), Ambul6 VARCHAR(100),N7 VARCHAR(100), Name7 VARCHAR(100), Born7 VARCHAR(100), Relation7 VARCHAR(100), Privileges7 VARCHAR(100), Educ7 VARCHAR(100), Job7 VARCHAR(100), Ambul7 VARCHAR(100), UpYear VARCHAR(100), MidYear VARCHAR(100), DownYear VARCHAR(100), LastYear VARCHAR(100), NamePunkt VARCHAR(100), District VARCHAR(100), Street VARCHAR(100), Build VARCHAR(100), Flat VARCHAR(100), Floor VARCHAR(100), Km VARCHAR(100), Phone VARCHAR(100), NameMed VARCHAR(100), Doctor VARCHAR(100), Nurse VARCHAR(100),curTime VARCHAR(100));
                            CREATE TABLE f026_0(id INTEGER PRIMARY KEY AUTOINCREMENT, CodeZKYD VARCHAR(100), CodeZKPO VARCHAR(100), NameMed VARCHAR(100), FormaNumber VARCHAR(100), Class1 VARCHAR(100), Class2 VARCHAR(100), Class3 VARCHAR(100), Alergy1 VARCHAR(100), Alergy2 VARCHAR(100), Alergy3 VARCHAR(100), FIO VARCHAR(100), Date VARCHAR(100), Adress VARCHAR(100), Policlinika VARCHAR(100), SexF BOOLEAN, SexM BOOLEAN, Num1 VARCHAR(100), Num2 VARCHAR(100), fDate VARCHAR(100), fEduc VARCHAR(100), fWork VARCHAR(100), fNum VARCHAR(100), mDate VARCHAR(100), mEduc VARCHAR(100), mWork VARCHAR(100), mNum VARCHAR(100), Umovu VARCHAR(100), Anamnez VARCHAR(100), Sport1 BOOLEAN, Sport2 BOOLEAN, TypeSport VARCHAR(100), tLang BOOLEAN, fLang BOOLEAN, tMusic BOOLEAN, fMusic BOOLEAN, other VARCHAR(100), Kip VARCHAR(100), Kashlyk VARCHAR(100), Skarlatina VARCHAR(100), Difteria VARCHAR(100), Vispa VARCHAR(100), Parotut VARCHAR(100), Krasnyha VARCHAR(100), Gepatut VARCHAR(100), Dizenteria VARCHAR(100), Tif VARCHAR(100), Tyberkyloz VARCHAR(100), Revmatuzm VARCHAR(100),curTime VARCHAR(100));
                            CREATE TABLE f083_0(id INTEGER PRIMARY KEY AUTOINCREMENT, CodeZKYD VARCHAR(100), CodeZKPO VARCHAR(100), NameMed VARCHAR(100), FormaNumber VARCHAR(100), ZatverNakaz VARCHAR(100), ZatvNakazNum VARCHAR(100), SerialNumber VARCHAR(100), Name VARCHAR(100), SurName VARCHAR(100), SecName VARCHAR(100), Birthday VARCHAR(100), Home VARCHAR(100), BloodGroup VARCHAR(100), PhBlood VARCHAR(100), SetMed VARCHAR(100), ExEnd VARCHAR(100), chbA BOOLEAN, chbB BOOLEAN, chbC BOOLEAN, chbD BOOLEAN, chbE BOOLEAN, chbTramvai BOOLEAN, chbTrollei BOOLEAN, chbOther BOOLEAN,curTime VARCHAR(100));
                            ";
                    command = new SQLiteCommand(query, connection);
                    command.ExecuteNonQuery();
                }
              //  Sport1, Sport2, TypeSport, tLang, fLang, tMusic, fMusic, other, Kip, Kashlyk, Skarlatina, Difteria, Vispa, Parotut, Krasnyha, Gepatut, Dizenteria, Tif, Tyberkyloz, Revmatuzm
            }
            catch
            {
                MessageBox.Show("При підключенні до бази даних сталася помилка. Роботу буде завершено.");
                Close();
            }
        }

            private void btnF083_0_Click(object sender, EventArgs e)
        {
            var form083_0 = new f083_0(this, connection,null);
            form083_0.ShowDialog();
        }

        private void btnF025_8_0_Click(object sender, EventArgs e)
        {
            var form025_8_0 = new f025_8_0(this, connection,null);
            form025_8_0.ShowDialog();
        }

        private void btnF003_0_Click(object sender, EventArgs e)
        {
            var form003_0 = new f003_0(this, connection,null);
            form003_0.ShowDialog();
        }

        private void btnF026_0_Click(object sender, EventArgs e)
        {
            var form026_0 = new f026_0(this, connection,null);
            form026_0.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowDB_Click(object sender, EventArgs e)
        {
            /*
            File.Copy("DB\\base.sqlite", "DB\\base.old.sqlite", true);
            connection = new SQLiteConnection("Data Source=DB\\base.sqlite; Version=3;");
            connection.Open();//Открываем соединение с бд
            string Query = "SELECT CodeZKYD FROM f026_0 Where id = '1';";//Создаем наш запрос SQL и помещаем его в переменную Query
            SQLiteCommand CreateCommand = new SQLiteCommand(Query, connection);

            SQLiteDataReader dr = CreateCommand.ExecuteReader();
            string name="";
            while (dr.Read())
            {
                name = dr.GetString(0);
                MessageBox.Show(name);
                //ClientsCombobox.Items.Add(name);
            }
*/
            var QueryForm = new QueryForm(this, connection);
            QueryForm.ShowDialog();


        }
    }
}
