using DesignSistemVentas.Model.Dao;
using DesignSistemVentas.Utilities;
using DesignSistemVentas.View.CajaView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignSistemVentas.Controller.CajaController
{
    class agregoClientesMovimientoController
    {
        private CajaDao _cDao = new CajaDao();
        private agregarClienteMovimiento _acm;
        private cajaAgregar _ca;

        public agregoClientesMovimientoController(agregarClienteMovimiento acm)
        {
            _acm = acm;
        }
        
        public agregoClientesMovimientoController(cajaAgregar ca)
        {
            _ca = ca;
        }

        public void traigoClientesCaja()
        {
            _cDao.searchClientesCaja(_acm.dgvClientesCaja);
        }

        public void bindData(cajaAgregar _ca)
        {
            _ca.txtDescripcion.Text = _acm.dgvClientesCaja.CurrentRow.Cells[1].Value.ToString() +" "+ _acm.dgvClientesCaja.CurrentRow.Cells[2].Value.ToString() + " "+ _acm.dgvClientesCaja.CurrentRow.Cells[3].Value.ToString();
            _acm.Close(); 
        }
    }
}
