using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test250915
{
     public class Table
    {
        public List<Row> rows { get; private set; }
        public Column[] columns { get; private set; }
        public string name { get; private set; }
        public string sqlCmdInsert;
        public string sqlCmdUpdate;

        public Table(Column[] columns, string name, string sqlCmdInsert, string sqlCmdUpdate)
        {
            this.columns = columns;
            this.name = name;
            this.sqlCmdInsert = sqlCmdInsert;
            this.sqlCmdUpdate = sqlCmdUpdate;
        }

        public void ClearRows()
        {
            rows = new List<Row>();
        }

        public void AddRows(Row nRow)
        {
            if (nRow.CountData() == columns.Count())
                rows.Add(nRow);
        }
        
    }
}
