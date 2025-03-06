using CajeroExamen;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        private enum EstadoCajero
        {
            IntroduzcaTarjeta,
            SeleccioneOperacion,
            ConsultarSaldo,
            SacarDinero1,
            SacarDinero2,
            Salir,
            Informe
        }

        private EstadoCajero estadoActual = EstadoCajero.IntroduzcaTarjeta;
        private int saldo = 1000;
        private int cantidadRetiro = 0;

        // Lista para guardar los movimientos
        private List<Movimiento> movimientos = new List<Movimiento>();
        public Form1()
        {
            InitializeComponent();
            ActualizarInterfaz();
        }

        private void ActualizarInterfaz()
        {
            // Desactivamos todos los botones numéricos y otros botones inicialmente
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;

            // Desactivamos todos los botones de operaciones al principio
            btnCS.Enabled = false;
            btnSD.Enabled = false;
            btnSalir.Enabled = false;
            btnRetirar.Enabled = false;
            btnAceptar.Enabled = false;

            // Habilitamos "Introducir tarjeta" e "Informe"
            btnInforme.Enabled = true;
            btnIntroducirTarjeta.Enabled = true;

            // Dependiendo del estado, actualizamos la pantalla
            switch (estadoActual)
            {
                case EstadoCajero.IntroduzcaTarjeta:
                    pantalla.Text = "Introduzca tarjeta";
                    break;

                case EstadoCajero.SeleccioneOperacion:
                    pantalla.Text = "Seleccione operación";
                    // Habilitamos los botones de CS, SD, S
                    btnCS.Enabled = true;
                    btnSD.Enabled = true;
                    btnSalir.Enabled = true;
                    btnIntroducirTarjeta.Enabled = false; // Desactivar "Introducir tarjeta"
                    break;

                case EstadoCajero.ConsultarSaldo:
                    pantalla.Text = $"Saldo disponible:\n{saldo} €";
                    btnSalir.Enabled = true; // Habilitamos "Salir"
                    break;

                case EstadoCajero.SacarDinero1:
                    pantalla.Text = "Ingrese cantidad y presione [->]";
                    btnAceptar.Enabled = true; // Habilitamos "->"
                    btnSalir.Enabled = true; // Habilitamos "Salir"
                    // Habilitamos los botones numéricos para introducir cantidad
                    btn0.Enabled = true;
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    btn4.Enabled = true;
                    btn5.Enabled = true;
                    btn6.Enabled = true;
                    btn7.Enabled = true;
                    btn8.Enabled = true;
                    btn9.Enabled = true;
                    break;

                case EstadoCajero.SacarDinero2:
                    pantalla.Text = $"Retirar {cantidadRetiro} €?";
                    btnRetirar.Enabled = true; // Habilitamos "Retirar dinero"
                    break;

                case EstadoCajero.Salir:
                    pantalla.Text = "Tarjeta retirada";
                    break;

                case EstadoCajero.Informe:
                    pantalla.Text = "Informe generado";
                    break;
            }
        }

        private void btnIntroducirTarjeta_Click(object sender, EventArgs e)
        {
            if (estadoActual == EstadoCajero.IntroduzcaTarjeta)
            {
                estadoActual = EstadoCajero.SeleccioneOperacion;
            }
            ActualizarInterfaz();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            if (estadoActual == EstadoCajero.SeleccioneOperacion)
            {
                estadoActual = EstadoCajero.ConsultarSaldo;



                // Agregar movimiento
                movimientos.Add(new Movimiento
                {
                    Fecha = DateTime.Now.ToString("yyyy-MM-dd"),
                    Hora = DateTime.Now.ToString("HH:mm:ss"),
                    Operacion = "Consultar saldo",
                    Importe = 0,
                    Saldo = saldo
                });

                ActualizarInterfaz();
            }
        }

        private void btnSD_Click(object sender, EventArgs e)
        {
            if (estadoActual == EstadoCajero.SeleccioneOperacion)
            {
                estadoActual = EstadoCajero.SacarDinero1;
                btnIntroducirTarjeta.Enabled = false; // Desactivamos "Introducir tarjeta"
                ActualizarInterfaz();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Al presionar "Salir", volvemos a "Seleccione operación"
            estadoActual = EstadoCajero.SeleccioneOperacion;
            ActualizarInterfaz();
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            if (estadoActual == EstadoCajero.SacarDinero1)
            {
                Button btn = sender as Button;
                if (btn != null)
                {
                    cantidadRetiro = cantidadRetiro * 10 + int.Parse(btn.Text);
                    pantalla.Text = $"Ingrese cantidad y presione [->]\n{cantidadRetiro} €";
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (estadoActual == EstadoCajero.SacarDinero1)
            {
                estadoActual = EstadoCajero.SacarDinero2;
                ActualizarInterfaz();
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (estadoActual == EstadoCajero.SacarDinero2 && cantidadRetiro > 0 && cantidadRetiro <= saldo)
            {
                saldo -= cantidadRetiro;

                // Agregar movimiento
                movimientos.Add(new Movimiento
                {
                    Fecha = DateTime.Now.ToString("yyyy-MM-dd"),
                    Hora = DateTime.Now.ToString("HH:mm:ss"),
                    Operacion = "Sacar dinero",
                    Importe = cantidadRetiro,
                    Saldo = saldo
                });

                estadoActual = EstadoCajero.SeleccioneOperacion;
                cantidadRetiro = 0;
            }
            else
            {
                pantalla.Text = "Saldo insuficiente o cantidad inválida";
            }
            ActualizarInterfaz();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Aquí va el código que quieras ejecutar cuando el formulario se cargue
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FormInforme informe = new FormInforme(movimientos);
            informe.ShowDialog();
        }


        // Descripción de los botones cuando el mouse pasa por encima
        private void btnCS_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnCS, "Consultar saldo");
        }

        private void btnSD_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnSD, "Sacar dinero");
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnSalir, "Salir");
        }
    }
}
