using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialog
{
    internal class WindowsDialog:Dialog
    {
        public override IButton createButton() { return new WindowsButton(); }
    }
}
