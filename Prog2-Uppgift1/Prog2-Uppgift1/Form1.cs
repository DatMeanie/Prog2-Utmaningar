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
    public partial class Form1 : Form
    {
        //variables
        Logic logic = new Logic();
        //variables used to prevent buttons functioning when they should not
        private bool edit = false;
        bool add = false;
        public bool Edit { get => edit; set => edit = value; }
        public bool Add { get => add; set => add = value; }

        public int currentSelected = -1;

        public Form1()
        {
            InitializeComponent();
            logic.Initialize(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //choose new media to add
            Add = true;
            ChooseMediaForm newChooseForm = new ChooseMediaForm();
            newChooseForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close app
            Close();
        }

        public void AddItemToBox(string name, bool edited, int index)
        {
            //if edit mode remove then add, otherwise only add
            if (edited)
            {
                listboxMedia.Items.RemoveAt(index);
                listboxMedia.Items.Insert(index, name);
            }
            else
            {
                listboxMedia.Items.Add(name);
            }
        }
        //used by logic class
        public void ShowError()
        {
            MessageBox.Show("Oops, error has occurred! Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            //safety
            if(listboxMedia.SelectedIndex != -1)
            {
                DetailForm detailForm = new DetailForm();
                //return info and change label in detail form
                detailForm.ChangeLabel(logic.ReturnMedia()[listboxMedia.SelectedIndex].ToString());
                detailForm.Show();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listboxMedia.SelectedIndex != -1 && !Edit)
            {
                logic.ReturnMedia().RemoveAt((listboxMedia.SelectedIndex));
                listboxMedia.Items.RemoveAt(listboxMedia.SelectedIndex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if not adding something
            if (!Add && listboxMedia.SelectedIndex != -1)
            {
                Edit = true;
                currentSelected = listboxMedia.SelectedIndex;
                //open appropriate form
                if (logic.ReturnMedia()[listboxMedia.SelectedIndex].GetType() == typeof(Book))
                {
                    NewBook details = new NewBook();
                    details.Show();
                }
                else if (logic.ReturnMedia()[listboxMedia.SelectedIndex].GetType() == typeof(Newsarticle))
                {
                    NewNewsArticle details = new NewNewsArticle();
                    details.Show();
                }
                else if (logic.ReturnMedia()[listboxMedia.SelectedIndex].GetType() == typeof(Website))
                {
                    NewWebsite details = new NewWebsite();
                    details.Show();
                }
                else if (logic.ReturnMedia()[listboxMedia.SelectedIndex].GetType() == typeof(VideoGame))
                {
                    NewVideoGame details = new NewVideoGame();
                    details.Show();
                }
            }
        }
    }
}
