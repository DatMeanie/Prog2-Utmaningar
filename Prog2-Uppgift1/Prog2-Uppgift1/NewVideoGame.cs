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
    public partial class NewVideoGame : Form
    {
        Logic logic = new Logic();
        public NewVideoGame()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            logic.AddMedia(new VideoGame(txtBoxEngine.Text, txtBoxTitle.Text, txtBoxAuthor.Text, dateTimePickerRelease.Text, txtBoxGenre.Text, (long)numUpDownPrice.Value));
            Close();
        }
    }
}
