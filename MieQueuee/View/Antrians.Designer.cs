namespace MieQueuee.View
{
    partial class FormAntrian
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewAntrian;
        private System.Windows.Forms.Button buttonSelesai;
        private System.Windows.Forms.Label labelJudul;

        private void InitializeComponent()
        {
            dataGridViewAntrian = new DataGridView();
            buttonSelesai = new Button();
            labelJudul = new Label();
            button1 = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAntrian).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAntrian
            // 
            dataGridViewAntrian.ColumnHeadersHeight = 34;
            dataGridViewAntrian.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewAntrian.Location = new Point(20, 80);
            dataGridViewAntrian.Name = "dataGridViewAntrian";
            dataGridViewAntrian.ReadOnly = true;
            dataGridViewAntrian.RowHeadersWidth = 62;
            dataGridViewAntrian.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAntrian.Size = new Size(760, 300);
            dataGridViewAntrian.TabIndex = 1;
            dataGridViewAntrian.CellContentClick += dataGridViewAntrian_CellContentClick;
            // 
            // buttonSelesai
            // 
            buttonSelesai.Location = new Point(650, 400);
            buttonSelesai.Name = "buttonSelesai";
            buttonSelesai.Size = new Size(130, 40);
            buttonSelesai.TabIndex = 2;
            buttonSelesai.Text = "Tandai Selesai";
            buttonSelesai.Click += buttonSelesai_Click;
            // 
            // labelJudul
            // 
            labelJudul.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelJudul.Location = new Point(20, 20);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(300, 40);
            labelJudul.TabIndex = 0;
            labelJudul.Text = "Daftar Antrian";
            // 
            // button1
            // 
            button1.Location = new Point(503, 400);
            button1.Name = "button1";
            button1.Size = new Size(130, 40);
            button1.TabIndex = 3;
            button1.Text = "Kembali";
            button1.Click += button1_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nama Pelanggan";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Menu";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Harga";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Jumlah";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Subtotal";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Status";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // FormAntrian
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 480);
            Controls.Add(button1);
            Controls.Add(labelJudul);
            Controls.Add(dataGridViewAntrian);
            Controls.Add(buttonSelesai);
            Name = "FormAntrian";
            Text = "Antrian Dapur";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAntrian).EndInit();
            ResumeLayout(false);
        }
        private Button button1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
