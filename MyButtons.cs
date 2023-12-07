using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace clavsiyanova
{
    internal class MyButtons
    {
        public string upValue;
        public string downValue;
        public TextBlock textBlock;
     
        public MyButtons(string upValue, string downValue, TextBlock textBlock)
        {
            this.upValue = upValue;
            this.downValue = downValue;
            this.textBlock = textBlock;
        }
    }
}
