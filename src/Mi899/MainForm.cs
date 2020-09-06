using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mi899.Data;

namespace Mi899
{
    public partial class MainForm : Form
    {
        private Model _model;

        public MainForm()
        {
            _model = Model.LoadFromJson();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void msiExploreMotherboards_Click(object sender, EventArgs e)
        {
            MotherboardsPartialForm frm = new MotherboardsPartialForm(_model);
            tlpMain.Controls.Add(frm, 0, 1);
            frm.Dock = DockStyle.Fill;
        }
    }
}
