using System;
using System.Windows.Forms;

namespace MieQueuee.View
{
    public partial class FormTambahMenu : Form
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxNamaMenu;
        private TextBox textBoxHarga;
        private Label labelNama;
        private Label labelHarga;
        private Button buttonTambah;
        private void InitializeComponent()
        {
            textBoxNamaMenu = new TextBox();
            textBoxHarga = new TextBox();
            labelNama = new Label();
            labelHarga = new Label();
            buttonTambah = new Button();
            SuspendLayout();
            // 
            // textBoxNamaMenu
            // 
            textBoxNamaMenu.Location = new Point(170, 30);
            textBoxNamaMenu.Name = "textBoxNamaMenu";
            textBoxNamaMenu.Size = new Size(200, 27);
            textBoxNamaMenu.TabIndex = 1;
            textBoxNamaMenu.TextChanged += textBoxNamaMenu_TextChanged;
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(170, 78);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(200, 27);
            textBoxHarga.TabIndex = 3;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(30, 30);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(93, 20);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama Menu:";
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
            // buttonTambah
            // 
            buttonTambah.BackColor = SystemColors.HighlightText;
            buttonTambah.Location = new Point(225, 130);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(88, 45);
            buttonTambah.TabIndex = 4;
            buttonTambah.Text = "Tambah";
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // FormTambahMenu
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(398, 267);
            Controls.Add(labelNama);
            Controls.Add(textBoxNamaMenu);
            Controls.Add(labelHarga);
            Controls.Add(textBoxHarga);
            Controls.Add(buttonTambah);
            Name = "FormTambahMenu";
            Text = "Tambah Menu";
            Load += FormTambahMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

    }
}