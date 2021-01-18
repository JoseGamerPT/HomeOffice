using Retail2.Classes;
using Retail2.Managers;
using Retail2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeOffice.Forms.Admin
{
    public partial class CriarUser : MetroFramework.Forms.MetroForm
    {

        public CriarUser()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.FIRSTNAME = bunifuMaterialTextbox1.Text;
            u.LASTNAME = bunifuMaterialTextbox2.Text;
            u.PASSWORD = bunifuMaterialTextbox3.Text;
            u.ADRESS1 = bunifuMaterialTextbox4.Text;
            u.ADRESS2 = bunifuMaterialTextbox6.Text;
            u.CITY = bunifuMaterialTextbox6.Text;
            u.STATE = bunifuMaterialTextbox10.Text;
            u.FISCAL = Int32.Parse(bunifuMaterialTextbox9.Text);
            u.PHONE = bunifuMaterialTextbox8.Text;
            u.EMAIL = bunifuMaterialTextbox9.Text;
            u.INFO = bunifuMaterialTextbox11.Text;
            u.DATACONNECTION = Databases.getCon(20);
            u.DATECREATED = Time.get();

            UserManager.saveUser(u);

        }
    }
}
