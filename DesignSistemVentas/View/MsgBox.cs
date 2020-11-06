using System;
using System.Windows.Forms;

namespace DesignSistemVentas.View
{
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
        }

        private void MsgBox_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            Icon_delay.Start();
            Icon.Enabled = true;
        }

        private void Icon_delay_Tick(object sender, EventArgs e)
        {
            Icon.Enabled = false;
            Icon_delay.Stop();
        }

        private void btnIngresoUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
