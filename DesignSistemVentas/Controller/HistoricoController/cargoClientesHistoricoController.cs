using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.View.HistoricoClientesFacturas;

namespace DesignSistemVentas.Controller.HistoricoController
{
    class cargoClientesHistoricoController
    {
        private cargoClienteHistorico _cch;
        private HistoricoClientesView _hcv;
        private historicoDao hDao = new historicoDao();

        public cargoClientesHistoricoController(cargoClienteHistorico cch)
        {
            _cch = cch;
        }

        public cargoClientesHistoricoController(HistoricoClientesView hcv)
        {
            _hcv = hcv;
        }
        public void traigoClientes()
        {
            hDao.searchClientes(_cch.dgvClientesHistorico);
        }


        public void bindDataCliente(HistoricoClientesView _hcv)
        {
            _hcv.txtDNICliente.Text = _cch.dgvClientesHistorico.CurrentRow.Cells[0].Value.ToString();
            _hcv.txtNombre.Text = _cch.dgvClientesHistorico.CurrentRow.Cells[1].Value.ToString() + " " + _cch.dgvClientesHistorico.CurrentRow.Cells[2].Value.ToString();

        }
    }
}
