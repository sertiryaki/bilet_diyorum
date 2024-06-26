﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biletdiyorum
{
    public partial class bilet : Form
    {
        public bilet()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lsbIller.Items.Add(txtIl.Text);
            txtIl.Text = "";
            txtIl.Focus();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            var secili = lsbIller.SelectedItems;
            var mesaj = "Seçilen Öge:  ";
            foreach (var item in secili)
            {
                mesaj += $"\n{item}";
            }
            MessageBox.Show(mesaj);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lsbIller.SelectedItems.Count > 0)
            {
                var secili = lsbIller.SelectedItems;

                for (int i = secili.Count - 1; i >= 0; i--)
                {
                    var silincek = secili[i];
                    lsbIller.Items.Remove(silincek);
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapın");
            }
        }

        private void bilet_DragEnter(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.Move;
        }

        private void bilet_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.All;
        }

        int index = 0;
        private void bilet_MouseDown(object sender, MouseEventArgs e)
        {
            lsbIller = sender as ListBox;
            Point kor_nokta = new Point(e.X, e.Y);
            index = lsbIller.IndexFromPoint(kor_nokta);
            if (index == -1)
                return;
            if (e.Button == MouseButtons.Left)
                lsbIller.DoDragDrop(lsbIller.Items[index].ToString(), DragDropEffects.All);
        }

        private void lsbIller2_DragDrop(object sender, DragEventArgs e)
        {
            ListBox lsbIller2 = sender as ListBox;
            if (index == -1)
                return;

            if (!lsbIller2.Items.Contains(lsbIller.Items[index]) && lsbIller != lsbIller2)
            {
                lsbIller2.Items.Add(lsbIller.Items[index]);
                lsbIller.Items.RemoveAt(index);
            }
            index = -1;
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            if (lsbIller.SelectedItems.Count > 0)
            {
                var sectim = lsbIller.SelectedIndices;
                for (int i = sectim.Count - 1; i >= 0; i--)
                {
                    var silin = sectim[i];
                    lsbIller2.Items.Add(lsbIller.Items[silin]);
                    lsbIller.Items.RemoveAt(silin);

                }
            }
            else
            {
                MessageBox.Show("Seçim Yap");
            }
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            var item = lsbIller2.SelectedItems;
            var secilen = lsbIller2.SelectedIndices;
            for (int i = 0; i < secilen.Count; i++)
            {
                lsbIller.Items.Add(lsbIller2.Items[secilen[i]]);
                lsbIller2.Items.RemoveAt(i);
            }
        }
    }
}
