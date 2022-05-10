using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Muhasebe.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyDataLayoutControl : DataLayoutControl
    {
        public MyDataLayoutControl()
        {
            OptionsFocus.EnableAutoTabOrder = false;
        }
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyLayoutControlImplementor(this);
        }
    }

    internal class MyLayoutControlImplementor : LayoutControlImplementor
    {
        public MyLayoutControlImplementor(ILayoutControlOwner controlOwner) : base(controlOwner)
        {
        }

        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item = base.CreateLayoutItem(parent);
            item.AppearanceItemCaption.ForeColor = Color.Maroon;
            return item;
        }

        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var grup = base.CreateLayoutGroup(parent);
            grup.LayoutMode = LayoutMode.Table;

            grup.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute;
            grup.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 200;
            grup.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Percent;
            grup.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 100;
            grup.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition
            {
                SizeType = SizeType.Absolute,
                Width = 99
            });

            grup.OptionsTableLayoutGroup.RowDefinitions.Clear();

            for (int i = 0; i < 9; i++)
            {
                grup.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Absolute,
                    Height = 24
                });

                if (i + 1 != 9) continue;
                grup.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Percent,
                    Height = 100
                });
            }
            return grup;
        }
    }
}