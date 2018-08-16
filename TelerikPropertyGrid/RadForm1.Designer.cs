namespace TelerikPropertyGrid
{
    partial class RadForm1
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
            this.propertyGridTelerik = new Telerik.WinControls.UI.RadPropertyGrid();
            this.propertyGridWinForms = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridTelerik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGridTelerik
            // 
            this.propertyGridTelerik.Location = new System.Drawing.Point(458, 2);
            this.propertyGridTelerik.Name = "propertyGridTelerik";
            this.propertyGridTelerik.Size = new System.Drawing.Size(532, 271);
            this.propertyGridTelerik.TabIndex = 0;
            // 
            // propertyGridWinForms
            // 
            this.propertyGridWinForms.Location = new System.Drawing.Point(1, 2);
            this.propertyGridWinForms.Name = "propertyGridWinForms";
            this.propertyGridWinForms.Size = new System.Drawing.Size(451, 271);
            this.propertyGridWinForms.TabIndex = 1;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 639);
            this.Controls.Add(this.propertyGridWinForms);
            this.Controls.Add(this.propertyGridTelerik);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridTelerik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPropertyGrid propertyGridTelerik;
        private System.Windows.Forms.PropertyGrid propertyGridWinForms;
    }
}