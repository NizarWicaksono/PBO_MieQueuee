namespace MieQueuee.View
{
    partial class FormTransaksi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridViewKeranjang;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonBayar;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.TextBox txtNamaPelanggan;
        private System.Windows.Forms.Label labelNamaPelanggan;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxMenu = new ComboBox();
            textBoxJumlah = new TextBox();
            buttonTambah = new Button();
            dataGridViewKeranjang = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            labelTotal = new Label();
            buttonBayar = new Button();
            labelJudul = new Label();
            button1 = new Button();
            txtUserId = new TextBox();
            labelUserId = new Label();
            txtNamaPelanggan = new TextBox();
            labelNamaPelanggan = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKeranjang).BeginInit();
            SuspendLayout();
            // 
            // comboBoxMenu
            // 
            comboBoxMenu.Location = new Point(38, 88);
            comboBoxMenu.Margin = new Padding(4);
            comboBoxMenu.Name = "comboBoxMenu";
            comboBoxMenu.Size = new Size(249, 33);
            comboBoxMenu.TabIndex = 0;
            // 
            // textBoxJumlah
            // 
            textBoxJumlah.Location = new Point(312, 88);
            textBoxJumlah.Margin = new Padding(4);
            textBoxJumlah.Name = "textBoxJumlah";
            textBoxJumlah.Size = new Size(124, 31);
            textBoxJumlah.TabIndex = 1;
            // 
            // buttonTambah
            // 
            buttonTambah.Location = new Point(462, 88);
            buttonTambah.Margin = new Padding(4);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(125, 38);
            buttonTambah.TabIndex = 2;
            buttonTambah.Text = "Tambah";
            buttonTambah.Click += buttonTambah_Click;
            // 
            // dataGridViewKeranjang
            // 
            dataGridViewKeranjang.ColumnHeadersHeight = 34;
            dataGridViewKeranjang.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewKeranjang.Location = new Point(38, 150);
            dataGridViewKeranjang.Margin = new Padding(4);
            dataGridViewKeranjang.Name = "dataGridViewKeranjang";
            dataGridViewKeranjang.ReadOnly = true;
            dataGridViewKeranjang.RowHeadersWidth = 62;
            dataGridViewKeranjang.Size = new Size(625, 200);
            dataGridViewKeranjang.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Menu";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Harga";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Jumlah";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Total";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // labelTotal
            // 
            labelTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTotal.Location = new Point(38, 455);
            labelTotal.Margin = new Padding(4, 0, 4, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(368, 29);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total: Rp 0";
            // 
            // buttonBayar
            // 
            buttonBayar.Location = new Point(500, 448);
            buttonBayar.Margin = new Padding(4);
            buttonBayar.Name = "buttonBayar";
            buttonBayar.Size = new Size(162, 50);
            buttonBayar.TabIndex = 5;
            buttonBayar.Text = "Bayar";
            buttonBayar.Click += buttonBayar_Click;
            // 
            // labelJudul
            // 
            labelJudul.BackColor = Color.Transparent;
            labelJudul.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelJudul.Location = new Point(38, 25);
            labelJudul.Margin = new Padding(4, 0, 4, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(199, 52);
            labelJudul.TabIndex = 6;
            labelJudul.Text = "Transaksi";
            // 
            // button1
            // 
            button1.Location = new Point(500, 510);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(162, 38);
            button1.TabIndex = 7;
            button1.Text = "Kembali";
            button1.Click += button1_Click;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(200, 364);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(200, 31);
            txtUserId.TabIndex = 5;
            txtUserId.TextChanged += txtUserId_TextChanged;
            // 
            // labelUserId
            // 
            labelUserId.AutoSize = true;
            labelUserId.Location = new Point(38, 370);
            labelUserId.Name = "labelUserId";
            labelUserId.Size = new Size(70, 25);
            labelUserId.TabIndex = 4;
            labelUserId.Text = "User ID";
            // 
            // txtNamaPelanggan
            // 
            txtNamaPelanggan.Location = new Point(200, 407);
            txtNamaPelanggan.Name = "txtNamaPelanggan";
            txtNamaPelanggan.Size = new Size(250, 31);
            txtNamaPelanggan.TabIndex = 7;
            // 
            // labelNamaPelanggan
            // 
            labelNamaPelanggan.AutoSize = true;
            labelNamaPelanggan.Location = new Point(38, 410);
            labelNamaPelanggan.Name = "labelNamaPelanggan";
            labelNamaPelanggan.Size = new Size(146, 25);
            labelNamaPelanggan.TabIndex = 6;
            labelNamaPelanggan.Text = "Nama Pelanggan";
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 570);
            Controls.Add(comboBoxMenu);
            Controls.Add(textBoxJumlah);
            Controls.Add(buttonTambah);
            Controls.Add(dataGridViewKeranjang);
            Controls.Add(labelUserId);
            Controls.Add(txtUserId);
            Controls.Add(labelNamaPelanggan);
            Controls.Add(txtNamaPelanggan);
            Controls.Add(labelTotal);
            Controls.Add(buttonBayar);
            Controls.Add(labelJudul);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "FormTransaksi";
            Text = "FormTransaksi";
            ((System.ComponentModel.ISupportInitialize)dataGridViewKeranjang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
