using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mi899.Data;
using System.Linq;

namespace Mi899
{
    public partial class MotherboardPartialForm : UserControl
    {
        private IMotherboard _motherboard;

        public MotherboardPartialForm(IMotherboard motherboard)
        {
            _motherboard = motherboard ?? throw new ArgumentNullException(nameof(motherboard));
            InitializeComponent();
        }

        private void InitializeExtraComponent()
        {
            picMotherboard.ImageLocation = _motherboard.Images.FirstOrDefault()?.Url;
        }
    }
}
