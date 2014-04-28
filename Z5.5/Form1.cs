using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z5._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var feed = XDocument.Load(@"http://sport.wp.pl/kat,1738,rss.xml");

            var items = feed.Descendants("item")
                .Select(x => new
                {
                    Title = x.Element("title").Value,
                    Description = x.Element("description").Value,
                    PublicationDate = x.Element("pubDate").Value
                });

            foreach (var item in items)
            {

                richTextBox1.Text += "------------------- ";
                richTextBox1.Text += item.PublicationDate + "  \nTytuł: ";
                richTextBox1.Text += item.Title + "\nTreść wiadomości: ";
                richTextBox1.Text += item.Description;
                richTextBox1.Text += "\n-------------------\n";
            }
        }
    }
}
