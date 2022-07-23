using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SaveGamesEditor.Custom_Controls
{
    public partial class UserControl_HashCodesSelector : UserControl
    {
        public UserControl_HashCodesSelector()
        {
            InitializeComponent();
        }

        private void ComboBox_HashCodeLabel_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (ComboBox_HashCodeLabel.SelectedValue != null)
            {
                string selectedData = ComboBox_HashCodeLabel.SelectedValue.ToString();
                if (uint.TryParse(selectedData, out uint selectedHashCode))
                {
                    TextBox_HashCode.Text = "0x" + selectedHashCode.ToString("X8");
                }
            }
        }

        private void TextBox_HashCode_Validated(object sender, System.EventArgs e)
        {
            if (TextBox_HashCode.Text.Length > 0)
            {
                if (Regex.IsMatch(TextBox_HashCode.Text, @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"))
                {
                    uint hexValue = Convert.ToUInt32(TextBox_HashCode.Text, 16);
                    if (ComboBox_HashCodeLabel.SelectedValue != (object)hexValue)
                    {
                        ComboBox_HashCodeLabel.SelectedValue = hexValue;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid hexadecimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBox_HashCode.Clear();
                    TextBox_HashCode.Focus();
                }
            }
        }

        internal void SetDictionaryToCombobox(Dictionary<uint, string> dictionaryData)
        {
            ComboBox_HashCodeLabel.DataSource = new BindingSource(dictionaryData, null);
            ComboBox_HashCodeLabel.ValueMember = "Key";
            ComboBox_HashCodeLabel.DisplayMember = "Value";
        }
    }
}
