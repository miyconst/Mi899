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
        public static void ApplyI18nToChildren(this II18nCompatible control, I18n i18n)
        {
            foreach (var c in control.SelectI18nCompatibleComponents())
            {
                switch (c)
                {
                    case II18nCompatible child:
                        child.ApplyI18n(i18n);
                        break;
                    case ToolStripMenuItem item:
                        item.ApplyI18nToProperties(i18n);
                        break;
                    case Label label:
                        label.ApplyI18nToProperties(i18n);
                        break;
                    case ToolStripStatusLabel tssl:
                        tssl.ApplyI18nToProperties(i18n);
                        break;
                    case DataGridViewButtonColumn dgvbc:
                        dgvbc.ApplyI18nToProperties(i18n);
                        break;
                    case DataGridViewColumn dgvc:
                        dgvc.ApplyI18nToProperties(i18n);
                        break;
                    default:
                        throw new NotImplementedException($"Unable to apply I18n to a component of type {c.GetType()}.");
                }
            }
        }

        public static void ApplyI18nToProperties(this ToolStripMenuItem item, I18n i18n)
        {
            ToolStrip ms = item.Owner;
            II18nCompatible parent = ms.GetI18nCompatibleParent();

            item.Text = i18n.Get(item.Text, parent.Name, item.Name, nameof(ToolStripMenuItem.Text));
        }

        public static void ApplyI18nToProperties(this ToolStripStatusLabel label, I18n i18n)
        {
            ToolStrip ts = label.Owner;
            II18nCompatible parent = ts.GetI18nCompatibleParent();

            label.Text = i18n.Get(label.Text, parent.Name, label.Name, nameof(ToolStripStatusLabel.Text));
        }

        public static void ApplyI18nToProperties(this Label label, I18n i18n)
        {
            II18nCompatible parent = label.GetI18nCompatibleParent();

            label.Text = i18n.Get(label.Text, parent.Name, label.Name, nameof(ToolStripStatusLabel.Text));
        }

        public static void ApplyI18nToProperties(this DataGridViewColumn dgvc, I18n i18n)
        {
            II18nCompatible parent = dgvc.DataGridView.GetI18nCompatibleParent();

            dgvc.HeaderText = i18n.Get(dgvc.HeaderText, parent.Name, dgvc.DataGridView.Name, dgvc.Name, nameof(DataGridViewColumn.HeaderText));
            dgvc.ToolTipText = i18n.Get(dgvc.ToolTipText, parent.Name, dgvc.DataGridView.Name, dgvc.Name, nameof(DataGridViewColumn.ToolTipText));
        }

        public static void ApplyI18nToProperties(this DataGridViewButtonColumn dgvbc, I18n i18n)
        {
            II18nCompatible parent = dgvbc.DataGridView.GetI18nCompatibleParent();

            dgvbc.Text = i18n.Get(dgvbc.Text, parent.Name, dgvbc.DataGridView.Name, dgvbc.Name, nameof(DataGridViewButtonColumn.Text));
            dgvbc.HeaderText = i18n.Get(dgvbc.HeaderText, parent.Name, dgvbc.DataGridView.Name, dgvbc.Name, nameof(DataGridViewButtonColumn.HeaderText));
            dgvbc.ToolTipText = i18n.Get(dgvbc.ToolTipText, parent.Name, dgvbc.DataGridView.Name, dgvbc.Name, nameof(DataGridViewButtonColumn.ToolTipText));
        }

        public static II18nCompatible GetI18nCompatibleParent(this Control control)
        {
            while (control != null)
            {
                if (control is II18nCompatible compatible)
                {
                    return compatible;
                }

                if (control is ToolStripDropDown tsdd)
                {
                    control = tsdd.OwnerItem.Owner;
                }
                else
                {
                    control = control.Parent;
                }
            }

            return null;
        }
    }
}
