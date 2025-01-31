﻿namespace WinHubX.Forms.Settaggi
{
    partial class FormRipristinoSO
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
            btnBack = new Button();
            btnSFC = new Button();
            btnDISM = new Button();
            btnEliminaDeallocati = new Button();
            btnStatoDisco = new Button();
            btnBios = new Button();
            btnVerificaRam = new Button();
            btnPuliziaUpdate = new Button();
            btnPuliziaCronologiaDef = new Button();
            btnSalvaDriver = new Button();
            btnStatoBatt = new Button();
            btnEliminaTempor = new Button();
            btnResetWinSxS = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.pngBackArrow;
            btnBack.Location = new Point(10, 9);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 41);
            btnBack.TabIndex = 41;
            btnBack.UseMnemonic = false;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSFC
            // 
            btnSFC.Cursor = Cursors.Hand;
            btnSFC.FlatAppearance.BorderSize = 0;
            btnSFC.FlatStyle = FlatStyle.Flat;
            btnSFC.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnSFC.ForeColor = Color.White;
            btnSFC.Location = new Point(73, 55);
            btnSFC.Margin = new Padding(3, 2, 3, 2);
            btnSFC.Name = "btnSFC";
            btnSFC.Size = new Size(287, 36);
            btnSFC.TabIndex = 42;
            btnSFC.Text = "Ripristina System32 con SFC";
            btnSFC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSFC.UseVisualStyleBackColor = true;
            btnSFC.Click += btnSFC_Click;
            // 
            // btnDISM
            // 
            btnDISM.Cursor = Cursors.Hand;
            btnDISM.FlatAppearance.BorderSize = 0;
            btnDISM.FlatStyle = FlatStyle.Flat;
            btnDISM.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnDISM.ForeColor = Color.White;
            btnDISM.Location = new Point(73, 95);
            btnDISM.Margin = new Padding(3, 2, 3, 2);
            btnDISM.Name = "btnDISM";
            btnDISM.Size = new Size(381, 36);
            btnDISM.TabIndex = 43;
            btnDISM.Text = "Ripristina Windows metodo DISM";
            btnDISM.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDISM.UseVisualStyleBackColor = true;
            btnDISM.Click += btnDISM_Click;
            // 
            // btnEliminaDeallocati
            // 
            btnEliminaDeallocati.Cursor = Cursors.Hand;
            btnEliminaDeallocati.FlatAppearance.BorderSize = 0;
            btnEliminaDeallocati.FlatStyle = FlatStyle.Flat;
            btnEliminaDeallocati.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnEliminaDeallocati.ForeColor = Color.White;
            btnEliminaDeallocati.Location = new Point(76, 132);
            btnEliminaDeallocati.Margin = new Padding(3, 2, 3, 2);
            btnEliminaDeallocati.Name = "btnEliminaDeallocati";
            btnEliminaDeallocati.Size = new Size(255, 32);
            btnEliminaDeallocati.TabIndex = 44;
            btnEliminaDeallocati.Text = "Elimina i file deallocati";
            btnEliminaDeallocati.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminaDeallocati.UseVisualStyleBackColor = true;
            btnEliminaDeallocati.Click += btnEliminaDeallocati_Click;
            // 
            // btnStatoDisco
            // 
            btnStatoDisco.Cursor = Cursors.Hand;
            btnStatoDisco.FlatAppearance.BorderSize = 0;
            btnStatoDisco.FlatStyle = FlatStyle.Flat;
            btnStatoDisco.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnStatoDisco.ForeColor = Color.White;
            btnStatoDisco.Location = new Point(70, 168);
            btnStatoDisco.Margin = new Padding(3, 2, 3, 2);
            btnStatoDisco.Name = "btnStatoDisco";
            btnStatoDisco.Size = new Size(290, 32);
            btnStatoDisco.TabIndex = 45;
            btnStatoDisco.Text = "Controlla stato SSD/HDD";
            btnStatoDisco.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatoDisco.UseVisualStyleBackColor = true;
            btnStatoDisco.Click += btnStatoDisco_Click;
            // 
            // btnBios
            // 
            btnBios.Cursor = Cursors.Hand;
            btnBios.FlatAppearance.BorderSize = 0;
            btnBios.FlatStyle = FlatStyle.Flat;
            btnBios.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnBios.ForeColor = Color.White;
            btnBios.Location = new Point(73, 204);
            btnBios.Margin = new Padding(3, 2, 3, 2);
            btnBios.Name = "btnBios";
            btnBios.Size = new Size(206, 35);
            btnBios.TabIndex = 46;
            btnBios.Text = "Vai nel BIOS";
            btnBios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBios.UseVisualStyleBackColor = true;
            btnBios.Click += btnBios_Click;
            // 
            // btnVerificaRam
            // 
            btnVerificaRam.Cursor = Cursors.Hand;
            btnVerificaRam.FlatAppearance.BorderSize = 0;
            btnVerificaRam.FlatStyle = FlatStyle.Flat;
            btnVerificaRam.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnVerificaRam.ForeColor = Color.White;
            btnVerificaRam.Location = new Point(73, 241);
            btnVerificaRam.Margin = new Padding(3, 2, 3, 2);
            btnVerificaRam.Name = "btnVerificaRam";
            btnVerificaRam.Size = new Size(265, 35);
            btnVerificaRam.TabIndex = 47;
            btnVerificaRam.Text = "Verifica integrita RAM";
            btnVerificaRam.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerificaRam.UseVisualStyleBackColor = true;
            btnVerificaRam.Click += btnVerificaRam_Click;
            // 
            // btnPuliziaUpdate
            // 
            btnPuliziaUpdate.Cursor = Cursors.Hand;
            btnPuliziaUpdate.FlatAppearance.BorderSize = 0;
            btnPuliziaUpdate.FlatStyle = FlatStyle.Flat;
            btnPuliziaUpdate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnPuliziaUpdate.ForeColor = Color.White;
            btnPuliziaUpdate.Location = new Point(73, 280);
            btnPuliziaUpdate.Margin = new Padding(3, 2, 3, 2);
            btnPuliziaUpdate.Name = "btnPuliziaUpdate";
            btnPuliziaUpdate.Size = new Size(274, 36);
            btnPuliziaUpdate.TabIndex = 48;
            btnPuliziaUpdate.Text = "Pulizia Windows Update";
            btnPuliziaUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPuliziaUpdate.UseVisualStyleBackColor = true;
            btnPuliziaUpdate.Click += btnPuliziaUpdate_Click;
            // 
            // btnPuliziaCronologiaDef
            // 
            btnPuliziaCronologiaDef.Cursor = Cursors.Hand;
            btnPuliziaCronologiaDef.FlatAppearance.BorderSize = 0;
            btnPuliziaCronologiaDef.FlatStyle = FlatStyle.Flat;
            btnPuliziaCronologiaDef.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnPuliziaCronologiaDef.ForeColor = Color.White;
            btnPuliziaCronologiaDef.Location = new Point(70, 320);
            btnPuliziaCronologiaDef.Margin = new Padding(3, 2, 3, 2);
            btnPuliziaCronologiaDef.Name = "btnPuliziaCronologiaDef";
            btnPuliziaCronologiaDef.Size = new Size(417, 36);
            btnPuliziaCronologiaDef.TabIndex = 49;
            btnPuliziaCronologiaDef.Text = "Pulizia Cronologia Windows Defender";
            btnPuliziaCronologiaDef.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPuliziaCronologiaDef.UseVisualStyleBackColor = true;
            btnPuliziaCronologiaDef.Click += btnPuliziaCronologiaDef_Click;
            // 
            // btnSalvaDriver
            // 
            btnSalvaDriver.Cursor = Cursors.Hand;
            btnSalvaDriver.FlatAppearance.BorderSize = 0;
            btnSalvaDriver.FlatStyle = FlatStyle.Flat;
            btnSalvaDriver.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnSalvaDriver.ForeColor = Color.White;
            btnSalvaDriver.Location = new Point(563, 56);
            btnSalvaDriver.Margin = new Padding(3, 2, 3, 2);
            btnSalvaDriver.Name = "btnSalvaDriver";
            btnSalvaDriver.Size = new Size(229, 35);
            btnSalvaDriver.TabIndex = 51;
            btnSalvaDriver.Text = "Salva i driver del PC";
            btnSalvaDriver.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvaDriver.UseVisualStyleBackColor = true;
            btnSalvaDriver.Click += btnSalvaDriver_Click;
            // 
            // btnStatoBatt
            // 
            btnStatoBatt.Cursor = Cursors.Hand;
            btnStatoBatt.FlatAppearance.BorderSize = 0;
            btnStatoBatt.FlatStyle = FlatStyle.Flat;
            btnStatoBatt.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnStatoBatt.ForeColor = Color.White;
            btnStatoBatt.Location = new Point(563, 96);
            btnStatoBatt.Margin = new Padding(3, 2, 3, 2);
            btnStatoBatt.Name = "btnStatoBatt";
            btnStatoBatt.Size = new Size(236, 35);
            btnStatoBatt.TabIndex = 52;
            btnStatoBatt.Text = "Verifica stato batteria";
            btnStatoBatt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatoBatt.UseVisualStyleBackColor = true;
            btnStatoBatt.Click += btnStatoBatt_Click;
            // 
            // btnEliminaTempor
            // 
            btnEliminaTempor.Cursor = Cursors.Hand;
            btnEliminaTempor.FlatAppearance.BorderSize = 0;
            btnEliminaTempor.FlatStyle = FlatStyle.Flat;
            btnEliminaTempor.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnEliminaTempor.ForeColor = Color.White;
            btnEliminaTempor.Location = new Point(564, 134);
            btnEliminaTempor.Margin = new Padding(3, 2, 3, 2);
            btnEliminaTempor.Name = "btnEliminaTempor";
            btnEliminaTempor.Size = new Size(267, 36);
            btnEliminaTempor.TabIndex = 53;
            btnEliminaTempor.Text = "Elimina i file temporanei";
            btnEliminaTempor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminaTempor.UseVisualStyleBackColor = true;
            btnEliminaTempor.Click += btnEliminaTempor_Click;
            // 
            // btnResetWinSxS
            // 
            btnResetWinSxS.Cursor = Cursors.Hand;
            btnResetWinSxS.FlatAppearance.BorderSize = 0;
            btnResetWinSxS.FlatStyle = FlatStyle.Flat;
            btnResetWinSxS.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnResetWinSxS.ForeColor = Color.White;
            btnResetWinSxS.Location = new Point(563, 174);
            btnResetWinSxS.Margin = new Padding(3, 2, 3, 2);
            btnResetWinSxS.Name = "btnResetWinSxS";
            btnResetWinSxS.Size = new Size(309, 32);
            btnResetWinSxS.TabIndex = 54;
            btnResetWinSxS.Text = "Ripristina la cartella WinSxS";
            btnResetWinSxS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetWinSxS.UseVisualStyleBackColor = true;
            btnResetWinSxS.Click += btnResetWinSxS_Click;
            // 
            // FormRipristinoSO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 38, 39);
            ClientSize = new Size(901, 428);
            Controls.Add(btnResetWinSxS);
            Controls.Add(btnEliminaTempor);
            Controls.Add(btnStatoBatt);
            Controls.Add(btnSalvaDriver);
            Controls.Add(btnPuliziaCronologiaDef);
            Controls.Add(btnPuliziaUpdate);
            Controls.Add(btnVerificaRam);
            Controls.Add(btnBios);
            Controls.Add(btnStatoDisco);
            Controls.Add(btnEliminaDeallocati);
            Controls.Add(btnDISM);
            Controls.Add(btnSFC);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormRipristinoSO";
            Text = "FormRipristinoSO";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnSFC;
        private Button btnDISM;
        private Button btnEliminaDeallocati;
        private Button btnStatoDisco;
        private Button btnBios;
        private Button btnVerificaRam;
        private Button btnPuliziaUpdate;
        private Button btnPuliziaCronologiaDef;
        private Button btnSalvaDriver;
        private Button btnStatoBatt;
        private Button btnEliminaTempor;
        private Button btnResetWinSxS;
    }
}