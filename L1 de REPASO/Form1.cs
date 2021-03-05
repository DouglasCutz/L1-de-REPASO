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
        List<Asistencia> asistencias = new List<Asistencia>();
        List<Reporte> reportes = new List<Reporte>();

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
        void Limpiar2()
        {
            tx_codi2.Text = "";
            tx_horasmes.Text = "";
            tx_mes.Text = "";
        }
        void Mostrar2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = asistencias;
            dataGridView2.Refresh();
        }
        void Guardar2(String archivo, String codi, String horas, String mes)
        {
            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(codi);
            writer.WriteLine(horas);
            writer.WriteLine(mes);

            //Cerrar el archivo
            writer.Close();

        }
        void CargarEm(string filename)
        {
            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Un ciclo para leer el archivo hasta el final del archivo
            //Lo leído se va guardando en un control richTextBox
            while (reader.Peek() > -1)
            //Esta linea envía el texto leído a un control richTextBox, se puede cambiar para que
            //lo muestre en otro control por ejemplo un combobox
            {
                Empleados empleado = new Empleados();
                empleado.Codigo = Convert.ToInt32(reader.ReadLine());
                empleado.Nombre = reader.ReadLine();
                empleado.SueldoHora = float.Parse(reader.ReadLine());

                empleados.Add(empleado);
                    
            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();
        }
        void CargarAs(string filename)
        {
            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Un ciclo para leer el archivo hasta el final del archivo
            //Lo leído se va guardando en un control richTextBox
            while (reader.Peek() > -1)
            //Esta linea envía el texto leído a un control richTextBox, se puede cambiar para que
            //lo muestre en otro control por ejemplo un combobox
            {
                Asistencia asistencia = new Asistencia();

                asistencia.Codigo = Convert.ToInt32(reader.ReadLine());
                asistencia.HoraMes = Convert.ToInt32(reader.ReadLine());
                asistencia.Mes = reader.ReadLine();

                asistencias.Add(asistencia);


            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();

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
               
                MessageBox.Show(" Agregado correctamente");
                Mostrar1();
                Guardar1("Empleados.txt",tx_codigo.Text, tx_nombre.Text, tx_sueldohora.Text);
                Limpiar1();

            }
            else
                MessageBox.Show(" Por favor llene todos los campos");
        }

        private void Ingreso2_Click(object sender, EventArgs e)
        {
            Asistencia asistencia = new Asistencia();

            if ((tx_codi2.Text != "") && (tx_horasmes.Text != "") && (tx_mes.Text != ""))
            {
                asistencia.Codigo= Convert.ToInt16(tx_codi2.Text);
                asistencia.HoraMes = Convert.ToInt16(tx_horasmes.Text);
                asistencia.Mes = tx_mes.Text;

                asistencias.Add(asistencia);
                MessageBox.Show(" Agregado correctamente ");
                Mostrar2();
                Guardar2("Asistencias.txt", tx_codi2.Text, tx_horasmes.Text, tx_mes.Text);
                Limpiar2();
            }
            else
                MessageBox.Show(" Por favor llene todos los campos");
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            CargarEm("Empleados.txt");

            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Codigo";
            comboBox1.DataSource = null;
            comboBox1.DataSource = empleados;
            comboBox1.Refresh();

            CargarAs("Asistencias.txt");

            Mostrar1();
            Mostrar2();


        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            
           
            for (int i = 0; i < empleados.Count; i ++)
            {
                for (int j = 0; j < asistencias.Count; j++)
                {
                    if (empleados[i].Codigo == asistencias[j].Codigo)
                    {
                        Reporte r1 = new Reporte();

                        r1.Codigo = empleados[i].Codigo;
                        r1.Nombre = empleados[i].Nombre;
                        r1.Mes = asistencias[i].Mes;
                        r1.Salario = empleados[i].SueldoHora * asistencias[j].HoraMes;

                        reportes.Add(r1);

                    }
                }

            }
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = reportes;
            dataGridView3.Refresh();


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int codi = Convert.ToInt32(comboBox1.SelectedValue);

            Reporte reporte = reportes.Find(s => s.Codigo == codi);

            lab_nom.Text = reporte.Nombre;
            lab_mes.Text = reporte.Mes;
            lab_sueldo.Text = reporte.Salario.ToString();
        }
    }
}
