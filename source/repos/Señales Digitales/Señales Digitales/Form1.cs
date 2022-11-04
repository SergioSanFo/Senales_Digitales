using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Señales_Digitales
{
    public partial class Form1 : Form
    {
        string tiempo = "";
        int lectura = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmrGrafica.Enabled = false;
            chkGrafica.Checked = false;
            dgvLectura.Rows.Insert(0, "Hora", "Lectura");
            dgvLectura.SelectAll();
            DataObject datos = dgvLectura.GetClipboardContent();
            Clipboard.SetDataObject(datos, true);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkGrafica_CheckedChanged(object sender, EventArgs e)
        {
            tmrGrafica.Enabled = chkGrafica.Checked;
        }

        private void tmrGrafica_Tick(object sender, EventArgs e)
        {
            tiempo = DateTime.Now.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
            DataPoint dp = new DataPoint();
            dp.SetValueXY(tiempo, lectura);
            lblTiempo.Text = tiempo;
            if (chartSensor.Series[0].Points.Count == 10)
            {
                chartSensor.Series[0].Points.RemoveAt(0);
            }
            chartSensor.Series[0].Points.Add(dp);
            dgvLectura.Rows.Insert(0, tiempo, lectura.ToString());


        }
        private void PanelMensajes(int dato)
        {
            if (dato <= 350)
            {
                lblMensajes.BackColor = Color.YellowGreen;
                lblMensajes.Text = "Fria";
            }
            else if (dato > 350 && dato <= 800)
            {
                lblMensajes.BackColor = Color.Yellow;
                lblMensajes.Text = "Tibia";
            }
            else
            {
                lblMensajes.BackColor = Color.Red;
                lblMensajes.Text = "Caliente";
            }
        }

        private void vscSensor_Scroll(object sender, ScrollEventArgs e)
        {
            lectura = (1023 - vscSensor.Value);
            lblSensor.Text = lectura.ToString();
            PanelMensajes(lectura);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgvLectura.DefaultCellStyle.Font = new Font("Tahoma", 10);
            chartSensor.ChartAreas[0].AxisY.Minimum = 0;
            chartSensor.ChartAreas[0].AxisY.Maximum = 1023;
            chartSensor.Series["Lectura"].XValueMember = "Tiempo";
            chartSensor.Series["Lectura"].YValueMembers = "Lectura";
        }
    }
}
