namespace Pr_4
{
    partial class FormWelcome
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
            panel1 = new Panel();
            buttonTypeProduct = new Button();
            label = new Label();
            buttonTypePartner = new Button();
            buttonPartners = new Button();
            panelFill.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(panel1);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(346, 396);
            panelFill.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(buttonPartners);
            panel1.Controls.Add(buttonTypeProduct);
            panel1.Controls.Add(label);
            panel1.Controls.Add(buttonTypePartner);
            panel1.Location = new Point(62, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 346);
            panel1.TabIndex = 3;
            // 
            // buttonTypeProduct
            // 
            buttonTypeProduct.BackColor = Color.Firebrick;
            buttonTypeProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTypeProduct.ForeColor = Color.White;
            buttonTypeProduct.Location = new Point(25, 186);
            buttonTypeProduct.Name = "buttonTypeProduct";
            buttonTypeProduct.Size = new Size(170, 55);
            buttonTypeProduct.TabIndex = 2;
            buttonTypeProduct.Text = "Типы продукта";
            buttonTypeProduct.UseVisualStyleBackColor = false;
            buttonTypeProduct.Click += buttonTypeProduct_Click;
            // 
            // label
            // 
            label.BackColor = Color.Firebrick;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label.ForeColor = Color.White;
            label.Location = new Point(25, 26);
            label.Name = "label";
            label.Size = new Size(170, 57);
            label.TabIndex = 0;
            label.Text = "Выберите форму";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonTypePartner
            // 
            buttonTypePartner.BackColor = Color.Firebrick;
            buttonTypePartner.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTypePartner.ForeColor = Color.White;
            buttonTypePartner.Location = new Point(25, 106);
            buttonTypePartner.Name = "buttonTypePartner";
            buttonTypePartner.Size = new Size(170, 55);
            buttonTypePartner.TabIndex = 1;
            buttonTypePartner.Text = "Типы партнера";
            buttonTypePartner.UseVisualStyleBackColor = false;
            buttonTypePartner.Click += buttonTypePartner_Click;
            // 
            // buttonPartners
            // 
            buttonPartners.BackColor = Color.Firebrick;
            buttonPartners.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPartners.ForeColor = Color.White;
            buttonPartners.Location = new Point(25, 260);
            buttonPartners.Name = "buttonPartners";
            buttonPartners.Size = new Size(170, 55);
            buttonPartners.TabIndex = 3;
            buttonPartners.Text = "Партнеры";
            buttonPartners.UseVisualStyleBackColor = false;
            buttonPartners.Click += buttonPartners_Click;
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 396);
            Controls.Add(panelFill);
            Name = "FormWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormWelcome";
            panelFill.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private Panel panel1;
        private Button buttonTypeProduct;
        private Label label;
        private Button buttonTypePartner;
        private Button buttonPartners;
    }
}