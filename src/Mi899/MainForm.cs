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
        private I18n _i18n;
        private Model _model;
        private Control _lastControl;
        private MotherboardPartialForm _motherboardPartialForm;
        private MotherboardsPartialForm _motherboardsPartialForm;

        public MainForm(I18n i18n, Model model, MotherboardsPartialForm motherboardsPartialForm, MotherboardPartialForm motherboardPartialForm)
        {
            _i18n = i18n ?? throw new ArgumentNullException(nameof(i18n));
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _motherboardPartialForm = motherboardPartialForm ?? throw new ArgumentNullException(nameof(motherboardPartialForm));
            _motherboardsPartialForm = motherboardsPartialForm ?? throw new ArgumentNullException(nameof(motherboardsPartialForm));

            _motherboardsPartialForm.MotherboardSelected += MotherboardsPartialForm_MotherboardSelected;

            InitializeComponent();
        }

        private void MotherboardsPartialForm_MotherboardSelected(object sender, IMotherboard e)
        {
            _motherboardPartialForm.LoadData(e);
            Open(_motherboardPartialForm);
        }

        public void ApplyI18n(I18n i18n)
        {
            Text = i18n.Get(Text, Name, nameof(Text));
            this.ApplyI18nToChildren(i18n);
        }

        public IEnumerable<IComponent> SelectI18nCompatibleComponents()
        {
            return new List<Component>()
            {
                msiExit,
                msiExplore,
                msiExploreBioses,
                msiExploreMotherboards,
                msiFile,
                msiFileReadMe,
                msiHelp,
                msiHelpAbout,
                msiHelpHowToRamTimings,
                msiTools,
                msiToolsAfuWin,
                msiToolsFpt,
                msiToolsHowTo,
                msiToolsHowToTurboUnlock,
                tsslVersion,
                _motherboardsPartialForm
            };
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
            ApplyI18n(_i18n);
        }

        private void msiExploreMotherboards_Click(object sender, EventArgs e)
        {
            Open(_motherboardsPartialForm);
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
            _i18n.Dump();
#endif
        }

        private void msiLanguageUkrainian_Click(object sender, EventArgs e)
        {
            _i18n.Language = I18n.LanguageUa;
            ApplyI18n(_i18n);
        }

        private void msiLanguageEnglish_Click(object sender, EventArgs e)
        {
            _i18n.Language = I18n.LanguageEn;
            ApplyI18n(_i18n);
        }
    }
}
