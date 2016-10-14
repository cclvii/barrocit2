using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test250915
{
    public class Column
    {
        public bool visible;
        public bool enableToAdd;
        public string name;
        public bool editable;

        public Column(string name)
        {
            this.name = name;
            visible = true;
            enableToAdd = true;
            editable = true;
        }

        public Column(string name, bool editable)
        {
            this.name = name;
            visible = true;
            enableToAdd = true;
            this.editable = editable;
        }

        public Column(bool visible, bool enableToAdd, string name)
        {
            this.visible = visible;
            this.enableToAdd = enableToAdd;
            this.name = name;
            editable = true;
        }
    }
}
