using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_4_1
{
    // 1) inherit EventArgs
    class GoodsInfoEventArgs : EventArgs
    {
        // 2) declare property GoodsName
        // think about get and set attributes
        public string GoodsName {get; set;}

        // 3) declare constructor to initialize GoodsName
        public GoodsInfoEventArgs(string name)
        {
            this.GoodsName = name;
        }
    }
}

