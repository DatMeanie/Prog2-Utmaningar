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
    public partial class NewBook : Form
    {
        Logic logic = new Logic();
        public NewBook()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //lägger till
            logic.AddMedia(new Book(txtBoxPublisher.Text, (int)numUpDownPages.Value, chkBoxPics.Checked, txtBoxTitle.Text, txtBoxAuthor.Text, dateTimePickerRelease.Text, txtBoxGenre.Text, (long)numUpDownPrice.Value));
            Close();
        }
    }
}
