using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_03_Tugas
{
    public partial class FormTugas : Form
    {
        public FormTugas()
        {
            InitializeComponent();
        }
        
        public void MoveAllItems(ListBox listBoxKiri, ListBox listBoxkanan)
        {
            listBoxkanan.Items.AddRange(listBoxKiri.Items);
            listBoxKiri.Items.Clear();
        }
        public void MoveListBoxItems(ListBox listBoxKiri, ListBox listBoxkanan)
        {
            for(int i = listBoxKiri.SelectedItems.Count-1;i>=0 ; i--)
            {
                listBoxkanan.Items.Add(listBoxKiri.SelectedItems[i]);
                listBoxKiri.Items.RemoveAt(listBoxKiri.SelectedIndices[i]);
            }
        }

        private void textBoxData_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            if (comboBoxMode.SelectedItem == null)
            {
                MessageBox.Show("Mode belum dipilih");
                
            }
            else if (comboBoxMode.SelectedItem == "Add")
            {
                listBoxKiri.Items.Add(textBoxData.Text);
            }
            else if (comboBoxMode.SelectedItem == "Replace")
            {
                if (listBoxKiri.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Replace hanya dapat mengganti 1 data saja");
                }
                else if (listBoxKiri.SelectedItems.Count==1)
                {
                    int karep = listBoxKiri.SelectedIndex;
                    listBoxKiri.Items.RemoveAt(karep);
                    listBoxKiri.Items.Insert(karep, textBoxData.Text);
                }
            }
            textBoxData.Focus();
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonKananPol_Click(object sender, EventArgs e)
        {
            MoveAllItems(listBoxKiri, listBoxkanan);
        }

        private void buttonKanan_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(listBoxKiri,listBoxkanan);
        }

        private void buttonKiri_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(listBoxkanan, listBoxKiri);
        }

        private void buttonKiriPol_Click(object sender, EventArgs e)
        {
            MoveAllItems(listBoxkanan, listBoxKiri);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            if (listBoxKiri.SelectedItems.Count > 0)
            {
                for (int i = listBoxKiri.SelectedItems.Count; i>0 ; i--)
                {
                    listBoxKiri.Items.RemoveAt(listBoxKiri.SelectedIndex);
                }
            }
            if (listBoxkanan.SelectedItems.Count > 0)
            {
                for (int i = listBoxkanan.SelectedItems.Count; i > 0; i--)
                {
                    listBoxkanan.Items.RemoveAt(listBoxkanan.SelectedIndex);
                }
            }
        }

        private void checkBoxBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBlock.Checked == true)
            {
                buttonKananPol.Enabled = false;
                buttonKanan.Enabled = false;
                buttonKiri.Enabled = false;
                buttonKiriPol.Enabled = false;
                buttonX.Enabled = false;
            }
            else if (checkBoxBlock.Checked == false)
            {
                buttonKananPol.Enabled = true;
                buttonKanan.Enabled = true;
                buttonKiri.Enabled = true;
                buttonKiriPol.Enabled = true;
                buttonX.Enabled = true;
            }
        }

    }
}
