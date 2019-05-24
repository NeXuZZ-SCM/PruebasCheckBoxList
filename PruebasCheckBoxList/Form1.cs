using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasCheckBoxList
{
    public partial class Form1 : Form
    {
        List<entidadPermisos> listado;
        public Form1()
        {
            InitializeComponent();

            dgv_tabla.DataSource = conectarBase();

            conectarBase2();
            //rellenarCheckBoxList();

        }

        //private void rellenarCheckBoxList()
        //{
        //    var lista = conectarBase2();
        //    foreach (var item in lista)
        //    {
        //        checkedListBox1.SetItemChecked(item.permiso, true);
        //    }
            

        //}

        private DataTable conectarBase() {

            string connetionString = @"Data Source=.\SQLExpress;Initial Catalog=HelperLab0;Integrated Security=True;MultipleActiveResultSets=True";
            string consulta = "SELECT * FROM Permisos where nombre_usuario = 'cguazzin';";
            SqlDataAdapter adaptadorDeDatos = new SqlDataAdapter(consulta, connetionString);
            DataTable tablaDeDatos = new DataTable();
            adaptadorDeDatos.Fill(tablaDeDatos);
            return tablaDeDatos;
        }


        private void conectarBase2()
        {

            string connectionString = @"Data Source=.\SQLExpress;Initial Catalog=HelperLab0;Integrated Security=True;MultipleActiveResultSets=True";
            string queryString = "SELECT * FROM Permisos where nombre_usuario = 'cguazzin';";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            entidadPermisos entidad = new entidadPermisos();

            listado = new List<entidadPermisos>();
            while (reader.Read())
            {

                entidad.nombre = Convert.ToString(reader["nombre_usuario"]);
                entidad.permiso = Convert.ToInt32(reader["permiso"]);
                this.listado.Add(entidad);
                checkedListBox1.SetItemChecked(entidad.permiso-1, true);
            }

            //foreach (var item in listado)
            //{
            //    checkedListBox1.SetItemChecked(item.permiso, true);
            //}
        }
    }
}
