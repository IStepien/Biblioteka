using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Form2 : Form
    {
        public Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chBGenre.Checked)
            {
                if (txtBGenre.TextLength > 0)
                {
                    if (!form1.genres.Contains(txtBGenre.Text))
                    {
                        form1.genres.Add(txtBGenre.Text);
                        txtBGenre.Text = "";
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Lista zawiera już taką wartość", "Błąd!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            return;
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Pole nie może być puste", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (chBAuthor.Checked)
            {
                switch (comBGenreF2.SelectedIndex)
                {
                    case 0:
                        form1.authors1.Add(txtBAuthor.Text);
                        break;
                    case 1:
                        form1.authors2.Add(txtBAuthor.Text);
                        break;
                    case 2:
                        form1.authors3.Add(txtBAuthor.Text);
                        break;

                }
                txtBAuthor.Clear();
            }
            else if (chBTitle.Checked)
            {
             
                if (comBAuthorF2.Text.Contains("a1"))
                 form1.booksA1.Add(txtBTitle.Text);
                else if (comBAuthorF2.Text.Contains("a2"))
                    form1.booksA1.Add(txtBTitle.Text);
                else if (comBAuthorF2.Text.Contains("a3"))
                    form1.booksA1.Add(txtBTitle.Text);

            }
                txtBAuthor.Clear();
            

            MessageBox.Show("Zapisano", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void chBGenre_CheckedChanged(object sender, EventArgs e)
        {
            if (chBGenre.Checked)
            {
                txtBGenre.Visible = true;
                lblGenre.Visible = true;
                chBAuthor.Enabled = false;
                chBTitle.Enabled = false;
                   
            }
            else if (!chBGenre.Checked)
            {
                txtBGenre.Visible = false;
                lblGenre.Visible = false;
                chBAuthor.Enabled = true;
                chBTitle.Enabled = true;
            }
        }

        private void chBAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (chBAuthor.Checked)
            {
                lblGenre.Visible = true;
                comBGenreF2.Visible = true;
                txtBAuthor.Visible = true;
                lblAuthor.Visible = true;
                chBGenre.Enabled = false;
                chBTitle.Enabled = false;
            }
            else if (!chBAuthor.Checked)
            {
                lblGenre.Visible = false;
                comBGenreF2.Visible = false;
                txtBAuthor.Visible = false;
                lblAuthor.Visible = false;
                chBGenre.Enabled = true;
                chBTitle.Enabled = true;
            }

            foreach (string s in form1.genres)
            {
                comBGenreF2.Items.Add(s);
            }
            if (chBAuthor.Checked)
            {
                lblGenre.Visible = true;
                comBGenreF2.Visible = true;
            }


            


        }

        private void chBTitle_CheckedChanged(object sender, EventArgs e)
        {
            comBGenreF2.Items.Clear();
            if (chBTitle.Checked)
            {
                lblGenre.Visible = true;
                comBGenreF2.Visible = true;
                comBAuthorF2.Visible = true;
                lblAuthor.Visible = true;
                lblTitle.Visible = true;
                txtBTitle.Visible = true;
                chBGenre.Enabled = false;
                chBAuthor.Enabled = false;

                foreach (string s in form1.genres)
                {
                    comBGenreF2.Items.Add(s);
                }

            }
            else if (!chBTitle.Checked)
            {
                lblGenre.Visible = false;
                comBGenreF2.Visible = false;
                comBAuthorF2.Visible = false;
                txtBAuthor.Visible = false;
                lblAuthor.Visible = false;
                lblTitle.Visible = false;
                txtBTitle.Visible = false;
                chBGenre.Enabled = true;
                chBAuthor.Enabled = true;
            }

        }

        private void comBGenreF2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBAuthorF2.Items.Clear();
            if (!chBGenre.Checked)
            {

                form1.loadAuthorsList(comBGenreF2.SelectedIndex, comBAuthorF2);


            }
            
        }
    }
}
