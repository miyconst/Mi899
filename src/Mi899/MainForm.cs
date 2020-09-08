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
        private Control _lastControl;

        public MainForm()
        {
            _model = Model.LoadFromJson();
            InitializeComponent();
        }

        public void Open(UserControl control)
        {
            if (_lastControl != null)
            {
                tlpMain.Controls.Remove(_lastControl);
            }

            tlpMain.Controls.Add(control, 0, 1);
            control.Dock = DockStyle.Fill;
            _lastControl = control;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void msiExploreMotherboards_Click(object sender, EventArgs e)
        {
            Open(new MotherboardsPartialForm(this, _model));
        }

        private void msiExploreBioses_Click(object sender, EventArgs e)
        {
            Open(new BiosesPartialForm(_model));
        }

        private void msiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
