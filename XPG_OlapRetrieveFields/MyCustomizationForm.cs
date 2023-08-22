using DevExpress.XtraEditors.Customization;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Customization;
using DevExpress.XtraPivotGrid.Customization.ViewInfo;
using DevExpress.XtraPivotGrid.Data;
using System.Reflection;

namespace WindowsFormsApplication2 {

    class MyPivotGridControl : PivotGridControl
	{
		public MyPivotGridControl()
            : base()
		{
		}

        protected override PivotGridViewInfoData CreateData() {
            return new MyPivotGridViewInfoData(this);
        }
	}

	class MyPivotGridViewInfoData : PivotGridViewInfoData
	{
		private readonly PivotGridControl _pivotGrid;

		public MyPivotGridViewInfoData()
		{
		}

		public MyPivotGridViewInfoData(PivotGridControl control)
			: base(control)
		{
			_pivotGrid = control;
		}

		protected override CustomizationForm CreateCustomizationForm(CustomizationFormStyle style)
		{
			return new MyCustomizationForm(this, style)
			{
				HtmlImages = _pivotGrid.HtmlImages
			};
		}
	}

	public class MyCustomizationForm : CustomizationForm {
        public MyCustomizationForm(PivotGridViewInfoData data, CustomizationFormStyle style) : base(data, style) {

        }
        protected override CustomizationListBoxBase CreateCustomizationListBox() {
            return new MyPivotCustomizationTreeBox(this)
			{
				HtmlImages = HtmlImages
			};
        }
    }
    public class MyPivotCustomizationTreeBox : PivotCustomizationTreeBox {
        public MyPivotCustomizationTreeBox(CustomizationForm customizationForm) : base(customizationForm) { }


        protected override CustomizationItemViewInfo CreateItemViewInfo(IVisualCustomizationTreeItem item) {
            return new MyCustomizationTreeItemViewInfo(this, item);
        }

        
    }

    public class MyCustomizationTreeItemViewInfo : CustomizationTreeItemViewInfo {

		private static readonly FieldInfo FieldInfo = typeof(CustomizationTreeItemViewInfo).GetField("tree", BindingFlags.NonPublic | BindingFlags.Instance);

        public MyCustomizationTreeItemViewInfo(PivotCustomizationTreeBoxBase treeBox, IVisualCustomizationTreeItem node) : base(treeBox, node) {

        }

		protected override PivotCustomizationTreeItemCaptionViewInfo CreateCaption(IVisualCustomizationTreeItem node)
		{
			var tree = FieldInfo.GetValue(this) as PivotCustomizationTreeBox;

			//Custom HTML
			return new PivotCustomizationTreeItemCaptionViewInfo(tree, node.Field == null
				? $"{node.Caption} - <b>Root</b>"
				: node.Field.Tag is string image
					? $"{node.Caption} <image={image}>"
					: $"<i>{node.Caption}</i>");
		}
    }
}
