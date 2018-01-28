using FW.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace HRTJ.Base
{
    public partial class RefComboBox : ComboBox
    {
        public RefComboBox()
        {
            InitializeComponent();
        }
        private string _DropDownName;
        public string DropDownName
        {
            get {return _DropDownName; }
            set { _DropDownName=value; }
        }

        private void bind()
        {
            if (!string.IsNullOrEmpty(DropDownName))
            {
                string startPath = Application.StartupPath;
                string path = Path.Combine(startPath, "XML/DropDownList.xml");
                XmlNode node = XmlHelp.GetNodeInfoByNodeName(path, "DropDowns");
                if (node != null && node.HasChildNodes && node.ChildNodes.Count > 0)
                {
                    foreach (XmlNode nodeDropDown in node.ChildNodes)
                    {
                        string name = Convert.ToString(nodeDropDown.Attributes["name"]);
                        if (DropDownName.Equals(name))
                        {
                            bindCombox(nodeDropDown);
                            break;
                        }
                    }
                }
            }
        }
        private void bindCombox(XmlNode node)
        {
            if (node == null)
            {
                return;
            }
            if (node != null && node.HasChildNodes && node.ChildNodes.Count > 0)
            {
                string defaultText = string.Empty;
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    string name = Convert.ToString(childNode.Attributes["name"]);
                    bool isDefault = false;
                    bool.TryParse(Convert.ToString(childNode.Attributes["isDefault"]), out isDefault);
                    
                    if (isDefault)
                    {
                        defaultText = name;
                    }
                    this.Items.Add(name);
                }
                if (!string.IsNullOrEmpty(defaultText))
                {
                    this.Text = defaultText;
                }
            }
        }
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
