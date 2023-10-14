using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1 : Form
    {
        SqlConnetion conexion = new SqlConnection();

        SqlCommand comando = new SqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try



            {

                conexion.Open();

                comando.Connection = conexion;

                comando.CommandText = "insert into alumno(id,nombre) values(@txtId,@txtnombre)";



                comando.Parameters.Clear();

                comando.Parameters.Value("txtId", txtId.text);

                comando.Parameters.Value("txtNombre", txtNombre.Text);



                int NFilas = comando.ExecuteQuery();

                if (NFilas > 0)

                {



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

                txtId.Text = "";

                txtnombre.Text = "-";

                conexion();

                conexion.Dispose();




            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion();

            conexion.ConnectionString = @"Data Source=.;Initial Catalog=programacion; Integrated Security=True;";
        }
    }