using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Reloaded.Injector;
using System.IO;

namespace BootJect
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private void Close(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void In(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = "c:\\";
                open.Filter = "Dll Cheats (*.dll)|*.dll";
                open.RestoreDirectory = true;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string fullPath = open.FileName;
                    string fileName = open.SafeFileName;
                    string path = fullPath.Replace(fileName, "");
                    try
                    {
                        Process[] proclist = Process.GetProcesses();
                        foreach (Process pr in proclist)
                        {
                            if (pr.ProcessName.StartsWith("Minecraft"))
                            {
                                Injector inj = new Injector(pr);
                                inj.Inject(fullPath);
                                inj.Dispose();
                                MessageBox.Show("DLL has been injected into Minecraft (using AutoConfig)", "BootJect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("An unexpected error occurred while injecting your dll, " + open.FileName + ". Try opening an issue on the BootJect GitHub page.", "Woag x1!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You didn't select an item from the dialog. Select a valid .dll file and try again!", "Woag x0!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("An unexpected, critical error occured. Please open an error on our GitHub page IMMEDIATELY.", "Woag x2!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
