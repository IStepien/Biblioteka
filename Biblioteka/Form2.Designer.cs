
namespace Biblioteka
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
            this.label1 = new System.Windows.Forms.Label();
            this.chBGenre = new System.Windows.Forms.CheckBox();
            this.chBAuthor = new System.Windows.Forms.CheckBox();
            this.chBTitle = new System.Windows.Forms.CheckBox();
            this.txtBGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.comBGenreF2 = new System.Windows.Forms.ComboBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtBAuthor = new System.Windows.Forms.TextBox();
            this.txtBTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.comBAuthorF2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZAZNACZ CO CHCESZ DODAĆ";
            // 
            // chBGenre
            // 
            this.chBGenre.AutoSize = true;
            this.chBGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chBGenre.Location = new System.Drawing.Point(35, 38);
            this.chBGenre.Name = "chBGenre";
            this.chBGenre.Size = new System.Drawing.Size(75, 17);
            this.chBGenre.TabIndex = 1;
            this.chBGenre.Text = "GATUNEK";
            this.chBGenre.UseVisualStyleBackColor = true;
            this.chBGenre.CheckedChanged += new System.EventHandler(this.chBGenre_CheckedChanged);
            // 
            // chBAuthor
            // 
            this.chBAuthor.AutoSize = true;
            this.chBAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chBAuthor.Location = new System.Drawing.Point(152, 38);
            this.chBAuthor.Name = "chBAuthor";
            this.chBAuthor.Size = new System.Drawing.Size(61, 17);
            this.chBAuthor.TabIndex = 2;
            this.chBAuthor.Text = "AUTOR";
            this.chBAuthor.UseVisualStyleBackColor = true;
            this.chBAuthor.CheckedChanged += new System.EventHandler(this.chBAuthor_CheckedChanged);
            // 
            // chBTitle
            // 
            this.chBTitle.AutoSize = true;
            this.chBTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chBTitle.Location = new System.Drawing.Point(256, 38);
            this.chBTitle.Name = "chBTitle";
            this.chBTitle.Size = new System.Drawing.Size(59, 17);
            this.chBTitle.TabIndex = 3;
            this.chBTitle.Text = "TYTUŁ";
            this.chBTitle.UseVisualStyleBackColor = true;
            this.chBTitle.CheckedChanged += new System.EventHandler(this.chBTitle_CheckedChanged);
            // 
            // txtBGenre
            // 
            this.txtBGenre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBGenre.Location = new System.Drawing.Point(35, 92);
            this.txtBGenre.Name = "txtBGenre";
            this.txtBGenre.Size = new System.Drawing.Size(100, 20);
            this.txtBGenre.TabIndex = 4;
            this.txtBGenre.Visible = false;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(32, 76);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(103, 13);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "NAZWA GATUNKU";
            this.lblGenre.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "ZAPISZ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(152, 155);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "POWRÓT";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // comBGenreF2
            // 
            this.comBGenreF2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBGenreF2.FormattingEnabled = true;
            this.comBGenreF2.Location = new System.Drawing.Point(35, 91);
            this.comBGenreF2.Name = "comBGenreF2";
            this.comBGenreF2.Size = new System.Drawing.Size(121, 21);
            this.comBGenreF2.TabIndex = 8;
            this.comBGenreF2.Visible = false;
            this.comBGenreF2.SelectedIndexChanged += new System.EventHandler(this.comBGenreF2_SelectedIndexChanged);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(181, 76);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(45, 13);
            this.lblAuthor.TabIndex = 9;
            this.lblAuthor.Text = "AUTOR";
            this.lblAuthor.Visible = false;
            // 
            // txtBAuthor
            // 
            this.txtBAuthor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBAuthor.Location = new System.Drawing.Point(184, 93);
            this.txtBAuthor.Name = "txtBAuthor";
            this.txtBAuthor.Size = new System.Drawing.Size(171, 20);
            this.txtBAuthor.TabIndex = 10;
            this.txtBAuthor.Visible = false;
            // 
            // txtBTitle
            // 
            this.txtBTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBTitle.Location = new System.Drawing.Point(381, 92);
            this.txtBTitle.Name = "txtBTitle";
            this.txtBTitle.Size = new System.Drawing.Size(131, 20);
            this.txtBTitle.TabIndex = 11;
            this.txtBTitle.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(381, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 13);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "TYTUŁ";
            this.lblTitle.Visible = false;
            // 
            // comBAuthorF2
            // 
            this.comBAuthorF2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBAuthorF2.FormattingEnabled = true;
            this.comBAuthorF2.Location = new System.Drawing.Point(184, 92);
            this.comBAuthorF2.Name = "comBAuthorF2";
            this.comBAuthorF2.Size = new System.Drawing.Size(171, 21);
            this.comBAuthorF2.TabIndex = 13;
            this.comBAuthorF2.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comBAuthorF2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBTitle);
            this.Controls.Add(this.txtBAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.comBGenreF2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtBGenre);
            this.Controls.Add(this.chBTitle);
            this.Controls.Add(this.chBAuthor);
            this.Controls.Add(this.chBGenre);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "BIBLIOTEKA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chBGenre;
        private System.Windows.Forms.CheckBox chBAuthor;
        private System.Windows.Forms.CheckBox chBTitle;
        private System.Windows.Forms.TextBox txtBGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comBGenreF2;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtBAuthor;
        private System.Windows.Forms.TextBox txtBTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comBAuthorF2;
    }
}