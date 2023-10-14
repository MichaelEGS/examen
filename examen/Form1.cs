using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
//using System;//


namespace Examen_Michael


{


    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Data Source=.;Initial Catalog=examen;Integrated Security=True";
        }

        private void btnInsertar_Click_Click(object sender, EventArgs e)
        {
            try



            {



                comando.Connection = conexion;

                comando.CommandText = "insert into alumno(id, nombre) values(@txtId,@txtNombre)";

                conexion.Open();

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("txtId", txtId.Text);

                comando.Parameters.AddWithValue("txtNombre", txtNombre.Text);



                int NFilas = comando.ExecuteNonQuery();

                if (NFilas > 0)

                {

                    //

                    MessageBox.Show("Lo logramos");

                }

            }




            catch (Exception ex)

            {

                MessageBox.Show("CREEME, HICISTE UN DISPARATE: " + ex);

            }

            finally
            {

                conexion.Close();

                txtId.Text = " ";

                txtNombre.Text = " ";







            }
        }
    }
}
