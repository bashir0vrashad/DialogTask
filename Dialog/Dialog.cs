using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dialog
{
    internal abstract class Dialog
    {
        public void render() { }
        public abstract IButton createButton();
    }
}
