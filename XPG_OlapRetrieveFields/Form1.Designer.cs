using DevExpress.Data.ChartDataSources;

namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.pivotGridControl1 = new WindowsFormsApplication2.MyPivotGridControl();
			this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
			this.splitContainerControl1.Panel2.SuspendLayout();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
			this.splitContainerControl1.Name = "splitContainerControl1";
			// 
			// splitContainerControl1.Panel1
			// 
			this.splitContainerControl1.Panel1.Text = "Panel1";
			// 
			// splitContainerControl1.Panel2
			// 
			this.splitContainerControl1.Panel2.Controls.Add(this.pivotGridControl1);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(980, 395);
			this.splitContainerControl1.SplitterPosition = 271;
			this.splitContainerControl1.TabIndex = 1;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// pivotGridControl1
			// 
			this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pivotGridControl1.HtmlImages = this.svgImageCollection1;
			this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.pivotGridControl1.Name = "pivotGridControl1";
			this.pivotGridControl1.OLAPConnectionString = "provider=MSOLAP;data source=http://demos.devexpress.com/Services/OLAP/msmdpump.dl" +
    "l;initial catalog=Adventure Works DW Standard Edition;cube name=Adventure Works";
			this.pivotGridControl1.OptionsView.AllowHtmlDrawHeaders = true;
			this.pivotGridControl1.Size = new System.Drawing.Size(699, 395);
			this.pivotGridControl1.TabIndex = 0;
			// 
			// svgImageCollection1
			// 
			this.svgImageCollection1.Add("actions_add", "image://svgimages/icon builder/actions_add.svg");
			this.svgImageCollection1.Add("actions_remove", "image://svgimages/icon builder/actions_remove.svg");
			this.svgImageCollection1.Add("delete", "image://svgimages/scheduling/delete.svg");
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(980, 395);
			this.Controls.Add(this.splitContainerControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
			this.splitContainerControl1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private MyPivotGridControl pivotGridControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		private DevExpress.Utils.SvgImageCollection svgImageCollection1;
	}
}

