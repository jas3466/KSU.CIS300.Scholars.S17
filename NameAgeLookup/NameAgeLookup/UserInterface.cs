using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NameAgeLookup
{
    public partial class UserInterface : Form
    {
        private Person[] _people;

        public UserInterface()
        {
            InitializeComponent();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(uxOpenDialog.FileName);
                int size = Convert.ToInt32(sr.ReadLine());
                _people = new Person[size];
                for (int i = 0; i < size; i++)
                {
                    string line = sr.ReadLine();
                    string[] pieces = line.Split(',');
                    _people[i] = new Person(pieces[0], Convert.ToInt32(pieces[1]));
                }

                sr.Close();
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (uxSaveDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(uxSaveDialog.FileName);
            }
        }

        private void uxLookup_Click(object sender, EventArgs e)
        {
            string name = uxName.Text;
            for (int i = 0; i < _people.Length; i++)
            {
                if (_people[i].Name == name)
                {
                    uxAge.Text = _people[i].Age.ToString();
                }
            }
        }
    }
}
