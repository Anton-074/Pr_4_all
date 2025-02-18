namespace Pr_4
{
    partial class FormMain
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
            panel1 = new Panel();
            labelTypePartner = new Label();
            labelName = new Label();
            labelProcent = new Label();
            labelDirector = new Label();
            labelPhone = new Label();
            labelRating = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelRating);
            panel1.Controls.Add(labelPhone);
            panel1.Controls.Add(labelDirector);
            panel1.Controls.Add(labelProcent);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(labelTypePartner);
            panel1.Location = new Point(0, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 161);
            panel1.TabIndex = 0;
            // 
            // labelTypePartner
            // 
            labelTypePartner.BackColor = Color.Silver;
            labelTypePartner.Location = new Point(26, 17);
            labelTypePartner.Name = "labelTypePartner";
            labelTypePartner.Size = new Size(100, 23);
            labelTypePartner.TabIndex = 0;
            labelTypePartner.Text = "Тип";
            labelTypePartner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.BackColor = Color.Silver;
            labelName.Location = new Point(156, 18);
            labelName.Name = "labelName";
            labelName.Size = new Size(230, 23);
            labelName.TabIndex = 1;
            labelName.Text = "Наименование патнера";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProcent
            // 
            labelProcent.BackColor = Color.Silver;
            labelProcent.Location = new Point(678, 53);
            labelProcent.Name = "labelProcent";
            labelProcent.Size = new Size(100, 23);
            labelProcent.TabIndex = 2;
            labelProcent.Text = "10%";
            labelProcent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDirector
            // 
            labelDirector.BackColor = Color.Silver;
            labelDirector.Location = new Point(26, 53);
            labelDirector.Name = "labelDirector";
            labelDirector.Size = new Size(100, 23);
            labelDirector.TabIndex = 3;
            labelDirector.Text = "Директор";
            labelDirector.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPhone
            // 
            labelPhone.BackColor = Color.Silver;
            labelPhone.Location = new Point(26, 90);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(100, 23);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Номер телефона";
            labelPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRating
            // 
            labelRating.BackColor = Color.Silver;
            labelRating.Location = new Point(26, 129);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(100, 23);
            labelRating.TabIndex = 5;
            labelRating.Text = "Рейтинг";
            labelRating.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "FormMain";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelName;
        private Label labelTypePartner;
        private Label labelRating;
        private Label labelPhone;
        private Label labelDirector;
        private Label labelProcent;
    }
}