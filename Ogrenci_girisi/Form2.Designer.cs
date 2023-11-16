namespace Ogrenci_girisi
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporOluşturToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad_Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciDataSet = new Ogrenci_girisi.OgrenciDataSet();
            this.kayitTableAdapter = new Ogrenci_girisi.OgrenciDataSetTableAdapters.KayitTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşlemleriToolStripMenuItem,
            this.veriİşlemleriToolStripMenuItem,
            this.raporİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciİşlemleriToolStripMenuItem
            // 
            this.öğrenciİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtEkleToolStripMenuItem,
            this.kayıtSilToolStripMenuItem,
            this.kayıtBulToolStripMenuItem});
            this.öğrenciİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.öğrenciİşlemleriToolStripMenuItem.Name = "öğrenciİşlemleriToolStripMenuItem";
            this.öğrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(118, 21);
            this.öğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // kayıtEkleToolStripMenuItem
            // 
            this.kayıtEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtEkleToolStripMenuItem.Name = "kayıtEkleToolStripMenuItem";
            this.kayıtEkleToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.kayıtEkleToolStripMenuItem.Text = "Kayıt Ekle";
            this.kayıtEkleToolStripMenuItem.Click += new System.EventHandler(this.kayıtEkleToolStripMenuItem_Click);
            // 
            // kayıtSilToolStripMenuItem
            // 
            this.kayıtSilToolStripMenuItem.Name = "kayıtSilToolStripMenuItem";
            this.kayıtSilToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.kayıtSilToolStripMenuItem.Text = "Kayıt Sil";
            this.kayıtSilToolStripMenuItem.Click += new System.EventHandler(this.kayıtSilToolStripMenuItem_Click);
            // 
            // kayıtBulToolStripMenuItem
            // 
            this.kayıtBulToolStripMenuItem.Name = "kayıtBulToolStripMenuItem";
            this.kayıtBulToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.kayıtBulToolStripMenuItem.Text = "Kayıt Bul";
            this.kayıtBulToolStripMenuItem.Click += new System.EventHandler(this.kayıtBulToolStripMenuItem_Click);
            // 
            // veriİşlemleriToolStripMenuItem
            // 
            this.veriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğretmenEkleToolStripMenuItem,
            this.öğretmenSilToolStripMenuItem,
            this.öğretmenBulToolStripMenuItem});
            this.veriİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veriİşlemleriToolStripMenuItem.Name = "veriİşlemleriToolStripMenuItem";
            this.veriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(131, 21);
            this.veriİşlemleriToolStripMenuItem.Text = "Öğretmen İşlemleri";
            // 
            // öğretmenEkleToolStripMenuItem
            // 
            this.öğretmenEkleToolStripMenuItem.Name = "öğretmenEkleToolStripMenuItem";
            this.öğretmenEkleToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.öğretmenEkleToolStripMenuItem.Text = "Öğretmen Ekle";
            this.öğretmenEkleToolStripMenuItem.Click += new System.EventHandler(this.öğretmenEkleToolStripMenuItem_Click);
            // 
            // öğretmenSilToolStripMenuItem
            // 
            this.öğretmenSilToolStripMenuItem.Name = "öğretmenSilToolStripMenuItem";
            this.öğretmenSilToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.öğretmenSilToolStripMenuItem.Text = "Öğretmen Sil";
            this.öğretmenSilToolStripMenuItem.Click += new System.EventHandler(this.öğretmenSilToolStripMenuItem_Click);
            // 
            // öğretmenBulToolStripMenuItem
            // 
            this.öğretmenBulToolStripMenuItem.Name = "öğretmenBulToolStripMenuItem";
            this.öğretmenBulToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.öğretmenBulToolStripMenuItem.Text = "Öğretmen Bul";
            this.öğretmenBulToolStripMenuItem.Click += new System.EventHandler(this.öğretmenBulToolStripMenuItem_Click);
            // 
            // raporİşlemleriToolStripMenuItem
            // 
            this.raporİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem,
            this.öğretmenToolStripMenuItem});
            this.raporİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporİşlemleriToolStripMenuItem.Name = "raporİşlemleriToolStripMenuItem";
            this.raporİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            this.raporİşlemleriToolStripMenuItem.Text = "Rapor İşlemleri";
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporOluşturToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // raporOluşturToolStripMenuItem
            // 
            this.raporOluşturToolStripMenuItem.Name = "raporOluşturToolStripMenuItem";
            this.raporOluşturToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.raporOluşturToolStripMenuItem.Text = "Rapor Oluştur";
            this.raporOluşturToolStripMenuItem.Click += new System.EventHandler(this.raporOluşturToolStripMenuItem_Click);
            // 
            // öğretmenToolStripMenuItem
            // 
            this.öğretmenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporOluşturToolStripMenuItem1});
            this.öğretmenToolStripMenuItem.Name = "öğretmenToolStripMenuItem";
            this.öğretmenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğretmenToolStripMenuItem.Text = "Öğretmen";
            // 
            // raporOluşturToolStripMenuItem1
            // 
            this.raporOluşturToolStripMenuItem1.Name = "raporOluşturToolStripMenuItem1";
            this.raporOluşturToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.raporOluşturToolStripMenuItem1.Text = "Rapor Oluştur";
            this.raporOluşturToolStripMenuItem1.Click += new System.EventHandler(this.raporOluşturToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.Ad_Soyad,
            this.Sinif,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kayitBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 327);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.Width = 95;
            // 
            // Ad_Soyad
            // 
            this.Ad_Soyad.DataPropertyName = "Ad_Soyad";
            this.Ad_Soyad.HeaderText = "Adı Soyadı";
            this.Ad_Soyad.Name = "Ad_Soyad";
            this.Ad_Soyad.Width = 150;
            // 
            // Sinif
            // 
            this.Sinif.DataPropertyName = "Sinif";
            this.Sinif.HeaderText = "Sınıfı";
            this.Sinif.Name = "Sinif";
            this.Sinif.Width = 95;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 150;
            // 
            // kayitBindingSource
            // 
            this.kayitBindingSource.DataMember = "Kayit";
            this.kayitBindingSource.DataSource = this.ogrenciDataSet;
            // 
            // ogrenciDataSet
            // 
            this.ogrenciDataSet.DataSetName = "OgrenciDataSet";
            this.ogrenciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayitTableAdapter
            // 
            this.kayitTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 355);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporİşlemleriToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OgrenciDataSet ogrenciDataSet;
        private System.Windows.Forms.BindingSource kayitBindingSource;
        private OgrenciDataSetTableAdapters.KayitTableAdapter kayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad_Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sinif;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem kayıtSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporOluşturToolStripMenuItem1;
    }
}