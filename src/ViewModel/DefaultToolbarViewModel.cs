using Atomus.Control;
using Atomus.Diagnostics;
using Atomus.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Atomus.Windows.Controls.Toolbar.ViewModel
{
    public class DefaultToolbarViewModel : Atomus.MVVM.ViewModel
    {
        #region Declare
        private string backColor;
        private string foreColor;
        private string borderColor;
        #endregion

        #region Property
        public ICore Core { get; set; }

        public string BackColor
        {
            get
            {
                return this.backColor;
            }
            set
            {
                if (this.backColor != value)
                {
                    this.backColor = value;
                    this.NotifyPropertyChanged();
                }
            }
        }
        public string ForeColor
        {
            get
            {
                return this.foreColor;
            }
            set
            {
                if (this.foreColor != value)
                {
                    this.foreColor = value;
                    this.NotifyPropertyChanged();
                }
            }
        }
        public string BorderColor
        {
            get
            {
                return this.borderColor;
            }
            set
            {
                if (this.borderColor != value)
                {
                    this.borderColor = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        //public ICommand TestCommand { get; set; }
        #endregion

        #region INIT
        public DefaultToolbarViewModel()
        {
            //this.TestCommand = new MVVM.DelegateCommand(() => { this.RibbonButtonProcess(null); }
            //                                                , () => { return true; });
        }
        public DefaultToolbarViewModel(ICore core) : this()
        {
            string skinName;

            this.Core = core;

            try
            {
                //skinName = Config.Client.GetAttribute("SkinName").ToString();

                //this.backColor = this.Core.GetAttribute(skinName + ".BackColor");
                //this.foreColor = this.Core.GetAttribute(skinName + ".ForeColor");
                //this.borderColor = this.Core.GetAttribute(skinName + ".BorderColor");


                this.backColor = "#182233";
                this.foreColor = "#ffffff";
                this.borderColor = "#4b5361";// "#ffffff";
            }
            catch (Exception ex)
            {
                DiagnosticsTool.MyTrace(ex);
                //this.WindowsMessageBoxShow(Application.Current.Windows[0], ex);
            }
        }
        #endregion

        #region IO
        internal void RibbonButtonProcess(object parameter)
        {
            if (parameter != null && parameter is string)
                (this.Core as IAction).ControlAction(this, (string)parameter, null);

            //if (parameter == null)
            //    this.WindowsMessageBoxShow(Application.Current.Windows[0], "Test");
            //else
            //    this.WindowsMessageBoxShow(Application.Current.Windows[0], string.Format("Test : {0}", parameter));
        }
        #endregion

        #region ETC
        #endregion
    }
}