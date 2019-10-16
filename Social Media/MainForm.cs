using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Social_Media
{
    public partial class MainForm : Form
    {
        // Entry form for the application
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //When the form loads check for any saved profiles
            LoadExistingFiles();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Handler for exit button - check user wants to exit
                Application.Exit();
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // Handler for the go arrow button click - load the next form and the stats for selected account
            if (cbxHandle.Text != "") // If the cbx is empty, will be loading from tbx
            { // Load from file
                try
                {
                    DisplayForm df = new DisplayForm(this, cbxHandle.Text, false);
                    Hide();
                    df.Show();
                    
                }catch(Exception)
                {
                    // Catch any exceptions not caught by the display form
                    MessageBox.Show("Error loading the user from file! Please try again");
                }
            }
            else if (tbxHandle.Text!="")
            { //Load from api
                try
                {
                    DisplayForm df = new DisplayForm(this, tbxHandle.Text,true);
                    Hide();
                    df.Show();

                }
                catch (Exception)
                {
                    // Catch any exceptions not caught by the display form
                    MessageBox.Show("Error loading the user from twitter! Please try again");
                }

            }
            else
            { // User hasn't given any data to load - display error message
                MessageBox.Show("Please either select a saved screen name, or enter one to load!");
            }
           
            
        }
        public void LoadExistingFiles()
        {
            // Check if the saved files directory exists - if not create it to save future profiles (first program run or user deleted it/moved the program)
            if (Directory.Exists("../../../Saved Profiles/"))
            {
                // Get all the files in the saved profiles directory
                string[] sSavedFiles = Directory.GetFiles("../../../Saved Profiles/");
                // Clear the combobox - this is also called after the form is restored from the displayform closing (a new profile may be saved)
                cbxHandle.Items.Clear();
                // Add the files into the combo box to allow user to choose one
                foreach (string str in sSavedFiles)
                {
                    cbxHandle.Items.Add(Path.GetFileNameWithoutExtension(str));
                }
            }
            else
            {
                // Make the directory to save future files
                try
                {
                    Directory.CreateDirectory("../../../Saved Profiles/");
                }
                catch (IOException)
                {
                    MessageBox.Show("Error creating the save directory - files will not be saved, but the load from web functions of the program will still be usable.");
                }
                
            }
        }
        private void cbxHandle_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If a combobox item is selected, empty the text box as user can only load one or the other
            // This if is required to stop this event handler calling the other input's event handler, and clearing the input the user is trying to control
            if(cbxHandle.SelectedIndex!=-1)
                tbxHandle.Text = "";
        }

        private void tbxHandle_TextChanged(object sender, EventArgs e)
        {
            // If a textbox is typed in, empty the combo box as user can only load one or the other
            // This if is required to stop this event handler calling the other input's event handler, and clearing the input the user is trying to control
            if (tbxHandle.Text!="")
                cbxHandle.SelectedIndex = -1;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check the user wants to exit
            if (!(MessageBox.Show("Do you want to exit?", "Are you sure you want to Exit", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                //Cancel the formclosing event
                e.Cancel = true;
            }
            else
            {
                // Close the application, continuing event
            }
        }


    }
}
