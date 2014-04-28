using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Z5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static IEnumerable<long> Fib(int n)
        {
            int fibnm2 = 0;
            int fibnm1 = 1;
            yield return fibnm1;
            yield return fibnm2;
            for (int i = 1; i <= n; i++)
            {
                fibnm2 = fibnm1;
                fibnm1 += i;
                yield return fibnm1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //var xml = new XElement("repos",
            //    new XComment("repozytorium wita"),
            //    new XElement("Repo",
            //        new XAttribute("type", "git"),
            //        new XElement("url", "http://costam.pl"),
            //        new XElement("user", "user1")
            //    ),
            //    new XElement("Repo",
            //        new XAttribute("type","svn"),
            //        new XElement("url", "http://costam2.pl"),
            //        new XElement("user", "user2")
            //     ),
            //     new XElement("Repo",
            //         new XAttribute("type", "tfs"),
            //         new XElement("url", "http://costam2.pl"),
            //         new XElement("user", "user3")
            //     )
            //     );
            var xml = new XElement("fibs",
                Fib(10).Select(x => new XElement(
                    new XElement("value", x)
                ))
            );
            xml.Save("plik.xml");
            richTextBox1.Text = xml.ToString();
            foreach (var item in Fib(10))
            {
                richTextBox1.Text += item.ToString();
            }
   
        }
    }
}
