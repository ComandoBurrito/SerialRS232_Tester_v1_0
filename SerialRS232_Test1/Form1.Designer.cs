namespace SerialRS232_Test1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.cbBaudios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.madeBy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerSoftware = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(53, 35);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(173, 24);
            this.cbPorts.TabIndex = 1;
            // 
            // cbBaudios
            // 
            this.cbBaudios.FormattingEnabled = true;
            this.cbBaudios.Location = new System.Drawing.Point(53, 103);
            this.cbBaudios.Name = "cbBaudios";
            this.cbBaudios.Size = new System.Drawing.Size(173, 24);
            this.cbBaudios.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(50, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baudios:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar puerto:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Desconectar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(49, 35);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxStatus.Size = new System.Drawing.Size(243, 92);
            this.textBoxStatus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(46, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status:";
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(54, 279);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(121, 22);
            this.txtDatos.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(50, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "String a enviar:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(186, 274);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(99, 32);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtDatosRecibidos
            // 
            this.txtDatosRecibidos.Location = new System.Drawing.Point(49, 234);
            this.txtDatosRecibidos.Multiline = true;
            this.txtDatosRecibidos.Name = "txtDatosRecibidos";
            this.txtDatosRecibidos.Size = new System.Drawing.Size(243, 72);
            this.txtDatosRecibidos.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(46, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Datos recibidos:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnEnviar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDatos);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbBaudios);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbPorts);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(48, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 356);
            this.panel2.TabIndex = 16;
            // 
            // madeBy
            // 
            this.madeBy.AutoSize = true;
            this.madeBy.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.madeBy.Location = new System.Drawing.Point(456, 510);
            this.madeBy.Name = "madeBy";
            this.madeBy.Size = new System.Drawing.Size(399, 16);
            this.madeBy.TabIndex = 17;
            this.madeBy.Text = "Developed by Israel Betanzos Q - January, 2024 ©JJ Maquinados ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDatosRecibidos);
            this.panel1.Location = new System.Drawing.Point(459, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 356);
            this.panel1.TabIndex = 15;
            // 
            // headerSoftware
            // 
            this.headerSoftware.AutoSize = true;
            this.headerSoftware.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerSoftware.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerSoftware.Location = new System.Drawing.Point(38, 17);
            this.headerSoftware.Name = "headerSoftware";
            this.headerSoftware.Size = new System.Drawing.Size(515, 79);
            this.headerSoftware.TabIndex = 0;
            this.headerSoftware.Text = "RS-232 TESTER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SerialRS232_Test1.Properties.Resources.JJ_Maquinados_logo_INVERTIDO;
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(48, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 111);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.headerSoftware);
            this.panel4.Location = new System.Drawing.Point(252, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(589, 111);
            this.panel4.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(881, 535);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.madeBy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RS-232 Testing Machine v1_0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.ComboBox cbBaudios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtDatosRecibidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label madeBy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerSoftware;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

