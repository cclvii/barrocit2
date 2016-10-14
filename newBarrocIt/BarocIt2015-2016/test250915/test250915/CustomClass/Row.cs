using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test250915
{
    public class Row
    {
        public object[] datas { get; private set; }

        public Row(object[] datas)
        {
            this.datas = datas;
        }

        public int CountData()
        {
            return datas.Count();
        }

        public bool IsNull()
        {
            foreach(var v in datas)
            {
                if (v != null)
                    return false;
            }

            return true;
        }
   
    }
}
