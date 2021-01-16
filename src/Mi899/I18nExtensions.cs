using Mi899.Data;
using System;
using System.Windows.Forms;

namespace Mi899
{
    internal static class I18nExtensions
    {
        public static void ApplyI18nToChildren(this II18nCompatible control, I18n i18n)
        {
            foreach (var component in control.SelectI18nCompatibleComponents())
            {
                switch (component)
                {
                    case II18nCompatible i18NCompatible:
                        i18NCompatible.ApplyI18n(i18n);
                        break;
                    case ToolStripMenuItem toolStripMenuItem:
                        toolStripMenuItem.ApplyI18nToProperties(i18n);
                        break;
                    case Label label:
                        label.ApplyI18nToProperties(i18n);
                        break;
                    case ToolStripStatusLabel toolStripStatusLabel:
                        toolStripStatusLabel.ApplyI18nToProperties(i18n);
                        break;
                    case DataGridViewButtonColumn dataGridViewButtonColumn:
                        dataGridViewButtonColumn.ApplyI18nToProperties(i18n);
                        break;
                    case DataGridViewColumn dataGridViewColumn:
                        dataGridViewColumn.ApplyI18nToProperties(i18n);
                        break;
                    case Button button:
                        button.ApplyI18nToProperties(i18n);
                        break;
                    case CheckBox checkBox:
                        checkBox.ApplyI18nToProperties(i18n);
                        break;
                    case TabPage tabPage:
                        tabPage.ApplyI18nToProperties(i18n);
                        break;
                    default:
                        throw new NotImplementedException($"Unable to apply I18n to a component of type {component.GetType()}.");
                }
            }
        }

        private static void ApplyI18nToProperties(this ToolStripMenuItem item, I18n i18n)
        {
            var ms = item.Owner;
            var parent = ms.GetI18nCompatibleParent();

            item.Text = i18n.Get(item.Text, parent.Name, item.Name, nameof(ToolStripMenuItem.Text));
        }

        private static void ApplyI18nToProperties(this ToolStripItem label, I18n i18n)
        {
            var ts = label.Owner;
            var parent = ts.GetI18nCompatibleParent();

            label.Text = i18n.Get(label.Text, parent.Name, label.Name, nameof(ToolStripStatusLabel.Text));
        }

        private static void ApplyI18nToProperties(this Label label, I18n i18n)
        {
            var parent = label.GetI18nCompatibleParent();

            label.Text = i18n.Get(label.Text, parent.Name, label.Name, nameof(ToolStripStatusLabel.Text));
        }

        private static void ApplyI18nToProperties(this Button button, I18n i18n)
        {
            var parent = button.GetI18nCompatibleParent();

            button.Text = i18n.Get(button.Text, parent.Name, button.Name, nameof(ToolStripStatusLabel.Text));
        }

        private static void ApplyI18nToProperties(this CheckBox checkBox, I18n i18n)
        {
            var parent = checkBox.GetI18nCompatibleParent();

            checkBox.Text = i18n.Get(checkBox.Text, parent.Name, checkBox.Name, nameof(ToolStripStatusLabel.Text));
        }

        private static void ApplyI18nToProperties(this DataGridViewColumn dataGridViewColumn, I18n i18n)
        {
            var parent = dataGridViewColumn.DataGridView.GetI18nCompatibleParent();

            dataGridViewColumn.HeaderText = i18n.Get(dataGridViewColumn.HeaderText, parent.Name, dataGridViewColumn.DataGridView.Name, dataGridViewColumn.Name, nameof(DataGridViewColumn.HeaderText));
            dataGridViewColumn.ToolTipText = i18n.Get(dataGridViewColumn.ToolTipText, parent.Name, dataGridViewColumn.DataGridView.Name, dataGridViewColumn.Name, nameof(DataGridViewColumn.ToolTipText));
        }

        private static void ApplyI18nToProperties(this DataGridViewButtonColumn dataGridViewButtonColumn, I18n i18n)
        {
            var parent = dataGridViewButtonColumn.DataGridView.GetI18nCompatibleParent();

            dataGridViewButtonColumn.Text = i18n.Get(dataGridViewButtonColumn.Text, parent.Name, dataGridViewButtonColumn.DataGridView.Name, dataGridViewButtonColumn.Name, nameof(DataGridViewButtonColumn.Text));
            dataGridViewButtonColumn.HeaderText = i18n.Get(dataGridViewButtonColumn.HeaderText, parent.Name, dataGridViewButtonColumn.DataGridView.Name, dataGridViewButtonColumn.Name, nameof(DataGridViewButtonColumn.HeaderText));
            dataGridViewButtonColumn.ToolTipText = i18n.Get(dataGridViewButtonColumn.ToolTipText, parent.Name, dataGridViewButtonColumn.DataGridView.Name, dataGridViewButtonColumn.Name, nameof(DataGridViewButtonColumn.ToolTipText));
        }

        public static void ApplyI18nToProperties(this TabPage tabPage, I18n i18n)
        {
            var parent = tabPage.GetI18nCompatibleParent();
            tabPage.Text = i18n.Get(tabPage.Text, parent.Name, tabPage.Name, nameof(TabPage.Text));
        }

        public static II18nCompatible GetI18nCompatibleParent(this Control control)
        {
            while (control != null)
            {
                switch (control)
                {
                    case II18nCompatible compatible:
                        return compatible;
                    case ToolStripDropDown toolStripDropDown:
                        control = toolStripDropDown.OwnerItem.Owner;
                        break;
                    default:
                        control = control.Parent;
                        break;
                }
            }

            return null;
        }
    }
}
