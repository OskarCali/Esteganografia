using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Esteganografia.Views
{
    public partial class formHome : Form
    {
        private int modo;
        private string text;
        private Functions.Esteganografia esteganografia;

        public formHome()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblFilename.Text = "";
            lblImagename.Text = "";
            toolStripStLblDetails.Text = "";
            toolStripStLblText.Text = "";

            radBtnText.Checked = true;
            btnProcess.Enabled = false;
            cmbBxMode.SelectedIndex = 0;

            splitContExtra.Panel2Collapsed = true;

            esteganografia = new Functions.Esteganografia();
        }

        private void radBtnText_CheckedChanged(object sender, EventArgs e)
        {
            btnFile.Enabled = false;

            richTxtBxSource.ReadOnly = false;
            richTxtBxSource.Text = "";

            lblFilename.Text = "";
        }

        private void radBtnFile_CheckedChanged(object sender, EventArgs e)
        {
            btnFile.Enabled = true;

            richTxtBxSource.ReadOnly = true;
            richTxtBxSource.Text = "";
        }

        private void cmbBxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;
            modo = cmb.SelectedIndex;

            switch (modo)
            {
                case 0:
                    richTxtBxSource.ReadOnly = false;
                    radBtnFile.Enabled = true;
                    radBtnText.Enabled = true;
                    splitContExtra.Panel2Collapsed = true;
                    break;
                case 1:
                    richTxtBxSource.ReadOnly = true;
                    radBtnFile.Enabled = false;
                    radBtnText.Enabled = false;
                    btnFile.Enabled = false;
                    lblFilename.Text = "";
                    btnProcess.Enabled = true;
                    richTxtBxSource.Text = "";
                    picBxOrigin.Image = null;
                    picBxMod.Image = null;
                    splitContExtra.Panel2Collapsed = true;
                    break;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                lblFilename.Text = openFileDialog.FileName;

                richTxtBxSource.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void toolStripStLblAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por: Óskar Calí\n\nNoviembre 2019", "ABOUT", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            toolStripStLblText.Text = "";
            toolStripStLblDetails.Text = "PROCESANDO...";
            Application.DoEvents();

            if (picBxOrigin.Image != null)
            {
                var image = new Bitmap(picBxOrigin.Image);

                switch (modo)
                {
                    case 0:
                        text = richTxtBxSource.Text;

                        var imgMod = esteganografia.ocultar(text, image);
                        picBxMod.Image = imgMod;

                        toolStripStLblText.Text = text.Length.ToString();
                        toolStripStLblDetails.Text = "caracter(es) encriptado(s)";
                        splitContExtra.Panel2Collapsed = false;
                        break;
                    case 1:
                        var msg = esteganografia.mostrar(image);
                        richTxtBxSource.Text = msg;

                        toolStripStLblText.Text = (msg.Length * 8).ToString();
                        toolStripStLblDetails.Text = "bit(s) desencriptado(s)";
                        break;
                }
            }
            else
            {
                toolStripStLblText.Text = "Verifique la imagen";
                toolStripStLblDetails.Text = "ERROR!!";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            splitContExtra.Panel2Collapsed = !splitContExtra.Panel2Collapsed;
            btnShow.Text = splitContExtra.Panel2Collapsed ? "MOSTRAR" : "OCULTAR";
        }

        private void richTxtBxSource_TextChanged(object sender, EventArgs e)
        {
            if (modo == 1)
            {
                btnProcess.Enabled = true;
                return;
            }

            if (!richTxtBxSource.Text.Equals(""))
            {
                btnProcess.Enabled = true;
                return;
            }

            btnProcess.Enabled = false;
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            if (picBxOrigin.Image != null)
            {
                formDetails details;
                Hide();
                if (picBxMod.Image != null)
                {
                    details = new formDetails(picBxOrigin.Image, picBxMod.Image);
                    details.ShowDialog(this);
                }
                else
                {
                    details = new formDetails(picBxOrigin.Image);
                    details.ShowDialog(this);
                }

                Show();
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog(this) == DialogResult.OK)
            {
                lblImagename.Text = openImageDialog.FileName;

                picBxOrigin.Image = Image.FromFile(openImageDialog.FileName);
            }
        }

        private void picBxMod_Click(object sender, EventArgs e)
        {
            if (saveImageDialog.ShowDialog(this) == DialogResult.OK)
            {
                var format = ImageFormat.Png;
                picBxMod.Image.Save(saveImageDialog.FileName, format);
            }
        }
    }
}