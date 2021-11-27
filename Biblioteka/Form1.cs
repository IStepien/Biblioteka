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
    public partial class Form1 : Form

    {
        public List<string> genres = new List<string>(){ "gatunek1", "gatunek2", "gatunek3" };
        public List<string> authors1 = new List<string>() { "g1a1" };
        public List<string> authors2 = new List<string>() { "g2a1", "g2a2"};
        public List<string> authors3 = new List<string>() { "g3a1", "g3a2", "g3a3"};
        public List<string> booksA1 = new List<string>() { "a1b1", "a1b2", "a1b3" };
        public List<string> booksA2 = new List<string>() { "a2b1" };
        public List<string> booksA3 = new List<string>() { "a3b1", "a3b2"};
        public Bitmap book1 = new Bitmap("F:\\Images\\book1.jpg");
        public Bitmap book2 = new Bitmap("F:\\Images\\book2.jpg");
        public Bitmap book3 = new Bitmap("F:\\Images\\book3.png");



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in genres)  
            comBGenre.Items.Add(s);
        
        }
          

        public void loadAuthorsList (int i, ComboBox comB)
        {
            comB.Items.Clear();
            switch (i)
            {
                case 0:
                    comB.Items.AddRange(authors1.ToArray());
                    break;
                case 1:
                    comB.Items.AddRange(authors2.ToArray());
                    break;
                case 2:
                    comB.Items.AddRange(authors3.ToArray());
                    break;

            }
        }



        private void comBGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadAuthorsList(comBGenre.SelectedIndex, comBAuthor);



        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void lvTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvTitle.Items)
            {
                if (item.Selected)
                {
                   pictureBox1.Image = book1;
                }
            }

        
        }

        private void comBAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvTitle.Clear();
            if (comBAuthor.SelectedItem.ToString().Contains("a1"))
            {
                foreach (string s in booksA1)
                    lvTitle.Items.Add(s);
            }
            if (comBAuthor.SelectedItem.ToString().Contains("a2"))
            {
                foreach (string s in booksA2)
                    lvTitle.Items.Add(s);
            }
            if (comBAuthor.SelectedItem.ToString().Contains("a3"))
            {
                foreach (string s in booksA3)
                    lvTitle.Items.Add(s);
            }
        }

      
    }
}
