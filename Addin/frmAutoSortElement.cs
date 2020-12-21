using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PdmsAddin
{
    public partial class FrmAutoSortElement : Form
    {
        public FrmAutoSortElement()
        {
            InitializeComponent();
        }

        public FrmAutoSortElement(IEnumerable<string> elements)
        {
            var separator = cbxSeparator.Text.ToCharArray()[0];
            var primaryField = cbxPrimaryField.Text;
            var secondaryField = cbxSecondaryField.Text;

            foreach (var element in elements)
            {
                var field = element.Split(separator);

            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            

        }
    }
}
