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
            dataGridView1.Location = new Point(58, 115);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(817, 346);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonTambah
            // 
            buttonTambah.Location = new Point(758, 69);
            buttonTambah.Margin = new Padding(4, 4, 4, 4);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(117, 35);
            buttonTambah.TabIndex = 1;
            buttonTambah.Text = "Tambah";
            buttonTambah.UseVisualStyleBackColor = true;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelJudul.Location = new Point(327, 23);
            labelJudul.Margin = new Padding(4, 0, 4, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(248, 37);
            labelJudul.TabIndex = 2;
            labelJudul.Text = "Manajemen Menu";
            labelJudul.Click += labelJudul_Click;
            // 
            // button1
            // 
            button1.Location = new Point(622, 69);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 35);
            button1.TabIndex = 3;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ManajemenMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(933, 519);
            Controls.Add(button1);
            Controls.Add(labelJudul);
            Controls.Add(buttonTambah);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 4, 4, 4);
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
