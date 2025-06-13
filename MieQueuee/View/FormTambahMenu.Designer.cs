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
            textBoxNamaMenu.Location = new Point(148, 20);
            textBoxNamaMenu.Name = "textBoxNamaMenu";
            textBoxNamaMenu.Size = new Size(150, 31);
            textBoxNamaMenu.TabIndex = 1;
            textBoxNamaMenu.TextChanged += textBoxNamaMenu_TextChanged;
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(148, 52);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(150, 31);
            textBoxHarga.TabIndex = 3;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(20, 20);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(113, 25);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama Menu:";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Location = new Point(20, 55);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(64, 25);
            labelHarga.TabIndex = 2;
            labelHarga.Text = "Harga:";
            // 
            // buttonTambah
            // 
            buttonTambah.Location = new Point(167, 89);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(100, 30);
            buttonTambah.TabIndex = 4;
            buttonTambah.Text = "Tambah";
            buttonTambah.Click += buttonTambah_Click;
            // 
            // FormTambahMenu
            // 
            ClientSize = new Size(442, 227);
            Controls.Add(labelNama);
            Controls.Add(textBoxNamaMenu);
            Controls.Add(labelHarga);
            Controls.Add(textBoxHarga);
            Controls.Add(buttonTambah);
            Name = "FormTambahMenu";
            Text = "Tambah Menu";
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
