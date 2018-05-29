using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForBD
{
    public partial class FormQuery3 : Form
    {
        public FormQuery3()
        {
            InitializeComponent();
        }

        private void FormQuery3_Load(object sender, EventArgs e)
        {
            this.enterpriseQueryTableAdapter.Fill(this.goodsDataSet.EnterpriseQuery);
        }
    }
}
