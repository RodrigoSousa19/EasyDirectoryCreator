﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyDirectoryCreator.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EasyDirectoryCreator
{
    public partial class frmPrincipal : Form
    {
        private string path = string.Empty;

        private enum CREATE_STATUS
        {
            OK,
            FALHA
        }

        private int quantityOk = 0;
        private int quantityNok = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void EnableTextBox()
        {
            txtBox.ReadOnly = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.lblDirectory.Text += folderBrowserDialog.SelectedPath;
                this.path = folderBrowserDialog.SelectedPath;

                EnableTextBox();
            }
        }

        private FolderScheme GetFolderTree()
        {
            try
            {
                List<string> folders = txtBox.Text.Split(';').ToList();

                FolderScheme folderScheme = new FolderScheme();

                CreateFolderTree(folders, folderScheme);

                return folderScheme;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void CreateFolderTree(List<string> folders, FolderScheme folderScheme)
        {
            foreach (var folder in folders)
            {
                FolderScheme scheme = new FolderScheme();
                string aux = "";

                if (folder.Contains("["))
                {
                    aux += folder;

                    string parent = aux.Split("[")[0];

                    scheme.FolderParent = parent;

                    int startIndex = aux.IndexOf("[");
                    int lastIndex = aux.LastIndexOf("]");

                    int substringSize = lastIndex - startIndex - 1;
                    aux = aux.Substring(startIndex + 1, substringSize);

                    List<string> childList = aux.Split(',').ToList();

                    CreateFolderTree(childList, scheme);

                    if (folderScheme.ChildFolders == null)
                        folderScheme.ChildFolders = new List<FolderScheme>();

                    folderScheme.ChildFolders.Add(scheme);
                }
                else
                {
                    scheme.FolderParent = folder;

                    folderScheme.ChildFolders.Add(scheme);
                }
            }
        }

        private void CreateFolders(FolderScheme folders, string path)
        {
            try
            {
                string currentPath = path;

                if (folders.FolderParent != null)
                {
                    string newDirectory = Path.Combine(path, folders.FolderParent);

                    currentPath = newDirectory;

                    if (!Directory.Exists(newDirectory))
                    {
                        Directory.CreateDirectory(newDirectory);
                        Log(CREATE_STATUS.OK, $"{folders.FolderParent} - Success!");
                    }
                    else
                        Log(CREATE_STATUS.OK, $"{folders.FolderParent} - Already Exists!");
                }

                if (folders.ChildFolders?.Count > 0)
                {
                    foreach (var folderChild in folders.ChildFolders)
                    {
                        CreateFolders(folderChild, currentPath);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Log(CREATE_STATUS status, string textLog)
        {
            switch (status)
            {
                case CREATE_STATUS.OK:
                    {
                        txtBoxLog.Text += textLog;
                        txtBoxLog.Text += System.Environment.NewLine + "====================";
                        quantityOk++;
                        break;
                    }
                case CREATE_STATUS.FALHA:
                    {
                        txtBoxLog.Text = textLog;
                        txtBoxLog.Text += System.Environment.NewLine + "====================";
                        quantityNok++;
                        break;
                    }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox.Text.Length > 0)
                {
                    CreateFolders(GetFolderTree(),path);
                }
                else
                {
                    MessageBox.Show("Insira ao menos uma (1) pasta na caixa de texto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(e.ToString(), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                if (txtBox.Text.EndsWith("["))
                {
                    txtBox.Text = txtBox.Text + "]";
                    txtBox.SelectionStart = txtBox.Text.Length - 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtBoxLog.Clear();
        }
    }
}