using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserTest
{
    [ComVisible(true)]
    public class Scripting
    {
        private string SomeData;
        public string GetSomeData()
        {
            return SomeData + " Something";
        }
        public void SetSomeData(string some)
        {
            SomeData = some;
        }
        public void Test(String message)
        {
            MessageBox.Show(message);
        }
    }
}
