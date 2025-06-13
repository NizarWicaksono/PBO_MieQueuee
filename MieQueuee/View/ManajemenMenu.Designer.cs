namespace MieQueuee.View
{
    partial class ManajemenMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label labelJudul;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonTambah = new Button();
            labelJudul = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(83, 192);
            dataGridView1.Margin = new Padding(5, 6, 5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1167, 577);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonTambah
            // 
            buttonTambah.Location = new Point(1083, 115);
            buttonTambah.Margin = new Padding(5, 6, 5, 6);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(167, 58);
            buttonTambah.TabIndex = 1;
            buttonTambah.Text = "Tambah";
            buttonTambah.UseVisualStyleBackColor = true;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelJudul.Location = new Point(467, 38);
            labelJudul.Margin = new Padding(5, 0, 5, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(364, 54);
            labelJudul.TabIndex = 2;
            labelJudul.Text = "Manajemen Menu";
            labelJudul.Click += labelJudul_Click;
            // 
            // button1
            // 
            button1.Location = new Point(889, 115);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(167, 58);
            button1.TabIndex = 3;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ManajemenMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1333, 865);
            Controls.Add(button1);
            Controls.Add(labelJudul);
            Controls.Add(buttonTambah);
            Controls.Add(dataGridView1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ManajemenMenu";
            Text = "Manajemen Menu";
            Load += ManajemenMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button button1;
    }
}
