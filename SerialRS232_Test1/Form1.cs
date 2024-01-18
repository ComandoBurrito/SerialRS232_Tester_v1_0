using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Threading;

namespace SerialRS232_Test1
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort; // Declaracion del puerto serial como objeto
        public Form1()
        {
            InitializeComponent();
            // Inicializa la instancia del SerialPort y configura el ComboBox con los puertos disponibles.
            CargarPuertosDisponibles();
            CargarBaudios();
            serialPort = new SerialPort();

            // Asociar el evento DataReceived al método serialPort_DataReceived
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
        }

        private void CargarPuertosDisponibles()
        {
            string[] puertos = SerialPort.GetPortNames();
            cbPorts.Items.AddRange(puertos);
        }

        private void CargarBaudios()
        {
            int[] baudios = { 9600, 19200, 38400, 57600, 115200 };

            // Convertir los enteros a objetos antes de agregar al ComboBox
            object[] baudiosObjects = baudios.Cast<object>().ToArray();
            cbBaudios.Items.AddRange(baudiosObjects);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (cbPorts.SelectedItem != null && cbBaudios.SelectedItem != null)
            {
                try
                {
                    serialPort.PortName = cbPorts.SelectedItem.ToString();
                    serialPort.BaudRate = (int)cbBaudios.SelectedItem;
                    serialPort.Open();

                    // Verificar si el puerto se ha abierto correctamente
                    if (serialPort.IsOpen)
                    {
                        MessageBox.Show("Conexión establecida correctamente.", "Conexión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Muestra el mensaje en un TextBox llamado txtStatus
                        textBoxStatus.Text = "Conexión establecida correctamente.";
                        textBoxStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        MessageBox.Show("Error al conectar: No se pudo abrir el puerto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Muestra un mensaje de error en el TextBox
                        textBoxStatus.Text = "Error al conectar: No se pudo abrir el puerto.";
                        textBoxStatus.ForeColor = Color.Red;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al conectar: " + "'PortName' no se puede establecer mientras el puerto está abierto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //ex.Message
                    // Muestra un mensaje de error en el TextBox
                    textBoxStatus.Text = "Error al conectar: " + "'PortName' no se puede establecer mientras el puerto está abierto."; //ex.Message
                    textBoxStatus.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Selecciona un puerto y velocidad de baudios antes de conectar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Muestra un mensaje de advertencia en el TextBox
                textBoxStatus.Text = "Selecciona un puerto y velocidad de baudios antes de conectar.";
                textBoxStatus.ForeColor = Color.Orange;
            }
        }


        private bool datosEnviados = false;
        // Declaración de la variable para almacenar el código DataMatrix
        //private string codigoDataMatrix = "+";
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen && !string.IsNullOrEmpty(txtDatos.Text))
            {
                try
                {
                    // Agrega un mensaje antes de enviar
                    txtDatosRecibidos.Text = "Enviando datos: " + txtDatos.Text;

                    // Aquí se utiliza el puerto y la velocidad de baudios configurados
                    serialPort.WriteLine(txtDatos.Text);

                    // Indica que los datos han sido enviados
                    datosEnviados = true;

                    MessageBox.Show("Datos enviados correctamente.", "Envío Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Asegúrate de que el puerto esté conectado y proporciona datos para enviar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Este evento se llama cuando se reciben datos en el puerto serial
            try
            {
                string datosRecibidos = serialPort.ReadLine(); // Lee una línea de datos

                // Puedes realizar algún procesamiento con los datos recibidos antes de mostrarlos
                // Por ahora, simplemente los mostramos en el TextBox llamado txtDatosRecibidos
                this.Invoke(new Action(() => { txtDatosRecibidos.Text = datosRecibidos; }));

                MessageBox.Show("Datos recibidos correctamente: " + datosRecibidos, "Recepción Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recibir datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Asegúrate de cerrar el puerto serial antes de cerrar la aplicación
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
