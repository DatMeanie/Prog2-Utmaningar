using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_Uppgift1
{
    class Logic
    {
        //static variables to make every logic instance the same
        static List<Media> mediaList;
        static Form1 mainForm;
        //new list and get main form
        public void Initialize(Form1 main)
        {
            mediaList = new List<Media>();
            mainForm = main;
        }
        public void AddMedia(Media newMed)
        {
            //if it already exist
            bool exists = false;
            //if edit mode is active
            if (mainForm.Edit)
            {
                try
                {
                    //remove then add at index
                    mediaList.RemoveAt(mainForm.currentSelected);
                    mediaList.Insert(mainForm.currentSelected, newMed);
                    exists = true;
                }
                catch
                {
                    mainForm.ShowError();
                }
                mainForm.Edit = false;
            }
            //if edit mode was active it will not add again
            if (!exists)
            {
                mediaList.Add(newMed);
            }
            //is form1 still active
            mainForm.AddItemToBox(newMed.ReturnName(), exists, mainForm.currentSelected);
            //Add mode over
            mainForm.Add = false;
        }
        public List<Media> ReturnMedia()
        {
            return mediaList;
        }
    }
}
