using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HexEditor
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog1;
        int searchPosition = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearForm();
            openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            openFileDialog1.RestoreDirectory = false;
        }


        #region methods

        private void clearForm()
        {
            this.Text = "HexEditor";
            lblAccessed.Text = "";
            lblBinary.Text = "";
            lblCompress.Text = "";
            lblCreated.Text = "";
            lblEncrypt.Text = "";
            lblHTTP.Text = "";
            lblShellEx.Text = "";
            lblDOSHeader.Text = "";
            lblSize.Text = "";
            txtHex.Text = "";
            txtText.Text = "";
            lblLang.Text = "UNKNOWN";
            pbBinary.Image = HexEditor.Properties.Resources.greenoff1;
            pbCompressed.Image = HexEditor.Properties.Resources.greenoff1;
            pbEncrypted.Image = HexEditor.Properties.Resources.greenoff1;
            pbHTTP.Image = HexEditor.Properties.Resources.greenoff1;
            pbShellex.Image = HexEditor.Properties.Resources.greenoff1;
            
        }

        private void openFile(string filename)
        {
            clearForm();

            string name = chkNull.whenNull(filename);

            if (chkNull.isNull(filename))
            {
                openFileDialog1.RestoreDirectory = false;
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                name = openFileDialog1.FileName;
            }

            this.Text = "HexEditor [" + name + "]";

            FileInfo f = new FileInfo(name);

            double len = 0;
            if (f.Length > 0)
                len = Math.Round((chkNull.numNull(f.Length) / 1024 / 1024), 2);

            // show file info
            lblSize.Text = len.ToString() + "MB";
            lblCreated.Text = f.CreationTime.ToShortDateString();
            lblAccessed.Text = f.LastAccessTime.ToShortDateString();

            FileAttributes attributes = File.GetAttributes(name);

            if ((attributes & FileAttributes.Compressed) == FileAttributes.Compressed)
            {
                lblCompress.Text = "YES";
                pbCompressed.Image = HexEditor.Properties.Resources.greenon1;
            }
            else if (f.Extension.ToUpper() == ".7Z")
            {
                lblCompress.Text = "YES";
                pbCompressed.Image = HexEditor.Properties.Resources.greenon1;
            }
            else
            {               
                lblCompress.Text = "NO";
            }

            if ((attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted)
            {
                lblEncrypt.Text = "YES";
                pbEncrypted.Image = HexEditor.Properties.Resources.greenon1;
            }
            else
                lblEncrypt.Text = "NO";

            // not sure loading the results in properties is great design
            FileUtils.Files fs = new FileUtils.Files();
            fs.processFile(name);

            // load the editors
            txtHex.Text = fs.theHex;
            string rawText = fs.theText.ToUpper();
            txtText.Text = fs.theText;

            // halfassed helper method
            lblBinary.Text = contains(rawText, ".BIN");
            lblHTTP.Text = contains(rawText, "HTTP");
            lblShellEx.Text = contains(rawText, "SHELL");
            lblDOSHeader.Text = GeneralTools.Left(rawText, 2);

            if(lblBinary.Text == "YES")
                pbBinary.Image = HexEditor.Properties.Resources.greenon1;

            if (lblHTTP.Text == "YES")
                pbHTTP.Image = HexEditor.Properties.Resources.greenon1;

            if (lblShellEx.Text == "YES")
                pbShellex.Image = HexEditor.Properties.Resources.greenon1;
          
            bool searchLang = name.ToUpper().IndexOf(".PDF") == -1;

            // if it's not a pdf, guess at the language by certain strings
            if (searchLang)
            {
                lblLang.Text = "UNKNOWN";
                if (rawText.Contains("CPP"))
                    lblLang.Text = "C++";
                else if (rawText.Contains("C++"))
                    lblLang.Text = "C++";
                else if (rawText.Contains("VBA"))
                    lblLang.Text = "VBA";
                else
                {
                    // look for the magic numbers in the header bytes
                    if (GeneralTools.Left(rawText, 2) == "MZ")
                        lblLang.Text = "DOS/PE EXE";
                    if (GeneralTools.Left(rawText, 2) == "PK")
                        lblCompress.Text = "YES";
                    if (GeneralTools.Left(rawText, 2) == "7Z")
                        lblCompress.Text = "YES";
                }
            }
        }

        private void findText(string val)
        {
            if (chkNull.isNull(val)) return;

            // Have to do searchPosition + 1 so it doesn't keep starting at the position it found
            // the last term (doesn't this thing have a findnext??). Adding 1 to the initial position 
            // doesn't hurt because the first few bytes are always the file header.
            searchPosition = txtText.Find(val, searchPosition + 1, RichTextBoxFinds.WholeWord);
            if (searchPosition == -1)
            {
                lblStatus.Text = "Search string not found or EOF";
                return;
            }

            scrollToTextPosition(searchPosition, val.Length);
        }

        private string contains(string src, string tofind)
        {
            if (src.Contains(tofind)) return "YES";
            return "NO";
        }


        private void scrollToTextPosition(int textPosition, int length)
        {
            // called by the search function, moves the caret to the next occurrence
            System.Drawing.Point newScrollLocation = txtText.AutoScrollOffset;
            if (textPosition <= txtText.TextLength)
            {
                txtText.SelectionStart = textPosition;
                txtText.ScrollToCaret();

                txtText.SelectionStart = textPosition;
                txtText.SelectionLength = length;
                txtText.SelectionBackColor = Color.Yellow;
            }

            txtText.AutoScrollOffset = newScrollLocation;
        }



        #endregion
       
        
        #region events

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            lblStatus.Text = "Processing";
            Application.DoEvents();

            string theFile = "";
            try
            {
                Attach.Attachment a = new Attach.Attachment();
                theFile = a.getOutlookAttachment(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            lblStatus.Text = "Reading File";
            Application.DoEvents();

            try
            {
                openFile(theFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            lblStatus.Text = "Ready";
            Application.DoEvents();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Reading File";
            Application.DoEvents();

            try
            {
                openFile("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            lblStatus.Text = "Ready";
            Application.DoEvents();
        }

        private void btnQuickHttp_Click(object sender, EventArgs e)
        {
            findText("http");
        }

        private void btnQuickBin_Click(object sender, EventArgs e)
        {
            findText("bin");
        }

        private void btnQuickShell_Click(object sender, EventArgs e)
        {
            findText("shell");
        }

        #endregion



    }
}
