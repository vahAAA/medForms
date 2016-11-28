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
    public partial class f025_8_0 : Form
    {
        SQLiteConnection connection;
        mainForm mainForm;

        public f025_8_0(mainForm _mainForm, SQLiteConnection _connection, String query)
        {
            InitializeComponent();
            connection = _connection;
            mainForm = _mainForm;
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
                query = @"  INSERT INTO f025_8_0 (CodeZKYD, CodeZKPO, NameZakl, N1, Name1 , Born1, Relation1 , Privileges1 , Educ1 , Job1 , Ambul1 , N2 , Name2, Born2, Relation2 , Privileges2 , Educ2 , Job2 , Ambul2 ,N3 , Name3 , Born3 , Relation3 , Privileges3 , Educ3 , Job3 , Ambul3 ,N4 , Name4 , Born4 , Relation4 , Privileges4 , Educ4 , Job4 , Ambul4 ,N5 , Name5 , Born5 , Relation5, Privileges5 , Educ5 , Job5 , Ambul5 ,N6 , Name6 , Born6 , Relation6 , Privileges6 , Educ6 , Job6 , Ambul6 ,N7 , Name7 , Born7 , Relation7 , Privileges7 , Educ7 , Job7 , Ambul7 , UpYear , MidYear , DownYear , LastYear , NamePunkt , District , Street , Build , Flat , Floor , Km , Phone , NameMed , Doctor , Nurse, curTime ) VALUES ('" + txtCodeZKYD.Text + "', '" + txtCodeZKPO.Text + "', '" + txtNameZakl.Text + "', '" + txt1.Text + "', '" + txtName1.Text + "', '" + txtBorn1.Text + "', '" + txtRelation1.Text + "', '" + txtPrivileges1.Text + "', '" + txtEduc1.Text + "', '" + txtJob1.Text + "', '" + txtAmbul1.Text + "', '" + txt2.Text + "', '" + txtName2.Text + "', '" + txtBorn2.Text + "', '" + txtRelation2.Text + "', '" + txtPrivileges2.Text + "', '" + txtEduc2.Text + "', '" + txtJob2.Text + "', '" + txtAmbul2.Text + "', '" + txt3.Text + "', '" + txtName3.Text + "', '" + txtBorn3.Text + "', '" + txtRelation3.Text + "', '" + txtPrivileges3.Text + "', '" + txtEduc3.Text + "', '" + txtJob3.Text + "', '" + txtAmbul3.Text + "', '" + txt4.Text + "', '" + txtName4.Text + "', '" + txtBorn4.Text + "', '" + txtRelation4.Text + "', '" + txtPrivileges4.Text + "', '" + txtEduc4.Text + "', '" + txtJob4.Text + "', '" + txtAmbul4.Text + "', '" + txt5.Text + "', '" + txtName5.Text + "', '" + txtBorn5.Text + "', '" + txtRelation5.Text + "', '" + txtPrivileges5.Text + "', '" + txtEduc5.Text + "', '" + txtJob5.Text + "', '" + txtAmbul5.Text + "', '" + txt6.Text + "', '" + txtName6.Text + "', '" + txtBorn6.Text + "', '" + txtRelation6.Text + "', '" + txtPrivileges6.Text + "', '" + txtEduc6.Text + "', '" + txtJob6.Text + "', '" + txtAmbul6.Text + "', '" + txt7.Text + "', '" + txtName7.Text + "', '" + txtBorn7.Text + "', '" + txtRelation7.Text + "', '" + txtPrivileges7.Text + "', '" + txtEduc7.Text + "', '" + txtJob7.Text + "', '" + txtAmbul7.Text + "', '" + txtUpYear.Text + "', '" + txtMidYear.Text + "','" + txtDownYear.Text + "','" + txtLastYear.Text + "','" + txtNamePunkt.Text + "','" + txtDistrict.Text + "','" + txtStreet.Text + "','" + txtBuild.Text + "','" + txtFlat.Text + "','" + txtFloor.Text + "','" + txtKm.Text + "','" + txtPhone.Text + "','" + txtNameMed.Text + "','" + txtDoctor.Text + "','" + txtNurse.Text + "', '" + DateTime.Today.ToString("d") + "');";
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
