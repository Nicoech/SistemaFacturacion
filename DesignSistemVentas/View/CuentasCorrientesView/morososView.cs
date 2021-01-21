using DesignSistemVentas.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignSistemVentas.View.CuentasCorrientesView
{
    public partial class morososView : Form
    {
        cuentasCorrientesController _ccc;
        public morososView()
        {
            InitializeComponent();
            _ccc = new cuentasCorrientesController(this);
        }

        private void morososView_Load(object sender, EventArgs e)
        {
            _ccc.traigoMorosos();
        }

        private void dgvMorosos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in dgvMorosos.Rows)
            {

                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.SelectionBackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;

            }
        }
    }
}
