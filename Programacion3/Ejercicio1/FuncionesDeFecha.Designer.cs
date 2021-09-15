
namespace Ejercicio1
{
    partial class FuncionesDeFecha
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
            this.components = new System.ComponentModel.Container();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroDiaTextBox = new System.Windows.Forms.TextBox();
            this.NumeroMestextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AnioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HoraTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MesTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarDiastextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NuevaFechaConDiastextBox = new System.Windows.Forms.TextBox();
            this.NuevaFechaRestadatextBox = new System.Windows.Forms.TextBox();
            this.DiasARestartextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HoraLabel = new System.Windows.Forms.Label();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(161, 29);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(162, 20);
            this.FechaDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(456, 26);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(75, 23);
            this.EjecutarButton.TabIndex = 2;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número De Día:";
            // 
            // NumeroDiaTextBox
            // 
            this.NumeroDiaTextBox.Location = new System.Drawing.Point(161, 101);
            this.NumeroDiaTextBox.Name = "NumeroDiaTextBox";
            this.NumeroDiaTextBox.ReadOnly = true;
            this.NumeroDiaTextBox.Size = new System.Drawing.Size(214, 20);
            this.NumeroDiaTextBox.TabIndex = 4;
            // 
            // NumeroMestextBox
            // 
            this.NumeroMestextBox.Location = new System.Drawing.Point(161, 136);
            this.NumeroMestextBox.Name = "NumeroMestextBox";
            this.NumeroMestextBox.ReadOnly = true;
            this.NumeroMestextBox.Size = new System.Drawing.Size(214, 20);
            this.NumeroMestextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número De Mes:";
            // 
            // AnioTextBox
            // 
            this.AnioTextBox.Location = new System.Drawing.Point(161, 162);
            this.AnioTextBox.Name = "AnioTextBox";
            this.AnioTextBox.ReadOnly = true;
            this.AnioTextBox.Size = new System.Drawing.Size(214, 20);
            this.AnioTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año:";
            // 
            // HoraTextBox
            // 
            this.HoraTextBox.Location = new System.Drawing.Point(161, 197);
            this.HoraTextBox.Name = "HoraTextBox";
            this.HoraTextBox.ReadOnly = true;
            this.HoraTextBox.Size = new System.Drawing.Size(214, 20);
            this.HoraTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hora:";
            // 
            // MesTextBox
            // 
            this.MesTextBox.Location = new System.Drawing.Point(161, 234);
            this.MesTextBox.Name = "MesTextBox";
            this.MesTextBox.ReadOnly = true;
            this.MesTextBox.Size = new System.Drawing.Size(214, 20);
            this.MesTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mes en Letras:";
            // 
            // AgregarDiastextBox
            // 
            this.AgregarDiastextBox.Location = new System.Drawing.Point(161, 271);
            this.AgregarDiastextBox.Name = "AgregarDiastextBox";
            this.AgregarDiastextBox.Size = new System.Drawing.Size(46, 20);
            this.AgregarDiastextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Agregar días a la fecha:";
            // 
            // NuevaFechaConDiastextBox
            // 
            this.NuevaFechaConDiastextBox.Location = new System.Drawing.Point(213, 271);
            this.NuevaFechaConDiastextBox.Name = "NuevaFechaConDiastextBox";
            this.NuevaFechaConDiastextBox.ReadOnly = true;
            this.NuevaFechaConDiastextBox.Size = new System.Drawing.Size(162, 20);
            this.NuevaFechaConDiastextBox.TabIndex = 15;
            // 
            // NuevaFechaRestadatextBox
            // 
            this.NuevaFechaRestadatextBox.Location = new System.Drawing.Point(213, 297);
            this.NuevaFechaRestadatextBox.Name = "NuevaFechaRestadatextBox";
            this.NuevaFechaRestadatextBox.ReadOnly = true;
            this.NuevaFechaRestadatextBox.Size = new System.Drawing.Size(162, 20);
            this.NuevaFechaRestadatextBox.TabIndex = 18;
            // 
            // DiasARestartextBox
            // 
            this.DiasARestartextBox.Location = new System.Drawing.Point(161, 297);
            this.DiasARestartextBox.Name = "DiasARestartextBox";
            this.DiasARestartextBox.Size = new System.Drawing.Size(46, 20);
            this.DiasARestartextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Restar días a la fecha:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HoraLabel
            // 
            this.HoraLabel.AutoSize = true;
            this.HoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraLabel.Location = new System.Drawing.Point(630, 31);
            this.HoraLabel.Name = "HoraLabel";
            this.HoraLabel.Size = new System.Drawing.Size(52, 18);
            this.HoraLabel.TabIndex = 19;
            this.HoraLabel.Text = "label9";
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(161, 334);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.ReadOnly = true;
            this.EdadTextBox.Size = new System.Drawing.Size(214, 20);
            this.EdadTextBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Edad:";
            // 
            // FuncionesDeFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 368);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HoraLabel);
            this.Controls.Add(this.NuevaFechaRestadatextBox);
            this.Controls.Add(this.DiasARestartextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NuevaFechaConDiastextBox);
            this.Controls.Add(this.AgregarDiastextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MesTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HoraTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AnioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumeroMestextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumeroDiaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Name = "FuncionesDeFecha";
            this.Text = "FuncionesDeFecha";
            this.Load += new System.EventHandler(this.FuncionesDeFecha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumeroDiaTextBox;
        private System.Windows.Forms.TextBox NumeroMestextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HoraTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MesTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AgregarDiastextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NuevaFechaConDiastextBox;
        private System.Windows.Forms.TextBox NuevaFechaRestadatextBox;
        private System.Windows.Forms.TextBox DiasARestartextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label HoraLabel;
        private System.Windows.Forms.TextBox EdadTextBox;
        private System.Windows.Forms.Label label9;
    }
}