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
    public partial class Form_Edit : Form
    {
        private EditFormRow[] rows;
        private List<TextBox> textBoxs;
        private Form_Main mainForm;
        private Table table;
        private int index;

        public Form_Edit(Table table, Form_Main mainForm, int index)
        {
            this.mainForm = mainForm;
            this.table = table;
            this.index = index;
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            var count = table.columns.Count();

            rows = new EditFormRow[count];

           for (int i = 0; i < count; i++)
            {
                var tmpColumn = table.columns[1];

                if (tmpColumn.editable)
                    rows[i] = new EditFormRowEditable(Controls, tmpColumn.name, table.rows[index].datas[i].ToString().Trim(), i);
                else
                    rows[i] = new EditFormRow(Controls, tmpColumn.name, table.rows[index].datas[i].ToString().Trim(), i);
            }
        }



         class EditFormRow
        {
            protected Label nameLabel;
            protected Label oldValueLabel;
            protected int index;

            public EditFormRow(Control.ControlCollection controlCll, string nameTxt, string valueTxt, int index)
            {
                Init();
                this.index = index;
                          
                nameLabel.Text = nameTxt;
                oldValueLabel.Text = valueTxt;

                controlCll.Add(nameLabel);
                controlCll.Add(oldValueLabel);
            }

            protected virtual void Init()
            {
                nameLabel = new Label();
                nameLabel.Location = new Point(15, 50 + (index * 25));
                nameLabel.Size = new Size(127, 13);

                oldValueLabel = new Label();
                oldValueLabel.Location = new Point(160, 50 + (index * 25));
                oldValueLabel.Size = new Size(127, 13);
            }

        }



        class EditFormRowEditable : EditFormRow
        {
            private Button editButton;
            private TextBox nValueTB; // 'n' for 'new'
            private Button clearButton;           

            public EditFormRowEditable(Control.ControlCollection controlCll, string nameTxt, string valueTxt, int index) : base(controlCll, nameTxt, valueTxt, index)
            {
                controlCll.Add(editButton);
                controlCll.Add(nValueTB);
                controlCll.Add(clearButton);
            }

            protected override void Init()
            {
                base.Init();

                editButton = new Button();
                editButton.Location = new Point(300, 50 + (index * 25));
                editButton.Size = new Size(13, 23);
                editButton.Click += EditButtonOnClick;

                nValueTB = new TextBox();
                nValueTB.Location = new Point(300, 50 + (index * 25));
                nValueTB.Size = new Size(127, 32);
                nValueTB.Hide();
                nValueTB.Leave += NValueTBOnLeave;
                nValueTB.Click += NValueTBOnClick;
                nValueTB.TextChanged += NValueTBOnTextChanged;

                clearButton = new Button();
                clearButton.Location = new Point(425, +(index * 25));
                clearButton.Size = new Size(40, 23);
                clearButton.Hide();
                clearButton.Enabled = false;
                clearButton.Click += ClearButtonOnClick;
            }

            private void EditButtonOnClick(object sender, EventArgs e)
            {
                ((Button)sender).Hide();

                nValueTB.Show();
                clearButton.Show();
            }

            private void NValueTBOnLeave(object sender, EventArgs e)
            {
                if (((Button)sender).Text != oldValueLabel.Text)
                {
                    oldValueLabel.ForeColor = Color.Red;
                    ((Button)sender).ForeColor = Color.Green;
                }
                else
                    CleanEdit();
            }

            private void NValueTBOnClick(object sender, EventArgs e)
            {
                oldValueLabel.ForeColor = Color.Black;
                ((Button)sender).ForeColor = Color.Black;
            }

            private void NValueTBOnTextChanged(object sender, EventArgs e)
            {
                if (((Button)sender).Text != oldValueLabel.Text)
                {
                    clearButton.Show();
                }
                else
                    clearButton.Hide();
            }

            private void ClearButtonOnClick(object sender, EventArgs e)
            {
                CleanEdit();
            }

            private void CleanEdit()
            {
                nValueTB.Hide();
                nValueTB.Text = "";

                clearButton.Hide();
                editButton.Show();
            }
        }

    }
}
