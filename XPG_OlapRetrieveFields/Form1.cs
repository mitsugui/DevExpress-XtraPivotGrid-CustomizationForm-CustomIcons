using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			pivotGridControl1.RetrieveFields(PivotArea.FilterArea, false);
            pivotGridControl1.FieldsCustomization( splitContainerControl1.Panel1 );
            pivotGridControl1.BeginUpdate();
            pivotGridControl1.Fields["[Product].[Category].[Category]"].Visible = true;
            pivotGridControl1.Fields["[Product].[Category].[Category]"].Area = PivotArea.ColumnArea;
            pivotGridControl1.Fields["[Sales Territory].[Sales Territory].[Group]"].Visible = true;
            pivotGridControl1.Fields["[Sales Territory].[Sales Territory].[Group]"].Area = PivotArea.RowArea;
            pivotGridControl1.Fields["[Measures].[Sales Amount]"].Visible = true;
            pivotGridControl1.Fields["[Measures].[Gross Profit]"].Visible = true;

			var hierarchyImage = new Dictionary<string, string>
			{
				{ "[Measures]", "actions_add" },
				{ "[Product]", "actions_remove" },
				{ "[Sales Territory]", "delete" }
			};
			foreach (PivotGridField field in pivotGridControl1.Fields)
			{
				if (!(field.DataBinding is DataSourceColumnBinding binding)) continue;

                var dimension = binding.ColumnName.Substring(0, 
					binding.ColumnName.IndexOf(".", StringComparison.OrdinalIgnoreCase));
				if (!hierarchyImage.TryGetValue(dimension, out var image)) continue;

				field.Tag = image;
				if (field.Visible)
				{
					field.Caption = $"{field.Caption} <image={image}>";
				}
			}

			pivotGridControl1.EndUpdate();
            pivotGridControl1.BestFit();

        }
    }
}
