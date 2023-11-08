namespace KuisPertemuan13
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTampil = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.RadioAll = new System.Windows.Forms.RadioButton();
            this.radiokristen = new System.Windows.Forms.RadioButton();
            this.radioislam = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTampil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kuis Pertemuan 13";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID :";
            // 
            // dataGridViewTampil
            // 
            this.dataGridViewTampil.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTampil.Location = new System.Drawing.Point(52, 208);
            this.dataGridViewTampil.Name = "dataGridViewTampil";
            this.dataGridViewTampil.RowHeadersWidth = 62;
            this.dataGridViewTampil.RowTemplate.Height = 28;
            this.dataGridViewTampil.Size = new System.Drawing.Size(942, 241);
            this.dataGridViewTampil.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(189, 145);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(805, 39);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // RadioAll
            // 
            this.RadioAll.AutoSize = true;
            this.RadioAll.Location = new System.Drawing.Point(58, 547);
            this.RadioAll.Name = "RadioAll";
            this.RadioAll.Size = new System.Drawing.Size(51, 24);
            this.RadioAll.TabIndex = 5;
            this.RadioAll.TabStop = true;
            this.RadioAll.Text = "All";
            this.RadioAll.UseVisualStyleBackColor = true;
            // 
            // radiokristen
            // 
            this.radiokristen.AutoSize = true;
            this.radiokristen.Location = new System.Drawing.Point(273, 547);
            this.radiokristen.Name = "radiokristen";
            this.radiokristen.Size = new System.Drawing.Size(83, 24);
            this.radiokristen.TabIndex = 6;
            this.radiokristen.TabStop = true;
            this.radiokristen.Text = "Kristen";
            this.radiokristen.UseVisualStyleBackColor = true;
            // 
            // radioislam
            // 
            this.radioislam.AutoSize = true;
            this.radioislam.Location = new System.Drawing.Point(155, 547);
            this.radioislam.Name = "radioislam";
            this.radioislam.Size = new System.Drawing.Size(72, 24);
            this.radioislam.TabIndex = 7;
            this.radioislam.TabStop = true;
            this.radioislam.Text = "Islam";
            this.radioislam.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(686, 535);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 46);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(919, 536);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(801, 536);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 45);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(94, 478);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(286, 38);
            this.txtID.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1058, 648);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.radioislam);
            this.Controls.Add(this.radiokristen);
            this.Controls.Add(this.RadioAll);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridViewTampil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTampil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewTampil;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton RadioAll;
        private System.Windows.Forms.RadioButton radiokristen;
        private System.Windows.Forms.RadioButton radioislam;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtID;
    }
}

