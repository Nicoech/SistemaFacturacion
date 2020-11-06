using DesignSistemVentas.Controller.FacturasController;
using DesignSistemVentas.Utilities;
using System;
using System.Windows.Forms;

namespace DesignSistemVentas.View.FacturasViews
{
    public partial class cargoProductosFactura : Form
    {
        private productosFacturaController _pf_ctr;

        private VistaFacturas _vistaf;


        public cargoProductosFactura(VistaFacturas vf)
        {
            _vistaf = vf;

            _pf_ctr = new productosFacturaController(this);

            InitializeComponent();
        }


        private void cargoProductosFactura_Load(object sender, EventArgs e)
        {

            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.VER_POSITIVE);
            _pf_ctr.traigoProductos();

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void dgvProductosFactura_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            _pf_ctr.bindDataProducto();


        }

        private void btnAgregoProductoFactura_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text != "") & (txtDescripcion.Text != "") & (txtPrecio.Text != ""))
            {
                if (txtCantidad.Text != "")
                {
                    if (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtStockActual.Text))
                    {
                        if (Convert.ToInt32(txtCantidad.Text) > 0)

                        {
                            if (_pf_ctr.descuentoCantidad() == true) {

                                _pf_ctr.agregoProductoFactura(_vistaf);

                                ActiveForm.Close();

                                _vistaf.btnEliminoProd.Enabled = true;
                            };


                        }
                        else
                        {
                            MessageBox.Show("NO POSEE STOCK DE ESTE PRODUCTO PARA AGREGARLO A LA FACTURA !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    else
                    {

                        MessageBox.Show("LA CANTIDAD QUE DESEA AGREGAR A LA FACTURA EXCEDE A LA DEL STOCK ACTUAL DISPONIBLE !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        _vistaf.btnEliminoProd.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("INGRESE UNA CANTIDAD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _vistaf.btnEliminoProd.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("CASILLEROS VACIOS!, SELECCIONE UN PRODUCTO POR FAVOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _vistaf.btnEliminoProd.Enabled = false;

            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            _pf_ctr.SoloNumeros(e);
        }

    }
}
