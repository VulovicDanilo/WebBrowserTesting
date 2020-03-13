using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser.ObjectForScripting = new Scripting();
            string curDir = Directory.GetCurrentDirectory();
            this.webBrowser.Url = new Uri(String.Format("file:///{0}/html/randomHTML.html", curDir));
        }
    }
}
