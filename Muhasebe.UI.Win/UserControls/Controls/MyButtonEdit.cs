using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Muhasebe.UI.Win.Interfaces;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Muhasebe.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyButtonEdit : ButtonEdit, IStatusBarKisaYol
    {
        public MyButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.PaleTurquoise
                ;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; }

        #region Events

        private long? _Id;

        [Browsable(false)]
        public long? Id
        {
            get => _Id;
            set
            {
                var oldValue = _Id;
                var newValue = value;

                if (newValue.HasValue && oldValue.HasValue && newValue == oldValue) return;

                _Id = value;

                IdChanged(this, new IdChangedEventArgs(oldValue, newValue));
                EnabledChange(this, EventArgs.Empty);
            }
        }
        public event EventHandler<IdChangedEventArgs> IdChanged = delegate { };
        public event EventHandler EnabledChange = delegate { };

        #endregion
    }

    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(long? oldValue, long? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public long? OldValue { get; }
        public long? NewValue { get; set; }
    }
}