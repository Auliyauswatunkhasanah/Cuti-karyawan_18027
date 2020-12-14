namespace Cuti_karyawan
{
    partial class lihatcuti
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cuti_karyawanDataSet1 = new Cuti_karyawan.cuti_karyawanDataSet1();
            this.cutiKaryawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuti_KaryawanTableAdapter = new Cuti_karyawan.cuti_karyawanDataSet1TableAdapters.Cuti_KaryawanTableAdapter();
            this.cutiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mulaiCutiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akhirCutiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuti_karyawanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutiKaryawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cutiIDDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn,
            this.namaKaryawanDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.jabatanDataGridViewTextBoxColumn,
            this.mulaiCutiDataGridViewTextBoxColumn,
            this.akhirCutiDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cutiKaryawanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // cuti_karyawanDataSet1
            // 
            this.cuti_karyawanDataSet1.DataSetName = "cuti_karyawanDataSet1";
            this.cuti_karyawanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cutiKaryawanBindingSource
            // 
            this.cutiKaryawanBindingSource.DataMember = "Cuti_Karyawan";
            this.cutiKaryawanBindingSource.DataSource = this.cuti_karyawanDataSet1;
            // 
            // cuti_KaryawanTableAdapter
            // 
            this.cuti_KaryawanTableAdapter.ClearBeforeFill = true;
            // 
            // cutiIDDataGridViewTextBoxColumn
            // 
            this.cutiIDDataGridViewTextBoxColumn.DataPropertyName = "Cuti_ID";
            this.cutiIDDataGridViewTextBoxColumn.HeaderText = "Cuti_ID";
            this.cutiIDDataGridViewTextBoxColumn.Name = "cutiIDDataGridViewTextBoxColumn";
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            // 
            // namaKaryawanDataGridViewTextBoxColumn
            // 
            this.namaKaryawanDataGridViewTextBoxColumn.DataPropertyName = "Nama_Karyawan";
            this.namaKaryawanDataGridViewTextBoxColumn.HeaderText = "Nama_Karyawan";
            this.namaKaryawanDataGridViewTextBoxColumn.Name = "namaKaryawanDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // jabatanDataGridViewTextBoxColumn
            // 
            this.jabatanDataGridViewTextBoxColumn.DataPropertyName = "Jabatan";
            this.jabatanDataGridViewTextBoxColumn.HeaderText = "Jabatan";
            this.jabatanDataGridViewTextBoxColumn.Name = "jabatanDataGridViewTextBoxColumn";
            // 
            // mulaiCutiDataGridViewTextBoxColumn
            // 
            this.mulaiCutiDataGridViewTextBoxColumn.DataPropertyName = "Mulai_Cuti";
            this.mulaiCutiDataGridViewTextBoxColumn.HeaderText = "Mulai_Cuti";
            this.mulaiCutiDataGridViewTextBoxColumn.Name = "mulaiCutiDataGridViewTextBoxColumn";
            // 
            // akhirCutiDataGridViewTextBoxColumn
            // 
            this.akhirCutiDataGridViewTextBoxColumn.DataPropertyName = "Akhir_Cuti";
            this.akhirCutiDataGridViewTextBoxColumn.HeaderText = "Akhir_Cuti";
            this.akhirCutiDataGridViewTextBoxColumn.Name = "akhirCutiDataGridViewTextBoxColumn";
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cuti_karyawan.Properties.Resources.icon_back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lihatcuti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "lihatcuti";
            this.Text = "Daftar Cuti";
            this.Load += new System.EventHandler(this.lihatcuti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuti_karyawanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutiKaryawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private cuti_karyawanDataSet1 cuti_karyawanDataSet1;
        private System.Windows.Forms.BindingSource cutiKaryawanBindingSource;
        private cuti_karyawanDataSet1TableAdapters.Cuti_KaryawanTableAdapter cuti_KaryawanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mulaiCutiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akhirCutiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}