namespace Esteganografia.Views
{
    partial class formHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.grpBxInfo = new System.Windows.Forms.GroupBox();
            this.lblImagename = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.cmbBxMode = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.radBtnFile = new System.Windows.Forms.RadioButton();
            this.radBtnText = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolStripCont = new System.Windows.Forms.ToolStripContainer();
            this.stStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStLblAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStLblText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStLblDetails = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitCont = new System.Windows.Forms.SplitContainer();
            this.richTxtBxSource = new System.Windows.Forms.RichTextBox();
            this.splitContExtra = new System.Windows.Forms.SplitContainer();
            this.picBxOrigin = new System.Windows.Forms.PictureBox();
            this.picBxMod = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.grpBxInfo.SuspendLayout();
            this.toolStripCont.BottomToolStripPanel.SuspendLayout();
            this.toolStripCont.ContentPanel.SuspendLayout();
            this.toolStripCont.SuspendLayout();
            this.stStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCont)).BeginInit();
            this.splitCont.Panel1.SuspendLayout();
            this.splitCont.Panel2.SuspendLayout();
            this.splitCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContExtra)).BeginInit();
            this.splitContExtra.Panel1.SuspendLayout();
            this.splitContExtra.Panel2.SuspendLayout();
            this.splitContExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMod)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxInfo
            // 
            this.grpBxInfo.Controls.Add(this.lblImagename);
            this.grpBxInfo.Controls.Add(this.btnImage);
            this.grpBxInfo.Controls.Add(this.btnChart);
            this.grpBxInfo.Controls.Add(this.cmbBxMode);
            this.grpBxInfo.Controls.Add(this.btnShow);
            this.grpBxInfo.Controls.Add(this.btnProcess);
            this.grpBxInfo.Controls.Add(this.lblFilename);
            this.grpBxInfo.Controls.Add(this.btnFile);
            this.grpBxInfo.Controls.Add(this.radBtnFile);
            this.grpBxInfo.Controls.Add(this.radBtnText);
            this.grpBxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxInfo.Location = new System.Drawing.Point(0, 70);
            this.grpBxInfo.Name = "grpBxInfo";
            this.grpBxInfo.Size = new System.Drawing.Size(1324, 90);
            this.grpBxInfo.TabIndex = 7;
            this.grpBxInfo.TabStop = false;
            this.grpBxInfo.Text = "Esteganografia";
            // 
            // lblImagename
            // 
            this.lblImagename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImagename.AutoSize = true;
            this.lblImagename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagename.Location = new System.Drawing.Point(611, 63);
            this.lblImagename.Name = "lblImagename";
            this.lblImagename.Size = new System.Drawing.Size(114, 18);
            this.lblImagename.TabIndex = 9;
            this.lblImagename.Text = "Nombre imagen";
            // 
            // btnImage
            // 
            this.btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(747, 14);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(115, 40);
            this.btnImage.TabIndex = 8;
            this.btnImage.Text = "IMAGEN";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnChart
            // 
            this.btnChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.Location = new System.Drawing.Point(908, 29);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(115, 40);
            this.btnChart.TabIndex = 7;
            this.btnChart.Text = "GRAFICA";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // cmbBxMode
            // 
            this.cmbBxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxMode.FormattingEnabled = true;
            this.cmbBxMode.Items.AddRange(new object[] {
            "Encriptar",
            "Desencriptar"});
            this.cmbBxMode.Location = new System.Drawing.Point(187, 37);
            this.cmbBxMode.Name = "cmbBxMode";
            this.cmbBxMode.Size = new System.Drawing.Size(121, 24);
            this.cmbBxMode.TabIndex = 6;
            this.cmbBxMode.SelectedIndexChanged += new System.EventHandler(this.cmbBxMode_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(1195, 29);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(115, 40);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "MOSTRAR";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(1031, 29);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(145, 40);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "INICIO";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(463, 27);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(114, 18);
            this.lblFilename.TabIndex = 3;
            this.lblFilename.Text = "Nombre archivo";
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(342, 29);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(115, 40);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "ARCHIVO";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // radBtnFile
            // 
            this.radBtnFile.AutoSize = true;
            this.radBtnFile.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnFile.Location = new System.Drawing.Point(90, 39);
            this.radBtnFile.Name = "radBtnFile";
            this.radBtnFile.Size = new System.Drawing.Size(93, 27);
            this.radBtnFile.TabIndex = 1;
            this.radBtnFile.Text = "Archivo";
            this.radBtnFile.UseVisualStyleBackColor = true;
            this.radBtnFile.CheckedChanged += new System.EventHandler(this.radBtnFile_CheckedChanged);
            // 
            // radBtnText
            // 
            this.radBtnText.AutoSize = true;
            this.radBtnText.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnText.Location = new System.Drawing.Point(12, 39);
            this.radBtnText.Name = "radBtnText";
            this.radBtnText.Size = new System.Drawing.Size(77, 27);
            this.radBtnText.TabIndex = 0;
            this.radBtnText.Text = "Texto";
            this.radBtnText.UseVisualStyleBackColor = true;
            this.radBtnText.CheckedChanged += new System.EventHandler(this.radBtnText_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1324, 70);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "ESTEGANOGRAFIA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripCont
            // 
            // 
            // toolStripCont.BottomToolStripPanel
            // 
            this.toolStripCont.BottomToolStripPanel.Controls.Add(this.stStrip);
            // 
            // toolStripCont.ContentPanel
            // 
            this.toolStripCont.ContentPanel.Controls.Add(this.splitCont);
            this.toolStripCont.ContentPanel.Size = new System.Drawing.Size(1324, 467);
            this.toolStripCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCont.Location = new System.Drawing.Point(0, 160);
            this.toolStripCont.Name = "toolStripCont";
            this.toolStripCont.Size = new System.Drawing.Size(1324, 521);
            this.toolStripCont.TabIndex = 8;
            this.toolStripCont.Text = "toolStripContainer1";
            // 
            // stStrip
            // 
            this.stStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.stStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStLblAuthor,
            this.toolStripStLblText,
            this.toolStripStLblDetails});
            this.stStrip.Location = new System.Drawing.Point(0, 0);
            this.stStrip.Name = "stStrip";
            this.stStrip.Size = new System.Drawing.Size(1324, 29);
            this.stStrip.TabIndex = 0;
            // 
            // toolStripStLblAuthor
            // 
            this.toolStripStLblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStLblAuthor.Name = "toolStripStLblAuthor";
            this.toolStripStLblAuthor.Size = new System.Drawing.Size(53, 23);
            this.toolStripStLblAuthor.Text = "Autor";
            this.toolStripStLblAuthor.Click += new System.EventHandler(this.toolStripStLblAuthor_Click);
            // 
            // toolStripStLblText
            // 
            this.toolStripStLblText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStLblText.Name = "toolStripStLblText";
            this.toolStripStLblText.Size = new System.Drawing.Size(1166, 23);
            this.toolStripStLblText.Spring = true;
            this.toolStripStLblText.Text = "Cantidad texto";
            this.toolStripStLblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStLblDetails
            // 
            this.toolStripStLblDetails.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStLblDetails.Name = "toolStripStLblDetails";
            this.toolStripStLblDetails.Size = new System.Drawing.Size(90, 23);
            this.toolStripStLblDetails.Text = "Porcentaje";
            // 
            // splitCont
            // 
            this.splitCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCont.Location = new System.Drawing.Point(0, 0);
            this.splitCont.Name = "splitCont";
            this.splitCont.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCont.Panel1
            // 
            this.splitCont.Panel1.Controls.Add(this.richTxtBxSource);
            // 
            // splitCont.Panel2
            // 
            this.splitCont.Panel2.Controls.Add(this.splitContExtra);
            this.splitCont.Size = new System.Drawing.Size(1324, 467);
            this.splitCont.SplitterDistance = 146;
            this.splitCont.TabIndex = 0;
            // 
            // richTxtBxSource
            // 
            this.richTxtBxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxSource.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxSource.Name = "richTxtBxSource";
            this.richTxtBxSource.Size = new System.Drawing.Size(1324, 146);
            this.richTxtBxSource.TabIndex = 0;
            this.richTxtBxSource.Text = "";
            this.richTxtBxSource.TextChanged += new System.EventHandler(this.richTxtBxSource_TextChanged);
            // 
            // splitContExtra
            // 
            this.splitContExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContExtra.Location = new System.Drawing.Point(0, 0);
            this.splitContExtra.Name = "splitContExtra";
            // 
            // splitContExtra.Panel1
            // 
            this.splitContExtra.Panel1.Controls.Add(this.picBxOrigin);
            // 
            // splitContExtra.Panel2
            // 
            this.splitContExtra.Panel2.Controls.Add(this.picBxMod);
            this.splitContExtra.Size = new System.Drawing.Size(1324, 317);
            this.splitContExtra.SplitterDistance = 653;
            this.splitContExtra.SplitterWidth = 15;
            this.splitContExtra.TabIndex = 0;
            // 
            // picBxOrigin
            // 
            this.picBxOrigin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBxOrigin.Location = new System.Drawing.Point(0, 0);
            this.picBxOrigin.Name = "picBxOrigin";
            this.picBxOrigin.Size = new System.Drawing.Size(653, 317);
            this.picBxOrigin.TabIndex = 0;
            this.picBxOrigin.TabStop = false;
            // 
            // picBxMod
            // 
            this.picBxMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBxMod.Location = new System.Drawing.Point(0, 0);
            this.picBxMod.Name = "picBxMod";
            this.picBxMod.Size = new System.Drawing.Size(656, 317);
            this.picBxMod.TabIndex = 0;
            this.picBxMod.TabStop = false;
            this.picBxMod.DoubleClick += new System.EventHandler(this.picBxMod_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Archivo de texto(*.txt)|*.txt";
            this.openFileDialog.InitialDirectory = "D:\\Drive UPP\\09_Cuatri\\Seguridad";
            this.openFileDialog.Title = "Esteganografia - Archivo";
            // 
            // openImageDialog
            // 
            this.openImageDialog.DefaultExt = "png";
            this.openImageDialog.Filter = "Imagen (*.png)|*.png|Imagen (*.jpg)|*.jpg";
            this.openImageDialog.InitialDirectory = "D:\\Drive UPP\\09_Cuatri\\Seguridad";
            this.openImageDialog.Title = "Esteganografia - Imagen";
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.DefaultExt = "png";
            this.saveImageDialog.FileName = "Image Mod";
            this.saveImageDialog.Filter = "Imagen (*.png)|*.png";
            this.saveImageDialog.InitialDirectory = "D:\\Drive UPP\\09_Cuatri\\Seguridad";
            this.saveImageDialog.Title = "Esteganografia - Imagen";
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 681);
            this.Controls.Add(this.toolStripCont);
            this.Controls.Add(this.grpBxInfo);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.grpBxInfo.ResumeLayout(false);
            this.grpBxInfo.PerformLayout();
            this.toolStripCont.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripCont.BottomToolStripPanel.PerformLayout();
            this.toolStripCont.ContentPanel.ResumeLayout(false);
            this.toolStripCont.ResumeLayout(false);
            this.toolStripCont.PerformLayout();
            this.stStrip.ResumeLayout(false);
            this.stStrip.PerformLayout();
            this.splitCont.Panel1.ResumeLayout(false);
            this.splitCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCont)).EndInit();
            this.splitCont.ResumeLayout(false);
            this.splitContExtra.Panel1.ResumeLayout(false);
            this.splitContExtra.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContExtra)).EndInit();
            this.splitContExtra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxInfo;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.ComboBox cmbBxMode;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.RadioButton radBtnFile;
        private System.Windows.Forms.RadioButton radBtnText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripContainer toolStripCont;
        private System.Windows.Forms.StatusStrip stStrip;
        private System.Windows.Forms.SplitContainer splitCont;
        private System.Windows.Forms.RichTextBox richTxtBxSource;
        private System.Windows.Forms.SplitContainer splitContExtra;
        private System.Windows.Forms.PictureBox picBxOrigin;
        private System.Windows.Forms.PictureBox picBxMod;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblAuthor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblDetails;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblImagename;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
    }
}