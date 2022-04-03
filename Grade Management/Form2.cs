using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Grade_Management
{
    public partial class InfoForm : Form
    {
        Form opener;
        public InfoForm(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string dir = folder + "/data";
            if (Directory.Exists(dir))
            {
                Directory.SetCurrentDirectory(dir);
            }
            else
            {
                Directory.CreateDirectory(dir);
                File.Create("A1.gmmm");
                File.Create("A2.gmmm");
                File.Create("A3.gmmm");
                File.Create("A4.gmmm");
                File.Create("B1.gmmm");
                File.Create("B2.gmmm");
                File.Create("B3.gmmm");
                File.Create("B4.gmmm");
            }
        }
/*
        int SchoolName = 0;

            try
            {
                if (SchoolSelectCBox.Text == "East Lyme High School")
                {
                    SchoolName = 1;
                }
            }
            catch
            {

            }
        */
    }
}
