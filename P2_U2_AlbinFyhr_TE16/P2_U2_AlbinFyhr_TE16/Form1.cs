using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_U2_AlbinFyhr_TE16
{
    public partial class Form1 : Form
    {
        //logic
        Logic logic = new Logic();
        public Form1()
        {
            InitializeComponent();
            txtBoxNote.Text = " ";
            //initialize logic
            logic.Initialize(lstBoxShow);
        }

        //add note
        private void btnAdd_Click(object sender, EventArgs e)
        {
            logic.CreateNote(txtBoxAddNote.Text, txtBoxAddTitle.Text);
            logic.UpdateBox();
        }

        //delete note
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //listbox item needs to be selected
            if (lstBoxShow.SelectedIndex != -1)
            {
                logic.DeleteNote(lstBoxShow.Items[lstBoxShow.SelectedIndex].ToString());
                logic.UpdateBox();
            }
        }

        //save notes on exit
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            logic.SaveNotes();
        }

        //open explorer
        private void btnExplorer_Click(object sender, EventArgs e)
        {
            logic.OpenExplorer();
        }

        //print note
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //listbox item needs to be selected
            if (lstBoxShow.SelectedIndex != -1)
            {
                logic.PrintNote(lstBoxShow.Items[lstBoxShow.SelectedIndex].ToString());
            }
        }

        //change noteinfo based on new index
        private void lstBoxShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listbox item needs to be selected
            if (lstBoxShow.SelectedIndex != -1)
            {
                string text = logic.ShowNote(lstBoxShow.Items[lstBoxShow.SelectedIndex].ToString());

                txtBoxNote.Text = text;
                txtBoxTitle.Text = lstBoxShow.Items[lstBoxShow.SelectedIndex].ToString();
            }
        }

        //transfer from view to write
        private void btnTransfer_Click(object sender, EventArgs e)
        {
           txtBoxAddTitle.Text = txtBoxTitle.Text;
           txtBoxAddNote.Text = txtBoxNote.Text;
        }

        //error might mess up update box
        //safety button
        private void btnUpdateBox_Click(object sender, EventArgs e)
        {
            logic.UpdateBox();
        }
    }
}
