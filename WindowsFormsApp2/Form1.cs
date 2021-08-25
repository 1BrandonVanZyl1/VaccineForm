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

namespace WindowsFormsApp2
{
    public partial class Vaccine : Form
    {
        public Vaccine()
        {
            InitializeComponent();
        }

     

        private void savebtn_Click(object sender, EventArgs e)
        {
            try

            {

                String str = "Data Source=LAPTOP-Q1L5OKJ1;Initial Catalog=PracticalDays;Integrated Security=True";

                String query = "Insert into Users (ID, Surname, FirstName, Gender) VALUES ( @id, @surname, @firstName, @gender)"; ;

                SqlConnection con = new SqlConnection(str);

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.Parameters.AddWithValue("@id", idBox.Text);
                cmd.Parameters.AddWithValue("@surname", SNameBox.Text);
                cmd.Parameters.AddWithValue("firstName", FNameBox.Text);
                cmd.Parameters.AddWithValue("gender", GenderBox.Text);

                

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record is saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                DataSet ds = new DataSet();

                

              

                con.Close();

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }




        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            idBox.Clear();
            SNameBox.Clear();
            FNameBox.Clear();
            GenderBox.Clear();
        }

     
    }
}
