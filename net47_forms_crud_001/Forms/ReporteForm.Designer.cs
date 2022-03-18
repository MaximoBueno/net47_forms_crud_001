
namespace net47_forms_crud_001.Forms
{
    partial class ReporteForm
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
            this.reporteCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reporteCrystalReportViewer
            // 
            this.reporteCrystalReportViewer.ActiveViewIndex = -1;
            this.reporteCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporteCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporteCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.reporteCrystalReportViewer.Name = "reporteCrystalReportViewer";
            this.reporteCrystalReportViewer.Size = new System.Drawing.Size(610, 450);
            this.reporteCrystalReportViewer.TabIndex = 0;
            // 
            // ReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.reporteCrystalReportViewer);
            this.Name = "ReporteForm";
            this.Text = "ReporteForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reporteCrystalReportViewer;
    }
}