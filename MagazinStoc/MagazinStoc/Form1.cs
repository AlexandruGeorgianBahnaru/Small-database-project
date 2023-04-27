using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MagazinStoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Georgel\Desktop\ProiectJob\MagazinStoc\MagazinStoc\DatabaseDepozit.mdf;Integrated Security=True");
        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Table] VALUES('" + textBoxDenumire.Text +
                "', '" + int.Parse(textBoxCantitate.Text) + "', '" + int.Parse(textBoxPret.Text) +
                "', '" + textBoxDistribuitor.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully.");
            con.Close();
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            con.Open();
            if (textBoxDenumire.Text == null && textBoxPret.Text == null
                && textBoxCantitate.Text == null && textBoxDistribuitor.Text == null)
            {
                SqlCommand cmd = new SqlCommand("TRUNCATE TABLE [Table]", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully.");
            }
            
            else if(textBoxDenumire.Text != null)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [Table] WHERE Denumire = '" + 
                    textBoxDenumire.Text + "';", con);
                cmd.ExecuteNonQuery();
            }
            
            con.Close();
        }

        private void buttonSterge_MouseHover(object sender, EventArgs e)
        {
            toolTipSterge.Show("Lasati toate casutele liber pentru a sterge tot continutul bazei de date\n" +
                " sau scrieti in casute ce vreti sa stergeti.\nEx: scrieti in casuta Denumire *cartofi* pentru a sterge prousul din baza de date.", buttonSterge);
        }
    }
}
