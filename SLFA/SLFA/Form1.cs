﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SLFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToolStripButton clearBtn = new ToolStripButton();
            clearBtn.Text = "Clear";
            // устанавливаем обработчик нажатия
            clearBtn.Click += btn_Click;
            menuStrip1.Items.Add(clearBtn);
        }
 
        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Производится удаление");            
        }
    

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Name = "Resultat";
            f.Text = "Результаты";
            f.MdiParent = this;

            RichTextBox rtb = new RichTextBox();
            f.Controls.Add(rtb);
            rtb.Dock = DockStyle.Fill;
            f.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] form = MdiChildren;
            foreach (Form f in form)
                f.Close();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void стартToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
