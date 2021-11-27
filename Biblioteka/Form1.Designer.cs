
namespace Biblioteka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGenre = new System.Windows.Forms.Label();
            this.comBGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvTitle = new System.Windows.Forms.ListView();
            this.comBAuthor = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGenre
            // 
            this.lblGenre.Location = new System.Drawing.Point(9, 19);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(146, 31);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "WYBIERZ GATUNEK";
            // 
            // comBGenre
            // 
            this.comBGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBGenre.FormattingEnabled = true;
            this.comBGenre.Location = new System.Drawing.Point(12, 39);
            this.comBGenre.Name = "comBGenre";
            this.comBGenre.Size = new System.Drawing.Size(121, 21);
            this.comBGenre.TabIndex = 10;
            this.comBGenre.SelectedIndexChanged += new System.EventHandler(this.comBGenre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "WYBIERZ AUTORA";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 145);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 13);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "TYTUŁ";
            // 
            // lvTitle
            // 
            this.lvTitle.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvTitle.GridLines = true;
            this.lvTitle.HideSelection = false;
            this.lvTitle.HotTracking = true;
            this.lvTitle.HoverSelection = true;
            this.lvTitle.Location = new System.Drawing.Point(12, 174);
            this.lvTitle.MultiSelect = false;
            this.lvTitle.Name = "lvTitle";
            this.lvTitle.Size = new System.Drawing.Size(121, 97);
            this.lvTitle.TabIndex = 15;
            this.lvTitle.UseCompatibleStateImageBehavior = false;
            this.lvTitle.View = System.Windows.Forms.View.List;
            this.lvTitle.SelectedIndexChanged += new System.EventHandler(this.lvTitle_SelectedIndexChanged);
            // 
            // comBAuthor
            // 
            this.comBAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBAuthor.FormattingEnabled = true;
            this.comBAuthor.Location = new System.Drawing.Point(12, 107);
            this.comBAuthor.Name = "comBAuthor";
            this.comBAuthor.Size = new System.Drawing.Size(121, 21);
            this.comBAuthor.TabIndex = 17;
            this.comBAuthor.SelectedIndexChanged += new System.EventHandler(this.comBAuthor_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "DODAJ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(329, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 169);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 414);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comBAuthor);
            this.Controls.Add(this.lvTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBGenre);
            this.Controls.Add(this.lblGenre);
            this.Name = "Form1";
            this.Text = "BIBLIOTEKA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox comBGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lvTitle;
        private System.Windows.Forms.ComboBox comBAuthor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

