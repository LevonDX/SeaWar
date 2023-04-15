namespace SeaWar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMyField = new Panel();
            lblAddingShipInfo = new Label();
            SuspendLayout();
            // 
            // panelMyField
            // 
            panelMyField.Location = new Point(90, 90);
            panelMyField.Name = "panelMyField";
            panelMyField.Size = new Size(691, 660);
            panelMyField.TabIndex = 0;
            // 
            // lblAddingShipInfo
            // 
            lblAddingShipInfo.AutoSize = true;
            lblAddingShipInfo.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddingShipInfo.ForeColor = Color.IndianRed;
            lblAddingShipInfo.Location = new Point(1266, 1055);
            lblAddingShipInfo.Name = "lblAddingShipInfo";
            lblAddingShipInfo.Size = new Size(214, 89);
            lblAddingShipInfo.TabIndex = 1;
            lblAddingShipInfo.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2220, 1244);
            Controls.Add(lblAddingShipInfo);
            Controls.Add(panelMyField);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMyField;
        private Label lblAddingShipInfo;
    }
}