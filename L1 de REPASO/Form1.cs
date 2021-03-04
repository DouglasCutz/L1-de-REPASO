using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1_de_REPASO
{
    
    public partial class Form1 : Form
    {
        List<Empleados> empleados = new List<Empleados>();
        public Form1()
        {
            InitializeComponent();
        }
        void Limpiar1()
        {
            tx_codigo.Text="";
            tx_nombre.Text="";
            tx_sueldohora.Text = "";
        }
        void Mostrar1()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados;
            dataGridView1.Refresh();
        }
        private void Guardar1(String archivo, String codi, String nom , String sal )
        {
            //Abrir el archivo: Write sobreescribe el archivo, Append agrega los datos al final del archivo
            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);
            //Usar el objeto para escribir al archivo, WriteLine, escribe linea por linea
            //Write escribe todo en la misma linea. En este ejemplo se hará un dato por cada línea
            //writer.WriteLine(texto);

             writer.WriteLine(codi);
             writer.WriteLine(nom);
             writer.WriteLine(sal);
            
            //Cerrar el archivo
            writer.Close();
        }


        private void btn_ingreso1_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados();

            if ((tx_codigo.Text != "") && (tx_nombre.Text != "") && (tx_sueldohora.Text != ""))
            {
                empleado.Codigo = Convert.ToInt16(tx_codigo.Text);
                empleado.Nombre = tx_nombre.Text;
                empleado.SueldoHora = System.Convert.ToSingle(tx_sueldohora.Text);
                empleados.Add(empleado);
               
                MessageBox.Show(" Agregado ");
                Mostrar1();
                Guardar1("Empleados.txt",tx_codigo.Text, tx_nombre.Text, tx_sueldohora.Text);
                Limpiar1();

            }
            else
                MessageBox.Show(" Por favor llene todos los campos");
        }
    }
}
