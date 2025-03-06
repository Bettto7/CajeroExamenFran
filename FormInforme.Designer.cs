namespace CajeroExamen
{
    partial class FormInforme
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
            


            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            fecha = new DataGridViewTextBoxColumn();
            hora = new DataGridViewTextBoxColumn();
            operacion = new DataGridViewTextBoxColumn();
            importe = new DataGridViewTextBoxColumn();
            saldo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fecha, hora, operacion, importe, saldo });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(764, 426);
            dataGridView1.TabIndex = 0;
           
            // 
            // button1
            // 
            button1.Location = new Point(348, 378);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Inicializar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // button2
            // 
            button2.Location = new Point(536, 378);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.btnCerrar_Click); 
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            fecha.Width = 125;
            // 
            // hora
            // 
            hora.HeaderText = "Hora";
            hora.MinimumWidth = 6;
            hora.Name = "hora";
            hora.ReadOnly = true;
            hora.Width = 125;
            // 
            // operacion
            // 
            operacion.HeaderText = "Operación";
            operacion.MinimumWidth = 6;
            operacion.Name = "operacion";
            operacion.ReadOnly = true;
            operacion.Width = 125;
            // 
            // importe
            // 
            importe.HeaderText = "Importe $";
            importe.MinimumWidth = 6;
            importe.Name = "importe";
            importe.ReadOnly = true;
            importe.Width = 125;
            // 
            // saldo
            // 
            saldo.HeaderText = "Saldo";
            saldo.MinimumWidth = 6;
            saldo.Name = "saldo";
            saldo.ReadOnly = true;
            saldo.Width = 125;
            // 
            // FormInforme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "FormInforme";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn hora;
        private DataGridViewTextBoxColumn operacion;
        private DataGridViewTextBoxColumn importe;
        private DataGridViewTextBoxColumn saldo;
    }
}