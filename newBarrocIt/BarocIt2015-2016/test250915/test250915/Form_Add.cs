using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test250915
{
    public partial class Form_Add : Form
    {

        private List<TextBox> textBoxs;
        private Form_Main mainForm;
        private Table table;

        public Form_Add(Table table, Form_Main mainForm)
        {
            this.mainForm = mainForm;
            this.table = table;
            InitializeComponent();
            InitTextBox();
        }

        private void InitTextBox()
        {
            textBoxs = new List<TextBox>();

            Column[] columns = table.columns;
            int count = columns.Count();             

            for(int i = 0; i < count; i++)
            {
                if(columns[i].visible)
                {
                    TextBox tmp = new TextBox();
                    tmp.Location = new Point(20, 40 + (i * 60));
                    tmp.TabIndex = i;
                    tmp.Size = new Size(200, 20);
                    textBoxs.Add(tmp);
                    this.Controls.Add(tmp);

                    Label tmpLabel = new Label();
                    tmpLabel.Location = new Point(20, 20 + (i * 60));
                    tmpLabel.Size = new Size(200, 20);
                    tmpLabel.Text = columns[i].name;
                    this.Controls.Add(tmpLabel);

                    if (!columns[i].enableToAdd)
                    {
                        tmp.Enabled = false;
                    }  
                }     
            }

            Button goButton = new Button();
            goButton.Location = new Point(70, 80 + (60 * count));
            goButton.Size = new Size(100, 20);
            goButton.TabIndex = count;
            goButton.Name = "button_add";
            goButton.Click += button_add_Click;
            Controls.Add(goButton);
        }
        
        private void button_add_Click(object sender, EventArgs e)
        {
            Column[] columns = table.columns;
            object[] o = new object[columns.Count()];

            for(int i = 0; i < o.Count(); i ++)
            {
                if(columns[i].visible)
                    o[i] = textBoxs[i].Text;       
            }

            mainForm.AddRow(table, new Row(o));
            //this.Close();ffff
            
        } 
    }
}
