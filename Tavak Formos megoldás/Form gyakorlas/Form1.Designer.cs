namespace Form_gyakorlas
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Név = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terulet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ország = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBeolvas = new System.Windows.Forms.Button();
            this.txbEredmeny = new System.Windows.Forms.TextBox();
            this.btmFeltolt = new System.Windows.Forms.Button();
            this.btnLEgnagyobb = new System.Windows.Forms.Button();
            this.txtbNev = new System.Windows.Forms.TextBox();
            this.txtbMaxTer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbMinNev = new System.Windows.Forms.TextBox();
            this.txtbMinTer = new System.Windows.Forms.TextBox();
            this.txtbAtlag = new System.Windows.Forms.TextBox();
            this.Atlag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Név,
            this.Terulet,
            this.Ország});
            this.dataGridView1.Location = new System.Drawing.Point(22, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Név
            // 
            this.Név.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Név.HeaderText = "Nev";
            this.Név.Name = "Név";
            // 
            // Terulet
            // 
            this.Terulet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Terulet.HeaderText = "Terulet";
            this.Terulet.Name = "Terulet";
            // 
            // Ország
            // 
            this.Ország.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ország.HeaderText = "Ország/Országok";
            this.Ország.Name = "Ország";
            // 
            // btBeolvas
            // 
            this.btBeolvas.Location = new System.Drawing.Point(22, 24);
            this.btBeolvas.Name = "btBeolvas";
            this.btBeolvas.Size = new System.Drawing.Size(196, 23);
            this.btBeolvas.TabIndex = 1;
            this.btBeolvas.Text = "Beolvasás";
            this.btBeolvas.UseVisualStyleBackColor = true;
            this.btBeolvas.Click += new System.EventHandler(this.btBeolvas_Click);
            // 
            // txbEredmeny
            // 
            this.txbEredmeny.Location = new System.Drawing.Point(246, 24);
            this.txbEredmeny.Name = "txbEredmeny";
            this.txbEredmeny.Size = new System.Drawing.Size(159, 20);
            this.txbEredmeny.TabIndex = 2;
            // 
            // btmFeltolt
            // 
            this.btmFeltolt.Location = new System.Drawing.Point(22, 67);
            this.btmFeltolt.Name = "btmFeltolt";
            this.btmFeltolt.Size = new System.Drawing.Size(196, 23);
            this.btmFeltolt.TabIndex = 3;
            this.btmFeltolt.Text = "Feltöltés";
            this.btmFeltolt.UseVisualStyleBackColor = true;
            this.btmFeltolt.Click += new System.EventHandler(this.btmFeltolt_Click);
            // 
            // btnLEgnagyobb
            // 
            this.btnLEgnagyobb.Location = new System.Drawing.Point(22, 110);
            this.btnLEgnagyobb.Name = "btnLEgnagyobb";
            this.btnLEgnagyobb.Size = new System.Drawing.Size(196, 23);
            this.btnLEgnagyobb.TabIndex = 4;
            this.btnLEgnagyobb.Text = "Legnagyobb tó";
            this.btnLEgnagyobb.UseVisualStyleBackColor = true;
            this.btnLEgnagyobb.Click += new System.EventHandler(this.btnLEgnagyobb_Click);
            // 
            // txtbNev
            // 
            this.txtbNev.Location = new System.Drawing.Point(246, 112);
            this.txtbNev.Name = "txtbNev";
            this.txtbNev.Size = new System.Drawing.Size(159, 20);
            this.txtbNev.TabIndex = 5;
            // 
            // txtbMaxTer
            // 
            this.txtbMaxTer.Location = new System.Drawing.Point(432, 113);
            this.txtbMaxTer.Name = "txtbMaxTer";
            this.txtbMaxTer.Size = new System.Drawing.Size(159, 20);
            this.txtbMaxTer.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Legkisebb tó";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbMinNev
            // 
            this.txtbMinNev.Location = new System.Drawing.Point(246, 154);
            this.txtbMinNev.Name = "txtbMinNev";
            this.txtbMinNev.Size = new System.Drawing.Size(159, 20);
            this.txtbMinNev.TabIndex = 8;
            // 
            // txtbMinTer
            // 
            this.txtbMinTer.Location = new System.Drawing.Point(432, 155);
            this.txtbMinTer.Name = "txtbMinTer";
            this.txtbMinTer.Size = new System.Drawing.Size(159, 20);
            this.txtbMinTer.TabIndex = 9;
            // 
            // txtbAtlag
            // 
            this.txtbAtlag.Location = new System.Drawing.Point(246, 198);
            this.txtbAtlag.Name = "txtbAtlag";
            this.txtbAtlag.Size = new System.Drawing.Size(159, 20);
            this.txtbAtlag.TabIndex = 11;
            // 
            // Atlag
            // 
            this.Atlag.Location = new System.Drawing.Point(22, 196);
            this.Atlag.Name = "Atlag";
            this.Atlag.Size = new System.Drawing.Size(196, 23);
            this.Atlag.TabIndex = 10;
            this.Atlag.Text = "Föd tavainak átlaga";
            this.Atlag.UseVisualStyleBackColor = true;
            this.Atlag.Click += new System.EventHandler(this.Atlag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbAtlag);
            this.Controls.Add(this.Atlag);
            this.Controls.Add(this.txtbMinTer);
            this.Controls.Add(this.txtbMinNev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbMaxTer);
            this.Controls.Add(this.txtbNev);
            this.Controls.Add(this.btnLEgnagyobb);
            this.Controls.Add(this.btmFeltolt);
            this.Controls.Add(this.txbEredmeny);
            this.Controls.Add(this.btBeolvas);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Név;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terulet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ország;
        private System.Windows.Forms.Button btBeolvas;
        private System.Windows.Forms.TextBox txbEredmeny;
        private System.Windows.Forms.Button btmFeltolt;
        private System.Windows.Forms.Button btnLEgnagyobb;
        private System.Windows.Forms.TextBox txtbNev;
        private System.Windows.Forms.TextBox txtbMaxTer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbMinNev;
        private System.Windows.Forms.TextBox txtbMinTer;
        private System.Windows.Forms.TextBox txtbAtlag;
        private System.Windows.Forms.Button Atlag;
    }
}

