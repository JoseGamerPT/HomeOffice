using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeOffice
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(bunifuCircleProgressbar1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bunifuTransition1.Hide(bunifuCircleProgressbar1);

        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value = bunifuSlider1.Value;
        }
    }
}
