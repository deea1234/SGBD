namespace sgbd1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.InsertAngajatButton = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.DeleteAngajatButton = new System.Windows.Forms.Button();
            this.UpdateAngajatButton = new System.Windows.Forms.Button();
            this.IdAngajatLabel = new System.Windows.Forms.Label();
            this.SalarLabel = new System.Windows.Forms.Label();
            this.NumeAngajat = new System.Windows.Forms.Label();
            this.IdCofetarieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(512, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(605, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(672, 320);
            this.dataGridView2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1013, 485);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1013, 380);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1013, 433);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1013, 535);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 6;
            // 
            // InsertAngajatButton
            // 
            this.InsertAngajatButton.BackColor = System.Drawing.Color.Plum;
            this.InsertAngajatButton.ForeColor = System.Drawing.Color.Black;
            this.InsertAngajatButton.Location = new System.Drawing.Point(1144, 399);
            this.InsertAngajatButton.Name = "InsertAngajatButton";
            this.InsertAngajatButton.Size = new System.Drawing.Size(104, 41);
            this.InsertAngajatButton.TabIndex = 7;
            this.InsertAngajatButton.Text = "Insert";
            this.InsertAngajatButton.UseVisualStyleBackColor = false;
            this.InsertAngajatButton.Click += new System.EventHandler(this.InsertAngajatButton_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.Plum;
            this.Refresh.Location = new System.Drawing.Point(21, 307);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(112, 52);
            this.Refresh.TabIndex = 8;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // DeleteAngajatButton
            // 
            this.DeleteAngajatButton.BackColor = System.Drawing.Color.Plum;
            this.DeleteAngajatButton.Location = new System.Drawing.Point(1144, 452);
            this.DeleteAngajatButton.Name = "DeleteAngajatButton";
            this.DeleteAngajatButton.Size = new System.Drawing.Size(104, 41);
            this.DeleteAngajatButton.TabIndex = 9;
            this.DeleteAngajatButton.Text = "Delete";
            this.DeleteAngajatButton.UseVisualStyleBackColor = false;
            this.DeleteAngajatButton.Click += new System.EventHandler(this.DeleteAngajatButton_Click);
            // 
            // UpdateAngajatButton
            // 
            this.UpdateAngajatButton.BackColor = System.Drawing.Color.Plum;
            this.UpdateAngajatButton.Location = new System.Drawing.Point(1144, 504);
            this.UpdateAngajatButton.Name = "UpdateAngajatButton";
            this.UpdateAngajatButton.Size = new System.Drawing.Size(104, 41);
            this.UpdateAngajatButton.TabIndex = 10;
            this.UpdateAngajatButton.Text = "Update";
            this.UpdateAngajatButton.UseVisualStyleBackColor = false;
            this.UpdateAngajatButton.Click += new System.EventHandler(this.UpdateAngajatButton_Click);
            // 
            // IdAngajatLabel
            // 
            this.IdAngajatLabel.AutoSize = true;
            this.IdAngajatLabel.Location = new System.Drawing.Point(1020, 357);
            this.IdAngajatLabel.Name = "IdAngajatLabel";
            this.IdAngajatLabel.Size = new System.Drawing.Size(82, 20);
            this.IdAngajatLabel.TabIndex = 11;
            this.IdAngajatLabel.Text = "Id Angajat";
            // 
            // SalarLabel
            // 
            this.SalarLabel.AutoSize = true;
            this.SalarLabel.Location = new System.Drawing.Point(1037, 462);
            this.SalarLabel.Name = "SalarLabel";
            this.SalarLabel.Size = new System.Drawing.Size(46, 20);
            this.SalarLabel.TabIndex = 12;
            this.SalarLabel.Text = "Salar";
            // 
            // NumeAngajat
            // 
            this.NumeAngajat.AutoSize = true;
            this.NumeAngajat.Location = new System.Drawing.Point(1037, 409);
            this.NumeAngajat.Name = "NumeAngajat";
            this.NumeAngajat.Size = new System.Drawing.Size(51, 20);
            this.NumeAngajat.TabIndex = 13;
            this.NumeAngajat.Text = "Nume";
            // 
            // IdCofetarieLabel
            // 
            this.IdCofetarieLabel.AutoSize = true;
            this.IdCofetarieLabel.Location = new System.Drawing.Point(1021, 514);
            this.IdCofetarieLabel.Name = "IdCofetarieLabel";
            this.IdCofetarieLabel.Size = new System.Drawing.Size(92, 20);
            this.IdCofetarieLabel.TabIndex = 14;
            this.IdCofetarieLabel.Text = "Id Cofetarie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1338, 610);
            this.Controls.Add(this.IdCofetarieLabel);
            this.Controls.Add(this.NumeAngajat);
            this.Controls.Add(this.SalarLabel);
            this.Controls.Add(this.IdAngajatLabel);
            this.Controls.Add(this.UpdateAngajatButton);
            this.Controls.Add(this.DeleteAngajatButton);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.InsertAngajatButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button InsertAngajatButton;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button DeleteAngajatButton;
        private System.Windows.Forms.Button UpdateAngajatButton;
        private System.Windows.Forms.Label IdAngajatLabel;
        private System.Windows.Forms.Label SalarLabel;
        private System.Windows.Forms.Label NumeAngajat;
        private System.Windows.Forms.Label IdCofetarieLabel;
    }
}

