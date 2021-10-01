
namespace POO
{
    partial class CuentaBancaria
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
            this.AgregarMovimientoButton = new System.Windows.Forms.Button();
            this.CrearCuentaButton = new System.Windows.Forms.Button();
            this.MovimientosListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TipoMovimeintoComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MontoMovimientoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumeroCuentaTextBox = new System.Windows.Forms.TextBox();
            this.SaldoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdentidadClienteTextBox = new System.Windows.Forms.TextBox();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgregarMovimientoButton
            // 
            this.AgregarMovimientoButton.Location = new System.Drawing.Point(765, 162);
            this.AgregarMovimientoButton.Name = "AgregarMovimientoButton";
            this.AgregarMovimientoButton.Size = new System.Drawing.Size(115, 43);
            this.AgregarMovimientoButton.TabIndex = 13;
            this.AgregarMovimientoButton.Text = "Agregar Movimiento";
            this.AgregarMovimientoButton.UseVisualStyleBackColor = true;
            this.AgregarMovimientoButton.Click += new System.EventHandler(this.AgregarMovimientoButton_Click);
            // 
            // CrearCuentaButton
            // 
            this.CrearCuentaButton.Location = new System.Drawing.Point(765, 76);
            this.CrearCuentaButton.Name = "CrearCuentaButton";
            this.CrearCuentaButton.Size = new System.Drawing.Size(115, 43);
            this.CrearCuentaButton.TabIndex = 12;
            this.CrearCuentaButton.Text = "Crear Cuenta";
            this.CrearCuentaButton.UseVisualStyleBackColor = true;
            this.CrearCuentaButton.Click += new System.EventHandler(this.CrearCuentaButton_Click);
            // 
            // MovimientosListBox
            // 
            this.MovimientosListBox.FormattingEnabled = true;
            this.MovimientosListBox.ItemHeight = 16;
            this.MovimientosListBox.Location = new System.Drawing.Point(38, 224);
            this.MovimientosListBox.Name = "MovimientosListBox";
            this.MovimientosListBox.Size = new System.Drawing.Size(699, 212);
            this.MovimientosListBox.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TipoMovimeintoComboBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.MontoMovimientoTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(38, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(699, 61);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingresar Movimiento";
            // 
            // TipoMovimeintoComboBox
            // 
            this.TipoMovimeintoComboBox.FormattingEnabled = true;
            this.TipoMovimeintoComboBox.Items.AddRange(new object[] {
            "Depósito",
            "Retiro"});
            this.TipoMovimeintoComboBox.Location = new System.Drawing.Point(460, 22);
            this.TipoMovimeintoComboBox.Name = "TipoMovimeintoComboBox";
            this.TipoMovimeintoComboBox.Size = new System.Drawing.Size(225, 23);
            this.TipoMovimeintoComboBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipo Movimiento:";
            // 
            // MontoMovimientoTextBox
            // 
            this.MontoMovimientoTextBox.Location = new System.Drawing.Point(78, 23);
            this.MontoMovimientoTextBox.Name = "MontoMovimientoTextBox";
            this.MontoMovimientoTextBox.Size = new System.Drawing.Size(225, 21);
            this.MontoMovimientoTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NumeroCuentaTextBox);
            this.groupBox2.Controls.Add(this.SaldoTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(388, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 91);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saldo:";
            // 
            // NumeroCuentaTextBox
            // 
            this.NumeroCuentaTextBox.Location = new System.Drawing.Point(110, 23);
            this.NumeroCuentaTextBox.Name = "NumeroCuentaTextBox";
            this.NumeroCuentaTextBox.Size = new System.Drawing.Size(225, 21);
            this.NumeroCuentaTextBox.TabIndex = 2;
            // 
            // SaldoTextBox
            // 
            this.SaldoTextBox.Location = new System.Drawing.Point(110, 59);
            this.SaldoTextBox.Name = "SaldoTextBox";
            this.SaldoTextBox.ReadOnly = true;
            this.SaldoTextBox.Size = new System.Drawing.Size(225, 21);
            this.SaldoTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número Cuenta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IdentidadClienteTextBox);
            this.groupBox1.Controls.Add(this.NombreClienteTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // IdentidadClienteTextBox
            // 
            this.IdentidadClienteTextBox.Location = new System.Drawing.Point(78, 23);
            this.IdentidadClienteTextBox.Name = "IdentidadClienteTextBox";
            this.IdentidadClienteTextBox.Size = new System.Drawing.Size(225, 21);
            this.IdentidadClienteTextBox.TabIndex = 2;
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(78, 59);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(225, 21);
            this.NombreClienteTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad:";
            // 
            // CuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 486);
            this.Controls.Add(this.AgregarMovimientoButton);
            this.Controls.Add(this.CrearCuentaButton);
            this.Controls.Add(this.MovimientosListBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CuentaBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuentaBancaria";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AgregarMovimientoButton;
        private System.Windows.Forms.Button CrearCuentaButton;
        private System.Windows.Forms.ListBox MovimientosListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox TipoMovimeintoComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MontoMovimientoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumeroCuentaTextBox;
        private System.Windows.Forms.TextBox SaldoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdentidadClienteTextBox;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.Label label1;
    }
}