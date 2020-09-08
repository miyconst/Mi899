using Mi899.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace Mi899
{
    internal static class I18nExtensions
    {
        public static void ApplyI18n(this ToolStripMenuItem msi)
        {
            ToolStrip ms = msi.Owner;
            var parent = ms.GetI18nCompatibleParent();

            msi.Text = I18n.Get(msi.Text, parent.Name, msi.Name, nameof(ToolStripMenuItem.Text));
        }

        public static II18nCompatible GetI18nCompatibleParent(this Control control)
        {
            while (control != null)
            {
                if (control is II18nCompatible compatible)
                {
                    return compatible;
                }

                control = control.Parent;
            }

            return null;
        }
    }
}
