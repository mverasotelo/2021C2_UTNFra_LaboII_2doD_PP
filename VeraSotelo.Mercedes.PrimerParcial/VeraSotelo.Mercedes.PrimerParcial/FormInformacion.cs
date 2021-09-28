using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeraSotelo.Mercedes.PrimerParcial
{
    public partial class FormInformacion : Base
    {
        public FormInformacion()
        {
            InitializeComponent();
        }

        private void FormInformacion_Load(object sender, EventArgs e)
        {
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
