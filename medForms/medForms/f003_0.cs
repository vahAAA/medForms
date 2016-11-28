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
    public partial class f003_0 : Form
    {
        SQLiteConnection connection;
        mainForm mainForm;
        public f003_0(mainForm _mainForm, SQLiteConnection _connection, String query)
        {
            InitializeComponent();
            connection = _connection;
            mainForm = _mainForm;
        }

        private void f003_0_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

    


            string query;
                SQLiteCommand command;
                File.Copy("DB\\base.sqlite", "DB\\base.old.sqlite", true);
                connection = new SQLiteConnection("Data Source=DB\\base.sqlite; Version=3;");
                connection.Open();
                query = @"  INSERT INTO f003_0 (Code1, Code2, NameInst, NumMap, D1, D2, M1, M2, Y1, Y2, Hours, Minutes, Depart, NumCabinet, rdb1, rdb2, Count, DaysinBed, InDepart, Group1, Rhesus, RW, HyperSensib, Surname, Name, Patronymic, Gender, N4, Age, Birthday, FullAge, City, Adress, Phone, Work, chbIVVy, chbIVVn, Referral, NumHours, Hospitalization, Diagnosis1, Diagnosis2, Diagnosis3, Data, Doctor, Diagnosis4, Diagnosis4_1, Diagnosis4_2 , Diagnosis4_3, Code, curTime) VALUES ('" + txtCode1.Text + "', '" + txtCode2.Text + "', '" + txtNameInst.Text + "', '" + txtNumMap.Text + "', '" + txtD1.Text + "', '" + txtD2.Text + "', '" + txtM1.Text + "', '" + txtM2.Text + "', '" + txtY1.Text + "', '" + txtY2.Text + "', '" + txtHours.Text + "', '" + txtMinutes.Text + "', '" + txtDepart.Text + "', '" + txtNumCabinet.Text + "', '" + rdb1.Checked + "', '" + rdb2.Checked + "', '" + txtCount.Text + "', '" + txtDaysinBed.Text + "', '" + txtInDepart.Text + "', '" + txtGroup.Text + "', '" + txtRhesus.Text + "', '" + txtRW.Text + "', '" + txtHyperSensib.Text + "', '" + txtSurname.Text + "', '" + txtName.Text + "', '" + txtPatronymic.Text + "', '" + txtGender.Text + "', '" + txtAge.Text + "', '" + txtBirthday.Text + "', '" + txtFullAge.Text + "', '" + txtCity.Text + "', '" + txtAdress.Text + "', '" + txtPhone.Text + "', '" + txtWork.Text + "', '" + chbIVVy.Checked + "', '" + chbIVVn.Checked + "', '" + txtReferral.Text + "', '" + txtNumHours.Text + "', '" + txtHospitalization.Text + "','" + txtDiagnosis1.Text + "', '" + txtDiagnosis1.Text + "', '" + txtDiagnosis2.Text + "', '" + txtDiagnosis3.Text + "', '" + txtData.Text + "', '" + txtDoctor.Text + "', '" + txtDiagnosis4.Text + "', '" + txtDiagnosis4_1.Text + "', '" + txtDiagnosis4_2.Text + "', '" + txtDiagnosis4_3.Text + "', '" + txtCode.Text + "', '" + DateTime.Today.ToString("d") + "');";
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
