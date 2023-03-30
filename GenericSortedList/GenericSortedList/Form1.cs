using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericSortedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Collections.Generic.SortedList<Int32, string> sl = new System.Collections.Generic.SortedList<Int32, string>();

            sl.Add(23, "Avion");
            sl.Add(43, " Brod");
            sl.Add(29, "Traktor");
            sl.Add(54, "Tocak0");
        }
        private void button2_Click(object sender, EventArgs e)
        {

            System.Collections.Generic.SortedList<Int32, string> sl = new System.Collections.Generic.SortedList<Int32, string>();

            sl.Add(23, "Avion");
            sl.Add(43, " Brod");
            sl.Add(29, "Traktor");
            sl.Add(54, "Tocak0");

            Int32 Key;
            Int32.TryParse(txtKey.Text, out Key);
            Text = sl[Key];

            Text = sl.Values[1];

            Text = sl.Keys[1].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            System.Collections.Generic.SortedList<Int32, string> sl = new System.Collections.Generic.SortedList<Int32, string>();

            sl.Add(23, "Avion");
            sl.Add(43, " Brod");
            sl.Add(29, "Traktor");
            sl.Add(54, "Tocak0");

            Int32 Key;
            Int32.TryParse(txtKey.Text, out Key);
            sl[Key] = "Test";
        }
        private void button11_Click(object sender, EventArgs e)
        {

            System.Collections.Generic.SortedList<Int32, string> sl = new System.Collections.Generic.SortedList<Int32, string>();

            sl.Add(23, "Avion");
            sl.Add(43, " Brod");
            sl.Add(29, "Traktor");
            sl.Add(54, "Tocak0");

            foreach (var item in sl)
            {
                keyListBox.Items.Add(item.Key);
                ValueListBox.Items.Add(item.Value);
            }

            foreach (KeyValuePair<Int32, string> item in sl)
            {
                keyListBox.Items.Add(item.Key);
                ValueListBox.Items.Add(item.Value);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            System.Collections.Generic.SortedList<Int32, string> sl = new System.Collections.Generic.SortedList<Int32, string>();

            sl.Add(23, "Avion");
            sl.Add(43, " Brod");
            sl.Add(29, "Traktor");
            sl.Add(54, "Tocak0");

            KeyValuePair <Int32, string> [] target_arrey = new KeyValuePair <int, string> [sl.Count()];
            target_arrey = sl.ToArray();

            Int32[] target_keys = new Int32[sl.Keys.Count()];
            target_keys = sl.Keys.ToArray();

            string[] target_values = new string [sl.Values.Count()];
            target_values = sl.Values.ToArray();
        }

    }
}
