using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2_Uppgift1
{
    public partial class ChooseMediaForm : Form
    {
        public ChooseMediaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //opens appropriate form to fill in details
            if (radBtnBook.Checked)
            {
                NewBook details = new NewBook();
                details.Show();
            }
            else if (radBtnNewsArticle.Checked)
            {
                NewNewsArticle details = new NewNewsArticle();
                details.Show();
            }
            else if (radBtnWebsite.Checked)
            {
                NewWebsite details = new NewWebsite();
                details.Show();
            }
            else if (radBtnGame.Checked)
            {
                NewVideoGame details = new NewVideoGame();
                details.Show();
            }
            Close();
        }
    }
}
