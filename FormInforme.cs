using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroExamen
{
    public partial class FormInforme : Form
    {
        private List<Movimiento> movimientos;   

        public FormInforme(List<Movimiento> movimientos)
        {
            InitializeComponent();
            this.movimientos = movimientos;
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridView1.Rows.Clear();
            foreach (var movimiento in movimientos)
            {
                dataGridView1.Rows.Add(movimiento.Fecha, movimiento.Hora, movimiento.Operacion,
                                    movimiento.Importe > 0 ? movimiento.Importe.ToString() : "",
                                    movimiento.Saldo);
            }
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            movimientos.Clear();
            CargarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Movimiento
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Operacion { get; set; }
        public decimal Importe { get; set; }
        public decimal Saldo { get; set; }
    }
}