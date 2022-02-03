namespace EncryptEnigma
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonGerarKey = new System.Windows.Forms.Button();
            this.checkBoxDocx = new System.Windows.Forms.CheckBox();
            this.checkBoxRtf = new System.Windows.Forms.CheckBox();
            this.checkBoxPsd = new System.Windows.Forms.CheckBox();
            this.checkBoxJpeg = new System.Windows.Forms.CheckBox();
            this.checkBoxPng = new System.Windows.Forms.CheckBox();
            this.checkBoxJpg = new System.Windows.Forms.CheckBox();
            this.checkBoxXls = new System.Windows.Forms.CheckBox();
            this.checkBoxPptx = new System.Windows.Forms.CheckBox();
            this.checkBoxPdf = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEncryptFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sair.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sair.Location = new System.Drawing.Point(378, 283);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.checkBoxDocx);
            this.panel1.Controls.Add(this.checkBoxRtf);
            this.panel1.Controls.Add(this.checkBoxPsd);
            this.panel1.Controls.Add(this.checkBoxJpeg);
            this.panel1.Controls.Add(this.checkBoxPng);
            this.panel1.Controls.Add(this.checkBoxJpg);
            this.panel1.Controls.Add(this.checkBoxXls);
            this.panel1.Controls.Add(this.checkBoxPptx);
            this.panel1.Controls.Add(this.checkBoxPdf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonEncryptFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 318);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.buttonGerarKey);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 318);
            this.panel2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(13, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 26);
            this.button4.TabIndex = 3;
            this.button4.Text = "Tutorial";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(13, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Importar chave";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(13, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exportar chave";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // buttonGerarKey
            // 
            this.buttonGerarKey.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonGerarKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGerarKey.FlatAppearance.BorderSize = 0;
            this.buttonGerarKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGerarKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerarKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGerarKey.Location = new System.Drawing.Point(13, 13);
            this.buttonGerarKey.Name = "buttonGerarKey";
            this.buttonGerarKey.Size = new System.Drawing.Size(121, 27);
            this.buttonGerarKey.TabIndex = 0;
            this.buttonGerarKey.Text = "Gerar Key";
            this.buttonGerarKey.UseVisualStyleBackColor = false;
            this.buttonGerarKey.Click += new System.EventHandler(this.ButtonGerarKey_Click);
            // 
            // checkBoxDocx
            // 
            this.checkBoxDocx.AutoSize = true;
            this.checkBoxDocx.FlatAppearance.BorderSize = 0;
            this.checkBoxDocx.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.checkBoxDocx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDocx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxDocx.Location = new System.Drawing.Point(181, 224);
            this.checkBoxDocx.Name = "checkBoxDocx";
            this.checkBoxDocx.Size = new System.Drawing.Size(59, 17);
            this.checkBoxDocx.TabIndex = 3;
            this.checkBoxDocx.Text = ".DOCX";
            this.checkBoxDocx.UseVisualStyleBackColor = true;
            this.checkBoxDocx.CheckedChanged += new System.EventHandler(this.CheckBoxDocx_CheckedChanged);
            // 
            // checkBoxRtf
            // 
            this.checkBoxRtf.AutoSize = true;
            this.checkBoxRtf.FlatAppearance.BorderSize = 0;
            this.checkBoxRtf.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.checkBoxRtf.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRtf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxRtf.Location = new System.Drawing.Point(181, 186);
            this.checkBoxRtf.Name = "checkBoxRtf";
            this.checkBoxRtf.Size = new System.Drawing.Size(48, 17);
            this.checkBoxRtf.TabIndex = 3;
            this.checkBoxRtf.Text = ".RTF";
            this.checkBoxRtf.UseVisualStyleBackColor = true;
            this.checkBoxRtf.CheckedChanged += new System.EventHandler(this.CheckBoxRtf_CheckedChanged);
            // 
            // checkBoxPsd
            // 
            this.checkBoxPsd.AutoSize = true;
            this.checkBoxPsd.FlatAppearance.BorderSize = 0;
            this.checkBoxPsd.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.checkBoxPsd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPsd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxPsd.Location = new System.Drawing.Point(375, 224);
            this.checkBoxPsd.Name = "checkBoxPsd";
            this.checkBoxPsd.Size = new System.Drawing.Size(50, 17);
            this.checkBoxPsd.TabIndex = 3;
            this.checkBoxPsd.Text = ".PSD";
            this.checkBoxPsd.UseVisualStyleBackColor = true;
            this.checkBoxPsd.CheckedChanged += new System.EventHandler(this.CheckBoxPsd_CheckedChanged);
            // 
            // checkBoxJpeg
            // 
            this.checkBoxJpeg.AutoSize = true;
            this.checkBoxJpeg.FlatAppearance.BorderSize = 0;
            this.checkBoxJpeg.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.checkBoxJpeg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJpeg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxJpeg.Location = new System.Drawing.Point(375, 186);
            this.checkBoxJpeg.Name = "checkBoxJpeg";
            this.checkBoxJpeg.Size = new System.Drawing.Size(55, 17);
            this.checkBoxJpeg.TabIndex = 3;
            this.checkBoxJpeg.Text = ".JPEG";
            this.checkBoxJpeg.UseVisualStyleBackColor = true;
            this.checkBoxJpeg.CheckedChanged += new System.EventHandler(this.CheckBoxJpeg_CheckedChanged);
            // 
            // checkBoxPng
            // 
            this.checkBoxPng.AutoSize = true;
            this.checkBoxPng.FlatAppearance.BorderSize = 0;
            this.checkBoxPng.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.checkBoxPng.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPng.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxPng.Location = new System.Drawing.Point(375, 146);
            this.checkBoxPng.Name = "checkBoxPng";
            this.checkBoxPng.Size = new System.Drawing.Size(53, 17);
            this.checkBoxPng.TabIndex = 3;
            this.checkBoxPng.Text = ".PNG";
            this.checkBoxPng.UseVisualStyleBackColor = true;
            this.checkBoxPng.CheckedChanged += new System.EventHandler(this.CheckBoxPng_CheckedChanged);
            // 
            // checkBoxJpg
            // 
            this.checkBoxJpg.AutoSize = true;
            this.checkBoxJpg.FlatAppearance.BorderSize = 0;
            this.checkBoxJpg.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.checkBoxJpg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJpg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxJpg.Location = new System.Drawing.Point(281, 224);
            this.checkBoxJpg.Name = "checkBoxJpg";
            this.checkBoxJpg.Size = new System.Drawing.Size(49, 17);
            this.checkBoxJpg.TabIndex = 3;
            this.checkBoxJpg.Text = ".JPG";
            this.checkBoxJpg.UseVisualStyleBackColor = true;
            this.checkBoxJpg.CheckedChanged += new System.EventHandler(this.CheckBoxJpg_CheckedChanged);
            // 
            // checkBoxXls
            // 
            this.checkBoxXls.AutoSize = true;
            this.checkBoxXls.FlatAppearance.BorderSize = 0;
            this.checkBoxXls.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.checkBoxXls.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxXls.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxXls.Location = new System.Drawing.Point(281, 186);
            this.checkBoxXls.Name = "checkBoxXls";
            this.checkBoxXls.Size = new System.Drawing.Size(48, 17);
            this.checkBoxXls.TabIndex = 3;
            this.checkBoxXls.Text = ".XLS";
            this.checkBoxXls.UseVisualStyleBackColor = true;
            this.checkBoxXls.CheckedChanged += new System.EventHandler(this.CheckBoxXls_CheckedChanged);
            // 
            // checkBoxPptx
            // 
            this.checkBoxPptx.AutoSize = true;
            this.checkBoxPptx.FlatAppearance.BorderSize = 0;
            this.checkBoxPptx.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.checkBoxPptx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPptx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxPptx.Location = new System.Drawing.Point(281, 146);
            this.checkBoxPptx.Name = "checkBoxPptx";
            this.checkBoxPptx.Size = new System.Drawing.Size(56, 17);
            this.checkBoxPptx.TabIndex = 3;
            this.checkBoxPptx.Text = ".PPTX";
            this.checkBoxPptx.UseVisualStyleBackColor = true;
            this.checkBoxPptx.CheckedChanged += new System.EventHandler(this.CheckBoxPptx_CheckedChanged);
            // 
            // checkBoxPdf
            // 
            this.checkBoxPdf.AutoSize = true;
            this.checkBoxPdf.FlatAppearance.BorderSize = 0;
            this.checkBoxPdf.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGreen;
            this.checkBoxPdf.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxPdf.Location = new System.Drawing.Point(181, 146);
            this.checkBoxPdf.Name = "checkBoxPdf";
            this.checkBoxPdf.Size = new System.Drawing.Size(50, 17);
            this.checkBoxPdf.TabIndex = 3;
            this.checkBoxPdf.Text = ".PDF";
            this.checkBoxPdf.UseVisualStyleBackColor = true;
            this.checkBoxPdf.CheckedChanged += new System.EventHandler(this.CheckBoxPdf_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(171, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "documento de texto para criptografar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(170, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gere uma chave e em seguida escolha um\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(295, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Descriptografar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // buttonEncryptFile
            // 
            this.buttonEncryptFile.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEncryptFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEncryptFile.FlatAppearance.BorderSize = 0;
            this.buttonEncryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncryptFile.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncryptFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEncryptFile.Location = new System.Drawing.Point(173, 91);
            this.buttonEncryptFile.Name = "buttonEncryptFile";
            this.buttonEncryptFile.Size = new System.Drawing.Size(105, 29);
            this.buttonEncryptFile.TabIndex = 0;
            this.buttonEncryptFile.Text = "Criptografar";
            this.buttonEncryptFile.UseVisualStyleBackColor = false;
            this.buttonEncryptFile.Click += new System.EventHandler(this.ButtonEncryptFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 318);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E.nygma";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEncryptFile;
        private System.Windows.Forms.Button buttonCreateAsmKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDocx;
        private System.Windows.Forms.CheckBox checkBoxRtf;
        private System.Windows.Forms.CheckBox checkBoxPsd;
        private System.Windows.Forms.CheckBox checkBoxJpeg;
        private System.Windows.Forms.CheckBox checkBoxPng;
        private System.Windows.Forms.CheckBox checkBoxJpg;
        private System.Windows.Forms.CheckBox checkBoxXls;
        private System.Windows.Forms.CheckBox checkBoxPptx;
        private System.Windows.Forms.CheckBox checkBoxPdf;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonGerarKey;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

