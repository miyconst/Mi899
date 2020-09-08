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
    public partial class MainForm : Form, II18nCompatible
    {
        private Model _model;
        private Control _lastControl;

        public MainForm()
        {
            _model = Model.LoadFromJson();
            InitializeComponent();
            InitializeI18n();
        }

        public   void InitializeI18n()
        {
            Text = I18n.Get(Text, Name, nameof(Text));
            tsslVersion.Text = I18n.Get(tsslVersion.Text, Name, tsslVersion.Name, nameof(tsslVersion.Text));
            msiFile.ApplyI18n();
            msiExplore.ApplyI18n();
            msiTools.ApplyI18n();
            msiHelp.ApplyI18n();
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
#if DEBUG
            I18n.Dump();
#endif
        }

        private void msiLanguageUkrainian_Click(object sender, EventArgs e)
        {
            I18n.Language = I18n.LanguageUa;
            InitializeI18n();
        }

        private void msiLanguageEnglish_Click(object sender, EventArgs e)
        {
            I18n.Language = I18n.LanguageEn;
            InitializeI18n();
        }
    }
}
