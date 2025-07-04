﻿namespace MieQueuee.View
{
    partial class FormUpdateMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.Button buttonSimpan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelNama = new Label();
            labelHarga = new Label();
            textBoxNama = new TextBox();
            textBoxHarga = new TextBox();
            buttonSimpan = new Button();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(30, 30);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(93, 20);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama Menu:";
            labelNama.Click += labelNama_Click;
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Location = new Point(30, 81);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(53, 20);
            labelHarga.TabIndex = 2;
            labelHarga.Text = "Harga:";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(170, 30);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(200, 27);
            textBoxNama.TabIndex = 1;
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(170, 78);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(200, 27);
            textBoxHarga.TabIndex = 3;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(225, 130);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(88, 45);
            buttonSimpan.TabIndex = 4;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // FormUpdateMenu
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(398, 267);
            Controls.Add(buttonSimpan);
            Controls.Add(textBoxHarga);
            Controls.Add(labelHarga);
            Controls.Add(textBoxNama);
            Controls.Add(labelNama);
            Name = "FormUpdateMenu";
            Text = "Update Menu";
            Load += FormUpdateMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}