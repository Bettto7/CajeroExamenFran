namespace CajeroAutomatico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label pantalla;
        private System.Windows.Forms.Button btnIntroducirTarjeta;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btnSD;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;

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

        /// <summary>
        /// Método necesario para admitir el Diseñador. No modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pantalla = new Label();
            btnIntroducirTarjeta = new Button();
            btnCS = new Button();
            btnSD = new Button();
            btnSalir = new Button();
            btnAceptar = new Button();
            btnRetirar = new Button();
            btnInforme = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // pantalla
            // 
            pantalla.BackColor = Color.Black;
            pantalla.BorderStyle = BorderStyle.FixedSingle;
            pantalla.Font = new Font("Arial", 14F, FontStyle.Bold);
            pantalla.ForeColor = Color.White;
            pantalla.Location = new Point(150, 50);
            pantalla.Name = "pantalla";
            pantalla.Size = new Size(500, 100);
            pantalla.TabIndex = 0;
            pantalla.Text = "Introduzca tarjeta";
            pantalla.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIntroducirTarjeta
            // 
            btnIntroducirTarjeta.Location = new Point(100, 350);
            btnIntroducirTarjeta.Name = "btnIntroducirTarjeta";
            btnIntroducirTarjeta.Size = new Size(150, 50);
            btnIntroducirTarjeta.TabIndex = 1;
            btnIntroducirTarjeta.Text = "Intr./Extr. tarjeta";
            btnIntroducirTarjeta.Click += btnIntroducirTarjeta_Click;
            // 
            // btnCS
            // 
            btnCS.Enabled = false;
            btnCS.Location = new Point(50, 50);
            btnCS.Name = "btnCS";
            btnCS.Size = new Size(50, 30);
            btnCS.TabIndex = 2;
            btnCS.Text = "CS";
            toolTip1.SetToolTip(btnCS, "consultarSaldo");
            btnCS.Click += btnCS_Click;
            // 
            // btnSD
            // 
            btnSD.Enabled = false;
            btnSD.Location = new Point(700, 50);
            btnSD.Name = "btnSD";
            btnSD.Size = new Size(50, 30);
            btnSD.TabIndex = 3;
            btnSD.Text = "SD";
            toolTip1.SetToolTip(btnSD, "SacarDinero");
            btnSD.Click += btnSD_Click;
            // 
            // btnSalir
            // 
            btnSalir.Enabled = false;
            btnSalir.Location = new Point(700, 100);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(50, 30);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "S";
            toolTip1.SetToolTip(btnSalir, "Salir");
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Location = new Point(425, 369);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(50, 50);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "->";
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Enabled = false;
            btnRetirar.Location = new Point(550, 350);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(150, 50);
            btnRetirar.TabIndex = 6;
            btnRetirar.Text = "Retirar dinero";
            btnRetirar.Click += btnRetirar_Click;
            // 
            // btnInforme
            // 
            btnInforme.Location = new Point(325, 425);
            btnInforme.Name = "btnInforme";
            btnInforme.Size = new Size(150, 50);
            btnInforme.TabIndex = 7;
            btnInforme.Text = "Informe";
            btnInforme.Click += btnInforme_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(313, 334);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 50);
            btn0.TabIndex = 8;
            btn0.Text = "0";
            btn0.Click += btnTeclado_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(313, 278);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.Click += btnTeclado_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(369, 278);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.Click += btnTeclado_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(425, 278);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.Click += btnTeclado_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(313, 222);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.Click += btnTeclado_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(369, 222);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.Click += btnTeclado_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(425, 222);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.Click += btnTeclado_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(313, 166);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 15;
            btn7.Text = "7";
            btn7.Click += btnTeclado_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(369, 166);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 16;
            btn8.Text = "8";
            btn8.Click += btnTeclado_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(425, 166);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.Click += btnTeclado_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(pantalla);
            Controls.Add(btnIntroducirTarjeta);
            Controls.Add(btnCS);
            Controls.Add(btnSD);
            Controls.Add(btnSalir);
            Controls.Add(btnAceptar);
            Controls.Add(btnRetirar);
            Controls.Add(btnInforme);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Cajero Automático";
            Load += Form1_Load;
            ResumeLayout(false);
        }
        private ToolTip toolTip1;
    }
}
