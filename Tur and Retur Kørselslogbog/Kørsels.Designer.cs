namespace Tur_and_Retur_Kørselslogbog
{
    partial class Kørsels
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
            this.opgave1 = new System.Windows.Forms.TextBox();
            this.user_id = new System.Windows.Forms.ComboBox();
            this.UserID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add1 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.opgave = new System.Windows.Forms.Label();
            this.KørselsLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // opgave1
            // 
            this.opgave1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.opgave1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.opgave1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opgave1.Location = new System.Drawing.Point(30, 180);
            this.opgave1.Multiline = true;
            this.opgave1.Name = "opgave1";
            this.opgave1.Size = new System.Drawing.Size(216, 28);
            this.opgave1.TabIndex = 43;
            // 
            // user_id
            // 
            this.user_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.user_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.user_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.user_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_id.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_id.FormattingEnabled = true;
            this.user_id.Location = new System.Drawing.Point(30, 119);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(216, 29);
            this.user_id.TabIndex = 42;
            this.user_id.SelectedIndexChanged += new System.EventHandler(this.user_id_SelectedIndexChanged);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.ForeColor = System.Drawing.Color.DarkGray;
            this.UserID.Location = new System.Drawing.Point(27, 99);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(53, 17);
            this.UserID.TabIndex = 41;
            this.UserID.Text = "User ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 400);
            this.dataGridView1.TabIndex = 40;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(747, 587);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(147, 35);
            this.Search.TabIndex = 38;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(570, 587);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(147, 35);
            this.Delete.TabIndex = 37;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(388, 587);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(147, 35);
            this.Update.TabIndex = 36;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // Add1
            // 
            this.Add1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Add1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add1.FlatAppearance.BorderSize = 0;
            this.Add1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add1.ForeColor = System.Drawing.Color.White;
            this.Add1.Location = new System.Drawing.Point(206, 587);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(147, 35);
            this.Add1.TabIndex = 35;
            this.Add1.Text = "Add";
            this.Add1.UseVisualStyleBackColor = false;
            this.Add1.Click += new System.EventHandler(this.Add1_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(30, 587);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(147, 35);
            this.Back.TabIndex = 28;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // opgave
            // 
            this.opgave.AutoSize = true;
            this.opgave.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opgave.ForeColor = System.Drawing.Color.DarkGray;
            this.opgave.Location = new System.Drawing.Point(27, 160);
            this.opgave.Name = "opgave";
            this.opgave.Size = new System.Drawing.Size(55, 17);
            this.opgave.TabIndex = 25;
            this.opgave.Text = "Opgave";
            // 
            // KørselsLog
            // 
            this.KørselsLog.AutoSize = true;
            this.KørselsLog.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KørselsLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.KørselsLog.Location = new System.Drawing.Point(22, 9);
            this.KørselsLog.Name = "KørselsLog";
            this.KørselsLog.Size = new System.Drawing.Size(420, 47);
            this.KørselsLog.TabIndex = 24;
            this.KørselsLog.Text = "Kørsels Log Registrering";
            // 
            // Kørsels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 658);
            this.Controls.Add(this.opgave1);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.opgave);
            this.Controls.Add(this.KørselsLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kørsels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kørsels";
            this.Load += new System.EventHandler(this.Kørsels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox opgave1;
        private System.Windows.Forms.ComboBox user_id;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label opgave;
        private System.Windows.Forms.Label KørselsLog;
    }
}