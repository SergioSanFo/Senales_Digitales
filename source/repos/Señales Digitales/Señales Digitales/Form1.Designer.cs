namespace Señales_Digitales
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.chartSensor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvLectura = new System.Windows.Forms.DataGridView();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lectura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vscSensor = new System.Windows.Forms.VScrollBar();
            this.chkGrafica = new System.Windows.Forms.CheckBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.lblSensor = new System.Windows.Forms.Label();
            this.tmrGrafica = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCopiar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Location = new System.Drawing.Point(338, 453);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(107, 37);
            this.btnCopiar.TabIndex = 0;
            this.btnCopiar.Text = "Copiar Lectura";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartSensor
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSensor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSensor.Legends.Add(legend1);
            this.chartSensor.Location = new System.Drawing.Point(12, 12);
            this.chartSensor.Name = "chartSensor";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Lectura";
            this.chartSensor.Series.Add(series1);
            this.chartSensor.Size = new System.Drawing.Size(631, 300);
            this.chartSensor.TabIndex = 1;
            // 
            // dgvLectura
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLectura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLectura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLectura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tiempo,
            this.Lectura});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLectura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLectura.Location = new System.Drawing.Point(12, 328);
            this.dgvLectura.Name = "dgvLectura";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLectura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLectura.Size = new System.Drawing.Size(242, 171);
            this.dgvLectura.TabIndex = 2;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            // 
            // Lectura
            // 
            this.Lectura.HeaderText = "Lectura";
            this.Lectura.Name = "Lectura";
            // 
            // vscSensor
            // 
            this.vscSensor.LargeChange = 1;
            this.vscSensor.Location = new System.Drawing.Point(668, 41);
            this.vscSensor.Maximum = 1023;
            this.vscSensor.Name = "vscSensor";
            this.vscSensor.Size = new System.Drawing.Size(85, 271);
            this.vscSensor.TabIndex = 3;
            this.vscSensor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vscSensor_Scroll);
            // 
            // chkGrafica
            // 
            this.chkGrafica.AutoSize = true;
            this.chkGrafica.Location = new System.Drawing.Point(545, 463);
            this.chkGrafica.Name = "chkGrafica";
            this.chkGrafica.Size = new System.Drawing.Size(98, 17);
            this.chkGrafica.TabIndex = 4;
            this.chkGrafica.Text = "Activar Lectura";
            this.chkGrafica.UseVisualStyleBackColor = true;
            this.chkGrafica.CheckedChanged += new System.EventHandler(this.chkGrafica_CheckedChanged);
            // 
            // lblTiempo
            // 
            this.lblTiempo.BackColor = System.Drawing.Color.Black;
            this.lblTiempo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTiempo.Location = new System.Drawing.Point(335, 328);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(288, 44);
            this.lblTiempo.TabIndex = 5;
            this.lblTiempo.Text = "...";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensajes
            // 
            this.lblMensajes.BackColor = System.Drawing.Color.Chartreuse;
            this.lblMensajes.Location = new System.Drawing.Point(335, 372);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(288, 42);
            this.lblMensajes.TabIndex = 6;
            this.lblMensajes.Text = "...";
            this.lblMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensajes.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSensor
            // 
            this.lblSensor.Location = new System.Drawing.Point(665, 12);
            this.lblSensor.Name = "lblSensor";
            this.lblSensor.Size = new System.Drawing.Size(88, 23);
            this.lblSensor.TabIndex = 7;
            this.lblSensor.Text = "...";
            this.lblSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrGrafica
            // 
            this.tmrGrafica.Interval = 1000;
            this.tmrGrafica.Tick += new System.EventHandler(this.tmrGrafica_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 511);
            this.Controls.Add(this.lblSensor);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.chkGrafica);
            this.Controls.Add(this.vscSensor);
            this.Controls.Add(this.dgvLectura);
            this.Controls.Add(this.chartSensor);
            this.Controls.Add(this.btnCopiar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensor;
        private System.Windows.Forms.DataGridView dgvLectura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lectura;
        private System.Windows.Forms.VScrollBar vscSensor;
        private System.Windows.Forms.CheckBox chkGrafica;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.Label lblSensor;
        private System.Windows.Forms.Timer tmrGrafica;
    }
}

