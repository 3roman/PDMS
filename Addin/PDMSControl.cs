using System;
using System.Windows.Forms;
using Aveva.Pdms.Shared;
using Aveva.Pdms.Database;
using Aveva.Pdms.Utilities.CommandLine;
using System.Linq;

namespace PDMSAddin
{
    public partial class PdmsControl : UserControl
    {
        public PdmsControl()
        {
            InitializeComponent();
        }

        private static DbElement GetElementByName(object elementName)
        {
            return DbElement.GetElement(Convert.ToString(elementName));
        }

        private void BtnManualUnsetMTO_Click(object sender, EventArgs e)
        {
            foreach (var item in lstElements1.Items)
            {
                var ce = GetElementByName(item);
                ce.SetAttribute(DbAttributeInstance.MTOC, "DOTD");
            }
        }

        private void BtnManualSetMTO_Click(object sender, EventArgs e)
        {
            foreach (var item in lstElements1.Items)
            {
                var ce = GetElementByName(item);
                ce.SetAttributeDefault(DbAttributeInstance.MTOC);
            }
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            lstElements1.Items.Clear();
            txtCE.Clear();
        }

        private void BtnAddCE_Click(object sender, EventArgs e)
        {
            var elementName = CurrentElement.Element.GetString(DbAttributeInstance.NAME);
            lstElements1.Items.Add(elementName);
            txtCE.Text = elementName;
        }

        private void LstElements1_DoubleClick(object sender, EventArgs e)
        {
            var ce = GetElementByName(lstElements1.SelectedItem);
            CurrentElement.Element = ce;
            MessageBox.Show(ce.GetAsString(DbAttributeInstance.MTOC));
        }

        private void BtnSetPipeMTO_Click(object sender, EventArgs e)
        {
            var ce = CurrentElement.Element;
            var ceType = ce.GetElementType();
            if (DbElementTypeInstance.PIPE == ceType)
            {
                var branches = ce.Members(DbElementTypeInstance.BRANCH);
                foreach (var branch in branches)
                {
                    foreach (var element in branch.Members())
                    {
                        element.SetAttributeDefault(DbAttributeInstance.MTOC);
                    }
                }
                return;
            }

            if (DbElementTypeInstance.BRANCH == ceType)
            {
                foreach (var element in ce.Members())
                {
                    element.SetAttributeDefault(DbAttributeInstance.MTOC);
                }
                return;
            }

            MessageBox.Show("请选择PIPE或者BRANCH", "报错", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnUnsetPipeMTO_Click(object sender, EventArgs e)
        {
            var ce = CurrentElement.Element;
            var ceType = ce.GetElementType();
            if (DbElementTypeInstance.PIPE == ceType)
            {
                var branches = ce.Members(DbElementTypeInstance.BRANCH);
                foreach (var branch in branches)
                {
                    foreach (var element in branch.Members())
                    {
                        element.SetAttribute(DbAttributeInstance.MTOC, "DOTD");
                    }
                }
                return;
            }

            if (DbElementTypeInstance.BRANCH == ceType)
            {
                foreach (var element in ce.Members())
                {
                    element.SetAttribute(DbAttributeInstance.MTOC, "DOTD");
                }
                return;
            }
            MessageBox.Show("请选择PIPE或者BRANCH", "报错", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnUnsetTubeMTO_Click(object sender, EventArgs e)
        {
            CurrentElement.Element.SetAttribute(DbAttributeInstance.MTOT, "DOTD");
        }

        private void BtnSetTubeMTO_Click(object sender, EventArgs e)
        {
            CurrentElement.Element.SetAttributeDefault(DbAttributeInstance.MTOT);
        }

        private void BtnUnsetNozzMTO_Click(object sender, EventArgs e)
        {
            var ce = CurrentElement.Element;
            var ceType = ce.GetElementType();

            if (DbElementTypeInstance.BRANCH == ceType)
            {
                var hElementType = ce.GetElement(DbAttributeInstance.HREF).GetElementType();
                var tElementType = ce.GetElement(DbAttributeInstance.TREF).GetElementType();
                var elements = ce.Members();
                if (hElementType == DbElementTypeInstance.NOZZLE)
                {
                    if (elements[0].GetElementType() == DbElementTypeInstance.GASKET)
                    {
                        elements[0].SetAttribute(DbAttributeInstance.MTOC, "DOTD");

                    }
                    if (elements[1].GetElementType() == DbElementTypeInstance.FLANGE)
                    {
                        elements[1].SetAttribute(DbAttributeInstance.MTOC, "DOTD");
                    }

                }
                if (tElementType == DbElementTypeInstance.NOZZLE)
                {
                    if (elements[elements.Length - 1].GetElementType() == DbElementTypeInstance.GASKET)
                    {
                        elements[elements.Length - 1].SetAttribute(DbAttributeInstance.MTOC, "DOTD");

                    }
                    if (elements[elements.Length - 2].GetElementType() == DbElementTypeInstance.FLANGE)
                    {
                        elements[elements.Length - 2].SetAttribute(DbAttributeInstance.MTOC, "DOTD");
                    }
                }

                return;
            }
            if (DbElementTypeInstance.PIPE == ceType)
            {
                var branches = ce.Members(DbElementTypeInstance.BRANCH);
                foreach (var branch in branches)
                {
                    var hElementType = branch.GetElement(DbAttributeInstance.HREF).GetElementType();
                    var tElementType = branch.GetElement(DbAttributeInstance.TREF).GetElementType();
                    var elements = branch.Members();
                    if (hElementType == DbElementTypeInstance.NOZZLE)
                    {
                        if (elements[0].GetElementType() == DbElementTypeInstance.GASKET)
                        {
                            elements[0].SetAttribute(DbAttributeInstance.MTOC, "DOTD");

                        }
                        if (elements[1].GetElementType() == DbElementTypeInstance.FLANGE)
                        {
                            elements[1].SetAttribute(DbAttributeInstance.MTOC, "DOTD");
                        }

                    }
                    if (tElementType == DbElementTypeInstance.NOZZLE)
                    {
                        if (elements[elements.Length - 1].GetElementType() == DbElementTypeInstance.GASKET)
                        {
                            elements[elements.Length - 1].SetAttribute(DbAttributeInstance.MTOC, "DOTD");

                        }
                        if (elements[elements.Length - 2].GetElementType() == DbElementTypeInstance.FLANGE)
                        {
                            elements[elements.Length - 2].SetAttribute(DbAttributeInstance.MTOC, "DOTD");
                        }
                    }
                }
                return;
            }
            MessageBox.Show("请选择PIPE或者BRANCH", "报错", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnSetNozzMTO_Click(object sender, EventArgs e)
        {
            var ce = CurrentElement.Element;
            var ceType = ce.GetElementType();

            if (DbElementTypeInstance.BRANCH == ceType)
            {
                var hElementType = ce.GetElement(DbAttributeInstance.HREF).GetElementType();
                var tElementType = ce.GetElement(DbAttributeInstance.TREF).GetElementType();
                var elements = ce.Members();
                if (hElementType == DbElementTypeInstance.NOZZLE)
                {
                    if (elements[0].GetElementType() == DbElementTypeInstance.GASKET)
                    {
                        elements[0].SetAttributeDefault(DbAttributeInstance.MTOC);

                    }
                    if (elements[1].GetElementType() == DbElementTypeInstance.FLANGE)
                    {
                        elements[1].SetAttributeDefault(DbAttributeInstance.MTOC);
                    }

                }
                if (tElementType == DbElementTypeInstance.NOZZLE)
                {
                    if (elements[elements.Length - 1].GetElementType() == DbElementTypeInstance.GASKET)
                    {
                        elements[elements.Length - 1].SetAttributeDefault(DbAttributeInstance.MTOC);

                    }
                    if (elements[elements.Length - 2].GetElementType() == DbElementTypeInstance.FLANGE)
                    {
                        elements[elements.Length - 2].SetAttributeDefault(DbAttributeInstance.MTOC);
                    }
                }

                return;
            }
            if (DbElementTypeInstance.PIPE == ceType)
            {
                var branches = ce.Members(DbElementTypeInstance.BRANCH);
                foreach (var branch in branches)
                {
                    var hElementType = branch.GetElement(DbAttributeInstance.HREF).GetElementType();
                    var tElementType = branch.GetElement(DbAttributeInstance.TREF).GetElementType();
                    var elements = branch.Members();
                    if (hElementType == DbElementTypeInstance.NOZZLE)
                    {
                        if (elements[0].GetElementType() == DbElementTypeInstance.GASKET)
                        {
                            elements[0].SetAttributeDefault(DbAttributeInstance.MTOC);

                        }
                        if (elements[1].GetElementType() == DbElementTypeInstance.FLANGE)
                        {
                            elements[1].SetAttributeDefault(DbAttributeInstance.MTOC);
                        }

                    }
                    if (tElementType == DbElementTypeInstance.NOZZLE)
                    {
                        if (elements[elements.Length - 1].GetElementType() == DbElementTypeInstance.GASKET)
                        {
                            elements[elements.Length - 1].SetAttributeDefault(DbAttributeInstance.MTOC);

                        }
                        if (elements[elements.Length - 2].GetElementType() == DbElementTypeInstance.FLANGE)
                        {
                            elements[elements.Length - 2].SetAttributeDefault(DbAttributeInstance.MTOC);
                        }
                    }
                }
                return;
            }
            MessageBox.Show("请选择PIPE或者BRANCH", "报错", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnSetOwner2_Click(object sender, EventArgs e)
        {
            lstElements2.Items.Clear();
            var ce = CurrentElement.Element;
            txtOwner2.Text = ce.GetString(DbAttributeInstance.NAME);
            foreach (var member in ce.Members())
            {
                lstElements2.Items.Add(member.GetString(DbAttributeInstance.NAME));
            }
        }

        private void BtnAddCE2_Click(object sender, EventArgs e)
        {
            var element = CurrentElement.Element;
            var nextElement = CurrentElement.Element.Next();
            var elementName = element.GetString(DbAttributeInstance.NAME);
            lstElements2.Items.Insert(0, elementName);

            var owner = GetElementByName(txtOwner2.Text);
            CurrentElement.Element = owner;
            var pdmsCommand = "INCL /" + element;
            Command.CreateCommand(pdmsCommand).RunInPdms();

            CurrentElement.Element = nextElement;

        }

        private void BtnSetOwner3_Click(object sender, EventArgs e)
        {
            lstElements3.Items.Clear();
            var ce = CurrentElement.Element;
            txtOwner3.Text = ce.GetString(DbAttributeInstance.NAME);
            foreach (var member in ce.Members())
            {
                lstElements3.Items.Add(member.GetString(DbAttributeInstance.NAME));
            }
        }

        private void BtnMoveUp3_Click(object sender, EventArgs e)
        {
            var item = lstElements3.SelectedItem;
            if (null == item)
            {
                MessageBox.Show("请选择一个元素", "报错", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            var ce = GetElementByName(item);
            var previousElement = ce.Previous;
            var pdmsCommand = $"Reorder /{previousElement} After /{ce}";
            Command.CreateCommand(pdmsCommand).RunInPdms();

            var index = lstElements3.SelectedIndex;
            if (index == 0)
                return;
            lstElements3.Items.Remove(item ?? throw new InvalidOperationException());
            lstElements3.Items.Insert(index - 1, item);
            lstElements3.SelectedIndex = index - 1;
        }

        private void BtnMoveDown3_Click(object sender, EventArgs e)
        {
            var item = lstElements3.SelectedItem;
            if (null == item)
            {
                MessageBox.Show("请选择一个元素", "报错", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            var ce = GetElementByName(item);
            var nextElement = ce.Next();
            var pdmsCommand = $"Reorder /{nextElement} Before /{ce}";
            Command.CreateCommand(pdmsCommand).RunInPdms();

            var index = lstElements3.SelectedIndex;
            if (index == lstElements3.Items.Count - 1)
                return;
            lstElements3.Items.Remove(item ?? throw new InvalidOperationException());
            lstElements3.Items.Insert(index + 1, item);
            lstElements3.SelectedIndex = index + 1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}