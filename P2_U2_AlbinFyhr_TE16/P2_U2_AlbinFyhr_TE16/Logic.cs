using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace P2_U2_AlbinFyhr_TE16
{
    class Logic
    {
        //data
        static Dictionary<string, string> users = new Dictionary<string, string>();
        Dictionary<string, string> notes = new Dictionary<string, string>();

        //formatters
        BinaryFormatter bf = new BinaryFormatter();

        //form components
        ListBox lstBox;

        //current
        string currentPath = "C:\\";
        static string currentUser = "Default";

        //dir separate for app data
        string root = Application.StartupPath;

        //initialize logic
        public void Initialize(ListBox listBox)
        {
            //list with notes
            lstBox = listBox;

            //current dir + currentuser
            currentPath = Directory.GetCurrentDirectory() + "\\NoteApp\\" + currentUser;
            
            //create directory if not exist
            if (Directory.Exists(currentPath) == false)
            {
                Directory.CreateDirectory(currentPath);
            }

            //load existing notes
            LoadNotes();

            //load userdata
            if (File.Exists(root + "//User.data"))
            {
                try
                {
                    using (Stream usersData = File.Open(root + "//User.data", FileMode.Open))
                    {
                        users = (Dictionary<string, string>)bf.Deserialize(usersData);
                    }
                }
                catch
                {
                    MessageBox.Show("Error: Could not load usersdata. Please delete data and restart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //update listbox
            UpdateBox();
        }

        //clear and update listbox with notes
        public void UpdateBox()
        {
            lstBox.Items.Clear();
            //unselected listbox item
            lstBox.SelectedIndex = -1;
            //get files in userfolder
            string[] files = Directory.GetFiles(currentPath);
            foreach (string d in files)
            {
                //only load files with .data extension
                //remove extension, looks more nice
                if(Path.GetExtension(d) == ".data")
                {
                    lstBox.Items.Add(Path.GetFileNameWithoutExtension(d));
                }
            }
        }

        //create note with text and title
        public void CreateNote(string text, string title)
        {
            try
            {
                //title needs letters or digits
                bool correctInput = true;
                char[] titleChars = title.ToCharArray();
                foreach (char c in titleChars)
                {
                    //invalid input, error
                    if (char.IsLetterOrDigit(c) == false)
                    {
                        correctInput = false;
                        MessageBox.Show("Error: Invalid letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                if (correctInput)
                {
                    //if note already exists, remove it
                    if (notes.ContainsKey(title) == true)
                    {
                        notes.Remove(title);
                    }
                    //
                    notes.Add(title, text);
                    using (Stream stream = File.Open(currentPath + "\\" + title + ".data", FileMode.Create))
                    {
                        bf.Serialize(stream, title);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error: Could not add note", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //title in, notetext out
        public string ShowNote(string title)
        {
            string text = "Default";
            try
            {
                text = notes[title];
            }
            catch
            {
                MessageBox.Show("Error: Could process note", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return text;
        }

        //print note to txt file
        public void PrintNote(string title)
        {
            string text = notes[title];

            try
            {
                //if file already exist, delete
                if (File.Exists(currentPath + "\\" + title + ".txt"))
                {
                    File.Delete(currentPath + "\\" + title + ".txt");
                }
                //Create new txt file and write info
                using (StreamWriter sw = File.CreateText(currentPath + "\\" + title + ".txt"))
                {
                    sw.WriteLine(title);
                    sw.WriteLine(" ");
                    sw.WriteLine(text);
                }
            }
            catch
            {
                MessageBox.Show("Error: Could not print note", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete note
        public void DeleteNote(string str)
        {
            try
            {
                File.Delete(currentPath + "\\"+  str + ".data");
                UpdateBox();
                notes.Remove(str);
            }
            catch
            {
                MessageBox.Show("Error: Could not delete note", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //load notes
        void LoadNotes()
        {
            if (File.Exists(currentPath + "\\NoteData.info"))
            {
                try
                {
                    using (Stream stream = File.Open(currentPath + "\\NoteData.info", FileMode.Open))
                    {
                        notes = (Dictionary<string, string>)bf.Deserialize(stream);
                    }
                }
                catch
                {
                    MessageBox.Show("Error: Could not load notes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //save notes
        public void SaveNotes()
        {
            try
            {
                using (Stream stream = File.Open(currentPath + "\\NoteData.info", FileMode.Create))
                {
                    bf.Serialize(stream, notes);
                }
            }
            catch
            {
                MessageBox.Show("Error: Could not save notes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //user login
        public void UserLogin(string user, string password)
        {
            //load users
            if(File.Exists(root + "//User.data"))
            {
                try
                {
                    using (Stream usersData = File.Open(root + "//User.data", FileMode.Open))
                    {
                        users = (Dictionary<string, string>)bf.Deserialize(usersData);
                    }
                }
                catch
                {
                    MessageBox.Show("Error: Could not load userdata", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            //need correct username and password
            if (users.ContainsKey(user) && users[user] == password)
            {
                //user correct, make current user
                currentUser = user;
                //create noteform
                Form1 noteApp = new Form1
                {
                    Visible = true
                };
            }
            else
            {
                MessageBox.Show("Error: User does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //register new user
        public void UserRegister(string user, string password)
        {
            //need correct input
            bool correctInput = true;
            char[] userLetters = user.ToCharArray();
            //windows limit foldernames
            int limit = 40;
            //foldernames need letters or digits
            foreach(char c in userLetters)
            {
                //invalid input
                if(char.IsLetterOrDigit(c) == false)
                {
                    correctInput = false;
                    MessageBox.Show("Error: Invalid letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            //good input, create new user
            if(correctInput == true && userLetters.Length <= limit && user != "" && password != "" && users.ContainsKey(user) == false)
            {
                currentUser = user;
                Form1 noteApp = new Form1
                {
                    Visible = true
                };

                //try load and save new user
                try
                {
                    if (File.Exists(root + "//User.data"))
                    {
                        using (Stream usersData = File.Open(root + "//User.data", FileMode.Open))
                        {
                            //get userDictionary
                            users = (Dictionary<string, string>)bf.Deserialize(usersData);
                            //add user
                            users.Add(user, password);
                            //save new user
                            bf.Serialize(usersData, users);
                        }
                    }
                    else
                    {
                        using (Stream usersData = File.Create(root + "//User.data"))
                        {
                            //add user
                            users.Add(user, password);
                            //save new user
                            bf.Serialize(usersData, users);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error: Could not load or save userdata", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //open explorer, currentpath
        public void OpenExplorer()
        {
            Process.Start("explorer.exe", currentPath);
        }
    }
}