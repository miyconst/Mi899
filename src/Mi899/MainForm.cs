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

        private void Open(UserControl control)
        {
            tlpMain.Controls.Add(control, 0, 1);
            control.Dock = DockStyle.Fill;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void msiExploreMotherboards_Click(object sender, EventArgs e)
        {
            Open(new MotherboardsPartialForm(_model));
        }

        private void msiExploreBioses_Click(object sender, EventArgs e)
        {
            Open(new BiosesPartialForm(_model));
        }
    }
}
