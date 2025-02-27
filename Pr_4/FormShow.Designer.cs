namespace Pr_4
{
    partial class FormShow
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
            panelFill = new Panel();
            dataGridViewRealisation = new DataGridView();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRealisation).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewRealisation);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 450);
            panelFill.TabIndex = 0;
            // 
            // dataGridViewRealisation
            // 
            dataGridViewRealisation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRealisation.Dock = DockStyle.Fill;
            dataGridViewRealisation.Location = new Point(10, 10);
            dataGridViewRealisation.Name = "dataGridViewRealisation";
            dataGridViewRealisation.Size = new Size(780, 430);
            dataGridViewRealisation.TabIndex = 0;
            // 
            // FormShow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Name = "FormShow";
            Text = "FormShow";
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRealisation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private DataGridView dataGridViewRealisation;
    }
}