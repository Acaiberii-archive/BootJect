﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;
using Reloaded.Injector;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Security.AccessControl;
using System.Runtime.InteropServices;

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
        private void Min(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
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
                    load.Text = "Busy...";
                    string fullPath = open.FileName;
                    string fileName = open.SafeFileName;
                    string path = fullPath.Replace(fileName, "");
                    try
                    {
                        Process[] proclist = Process.GetProcesses();
                        foreach (Process pr in proclist)
                        {
                            
                            if (pr.ProcessName.StartsWith(procname.Text.ToLower()))
                            {
                                // Code for converting string to lowercase above (^)
                                string procpath = pr.MainModule.FileName;
                                VibeCheck(fullPath);
                                procpt.Text = "[I] Injecting to:" + procpath;
                                Injector inj = new Injector(pr);
                                inj.Inject(fullPath);
                                inj.Dispose();
                                MessageBox.Show("DLL has been injected successfully and was detached from the process.", "DLL Injected.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load.Text = "Injected.";
                            }
                            else if (pr.ProcessName.StartsWith(procname.Text.ToUpper()))
                            {
                                // Code for converting string to uppercase above (^)
                                string procpath = pr.MainModule.FileName;
                                VibeCheck(fullPath);
                                procpt.Text = "[I] Injecting to:" + procpath;
                                Injector inj = new Injector(pr);
                                inj.Inject(fullPath);
                                inj.Dispose();
                                Console.WriteLine("[I] Process found, DLL injected.");
                                MessageBox.Show("DLL has been injected successfully and was detached from the process.", "DLL Injected.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load.Text = "Injected.";
                            }
                            else if (pr.ProcessName.StartsWith(procname.Text))
                            {
                                // Code for detecting regular name above (^)
                                string procpath = pr.MainModule.FileName;
                                VibeCheck(fullPath);
                                procpt.Text = "[I] Injecting to:" + procpath;
                                Injector inj = new Injector(pr);
                                inj.Inject(fullPath);
                                inj.Dispose();
                                Console.WriteLine("[I] Process found, DLL injected.");
                                MessageBox.Show("DLL has been injected successfully and was detached from the process.", "DLL Injected.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load.Text = "Injected.";
                            }
                            else if (pr.ProcessName.StartsWith(procname.Text.First().ToString().ToUpper() + procname.Text.Substring(1)))
                            {
                                // Code for converting first letter to uppercase above (^)
                                string procpath = pr.MainModule.FileName;
                                VibeCheck(fullPath);
                                procpt.Text = "[I] Injecting to:" +procpath;
                                Injector inj = new Injector(pr);
                                inj.Inject(fullPath);
                                inj.Dispose();
                                Console.WriteLine("[I] Process found, DLL injected.");
                                MessageBox.Show("DLL has been injected successfully and was detached from the process.", "DLL Injected.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load.Text = "Injected.";
                            }
                            else
                            {
                                Console.WriteLine("[I] " + pr.ToString() + " Skipped.");
                            }
                        }
                        if (autoexit.Checked == true)
                        {
                            string batchCommands = string.Empty;
                            string exeFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", string.Empty).Replace("/", "\\");
                            Console.WriteLine("[I] NoTrace on, this will delete the program. Goodbye!");
                            batchCommands += "@ECHO OFF\n";                         
                            batchCommands += "ping 127.0.0.1 > nul -n 3\n";           
                            batchCommands += "echo j | del /F ";                    
                            batchCommands += exeFileName + "\n";
                            batchCommands += "echo j | del ad.bat";
                            File.WriteAllText("ad.bat", batchCommands);
                            Process.Start("ad.bat");
                            foreach (string f in System.IO.Directory.GetFiles(System.Reflection.Assembly.GetEntryAssembly().Location, "*.xml"))
                            {
                                System.IO.File.Delete(f);
                            }
                            foreach (string f in System.IO.Directory.GetFiles(System.Reflection.Assembly.GetEntryAssembly().Location, "*.dll"))
                            {
                                System.IO.File.Delete(f);
                            }
                            Application.Exit();
                        }
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("An error occurred while injecting your dll, " + fileName + ". Try opening an issue on the BootJect GitHub page and report the log:" + er + ".", "Woag x1!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You didn't select an item from the dialog. Select a valid .dll file and try again!", "Woag x1!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("An unexpected, critical error occurred. Please open an error on our GitHub page and report the log: " + er, "Woag x2!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void main_Load(object sender, EventArgs e)
        {
            Console.WriteLine("[I] Main loaded");
        }
        private void VibeCheck(string path)
        {
            Console.WriteLine("[I] Preparing to vibe (giving file access to UWP applications)...");
            FileInfo f = new FileInfo(path);
            System.Security.AccessControl.FileSecurity fileSecurity = f.GetAccessControl();
            Console.WriteLine("[I] Vibing...");
            fileSecurity.AddAccessRule(new FileSystemAccessRule("ALL APPLICATION PACKAGES", FileSystemRights.FullControl, AccessControlType.Allow));
            try
            {
                f.SetAccessControl(fileSecurity);
                Console.WriteLine("[I] Vibe completed. UWP apps are compatible with the DLL: " + path);
                
            }
            catch (Exception er)
            {
                Console.WriteLine("[!] Vibe error. UWP apps will not be compatible with the DLL: " + path);
                MessageBox.Show("An unexpected, critical error occurred. Please open an error on our GitHub page and report the log: " + er, "Woag x2!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
