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
            txtNamaPelanggan = new TextBox();
            labelNamaPelanggan = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKeranjang).BeginInit();
            SuspendLayout();
            // 
            // comboBoxMenu
            // 
            comboBoxMenu.Location = new Point(31, 71);
            comboBoxMenu.Name = "comboBoxMenu";
            comboBoxMenu.Size = new Size(201, 28);
            comboBoxMenu.TabIndex = 0;
            // 
            // textBoxJumlah
            // 
            textBoxJumlah.Location = new Point(249, 71);
            textBoxJumlah.Name = "textBoxJumlah";
            textBoxJumlah.Size = new Size(100, 27);
            textBoxJumlah.TabIndex = 1;
            // 
            // buttonTambah
            // 
            buttonTambah.Location = new Point(369, 71);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(101, 31);
            buttonTambah.TabIndex = 2;
            buttonTambah.Text = "Tambah";
            buttonTambah.Click += buttonTambah_Click;
            // 
            // dataGridViewKeranjang
            // 
            dataGridViewKeranjang.ColumnHeadersHeight = 34;
            dataGridViewKeranjang.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewKeranjang.Location = new Point(31, 120);
            dataGridViewKeranjang.Name = "dataGridViewKeranjang";
            dataGridViewKeranjang.ReadOnly = true;
            dataGridViewKeranjang.RowHeadersWidth = 62;
            dataGridViewKeranjang.Size = new Size(501, 160);
            dataGridViewKeranjang.TabIndex = 3;
            dataGridViewKeranjang.CellContentClick += dataGridViewKeranjang_CellContentClick;
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
            labelTotal.Location = new Point(31, 364);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(295, 23);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total: Rp 0";
            // 
            // buttonBayar
            // 
            buttonBayar.Location = new Point(400, 359);
            buttonBayar.Name = "buttonBayar";
            buttonBayar.Size = new Size(129, 40);
            buttonBayar.TabIndex = 5;
            buttonBayar.Text = "Bayar";
            buttonBayar.Click += buttonBayar_Click;
            // 
            // labelJudul
            // 
            labelJudul.BackColor = Color.Transparent;
            labelJudul.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelJudul.Location = new Point(31, 20);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(159, 41);
            labelJudul.TabIndex = 6;
            labelJudul.Text = "Transaksi";
            // 
            // button1
            // 
            button1.Location = new Point(400, 408);
            button1.Name = "button1";
            button1.Size = new Size(129, 31);
            button1.TabIndex = 7;
            button1.Text = "Kembali";
            button1.Click += button1_Click;
            // 
            // txtNamaPelanggan
            // 
            txtNamaPelanggan.Location = new Point(160, 325);
            txtNamaPelanggan.Margin = new Padding(2, 3, 2, 3);
            txtNamaPelanggan.Name = "txtNamaPelanggan";
            txtNamaPelanggan.Size = new Size(201, 27);
            txtNamaPelanggan.TabIndex = 7;
            // 
            // labelNamaPelanggan
            // 
            labelNamaPelanggan.AutoSize = true;
            labelNamaPelanggan.Location = new Point(31, 328);
            labelNamaPelanggan.Margin = new Padding(2, 0, 2, 0);
            labelNamaPelanggan.Name = "labelNamaPelanggan";
            labelNamaPelanggan.Size = new Size(122, 20);
            labelNamaPelanggan.TabIndex = 6;
            labelNamaPelanggan.Text = "Nama Pelanggan";
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(581, 456);
            Controls.Add(comboBoxMenu);
            Controls.Add(textBoxJumlah);
            Controls.Add(buttonTambah);
            Controls.Add(dataGridViewKeranjang);
            Controls.Add(labelNamaPelanggan);
            Controls.Add(txtNamaPelanggan);
            Controls.Add(labelTotal);
            Controls.Add(buttonBayar);
            Controls.Add(labelJudul);
            Controls.Add(button1);
            Name = "FormTransaksi";
            Text = "FormTransaksi";
            Load += FormTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewKeranjang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}