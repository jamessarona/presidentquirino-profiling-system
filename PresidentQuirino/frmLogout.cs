using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresidentQuirino
{
    public partial class frmLogout : Form
    {
        Template template;
        public frmLogout(Template template)
        {
            InitializeComponent();
            this.template = template;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            template.setValue("No");
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            template.setValue("Yes");
            this.Close();
        }
    }
}
