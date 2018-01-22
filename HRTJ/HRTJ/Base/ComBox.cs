using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

using System.Text;
using System.Windows.Forms;

namespace HRTJ.Base
{
    public partial class ComBox : ComboBox
    {
        
        public override string Text
        {
            get
            {
                if (this.txtBox!=null)
                {
                    return base.Text.Trim() + this.txtBox.Text.Trim();    
                }
                else
                {
                    return base.Text.Trim();
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (string.IsNullOrEmpty(this.ShowTextBoxString) == false
                        && value.LastIndexOf(this.ShowTextBoxString) >= 0)
                    {
                        ReFresh();
                        base.Text = this.ShowTextBoxString;
                        this.txtBox.Text = value.Substring(this.ShowTextBoxString.Length);
                    }
                    else
                    {
                        base.Text = value;
                    }
                }
                else
                {
                    base.Text = string.Empty;
                    txtBox.Text = string.Empty;
                }
            }
        }
        
        public string Text1
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

        public string Textbz
        {
            get
            {
                if (this.txtBox!=null)
                {
                    return this.txtBox.Text.Trim();
                }
                return string.Empty;
            }
            set
            {
                if (this.txtBox != null)
                {
                   this.txtBox.Text=value;
                }
            }
        }

        private int _oldWidth;
        public int OldWidth
        {
            get { return _oldWidth; }
            set { _oldWidth = value; }
        }
        public TextBox txtBox;

        private string _ShowTextBoxString = null;

        public string ShowTextBoxString
        {
            get { return this._ShowTextBoxString; }
            set
            {
                _ShowTextBoxString = value;
            }
        }

        public ComBox()
        {
            InitializeComponent();
            this.CreateTxtBox();
        }

        private void CreateTxtBox()
        {
            #region txtBox
            if (txtBox == null)
            {
                this.txtBox = new TextBox();
                // this.txtBox.Location = new System.Drawing.Point(74, 3);
                this.txtBox.Top = this.Top;
                // this.txtBox.Left = this.Left + this.Width / 2 + 10;
                this.txtBox.Name = this.Name + "txtBox";
                // this.txtBox.Size = new System.Drawing.Size(this.Width / 2 - 10, this.Height);
                this.txtBox.TabIndex = this.TabIndex + 1;
                // this.Parent.Controls.Add(this.txtBox);
                // this.Parent.SuspendLayout();
            }
            #endregion
        }

        private void ComBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ReFresh();
        }

        private void ReFresh()
        {
            bool isTextBoxVisible = false;
            if (string.IsNullOrEmpty(this.ShowTextBoxString) == false
                && this.ShowTextBoxString.Trim().Equals(this.Text))
            {
                isTextBoxVisible = true;
            }
            if (this.txtBox!=null)
            {
                this.txtBox.Visible = isTextBoxVisible;
            }
            else
            {
                isTextBoxVisible = false;
            }
            

            if (isTextBoxVisible)
            {
                this.Width = this.OldWidth / 2 - 5;
                // this.txtBox.Width = this.Width / 2 - 10;
                this.txtBox.Left = this.Left + this.Width + 10;
                this.txtBox.Width = this.OldWidth / 2 - 5;
                this.txtBox.Top = this.Top;
                this.txtBox.Visible = true;
                if (this.Parent != null)
                {
                    this.Parent.Controls.Add(txtBox);
                }
            }
            else
            {
                if (this.txtBox != null && this.txtBox.Visible == false && this.OldWidth > 0)
                {
                    this.Width = this.OldWidth;
                }
            }
        }
        public ComBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.CreateTxtBox();
        }
    }
}
