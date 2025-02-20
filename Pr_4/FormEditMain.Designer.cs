namespace Pr_4
{
    partial class FormEditMain
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
            components = new System.ComponentModel.Container();
            panelFill = new Panel();
            textBoxTypes = new TextBox();
            label = new Label();
            panelBut = new Panel();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxNamePartner = new TextBox();
            label1 = new Label();
            textBoxPhone = new TextBox();
            label2 = new Label();
            textBoxNameDirector = new TextBox();
            label3 = new Label();
            textBoxRating = new TextBox();
            labelRating = new Label();
            errorProvider = new ErrorProvider(components);
            panelFill.SuspendLayout();
            panelBut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxRating);
            panelFill.Controls.Add(labelRating);
            panelFill.Controls.Add(textBoxPhone);
            panelFill.Controls.Add(label2);
            panelFill.Controls.Add(textBoxNameDirector);
            panelFill.Controls.Add(label3);
            panelFill.Controls.Add(textBoxNamePartner);
            panelFill.Controls.Add(label1);
            panelFill.Controls.Add(textBoxTypes);
            panelFill.Controls.Add(label);
            panelFill.Controls.Add(panelBut);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(549, 523);
            panelFill.TabIndex = 1;
            // 
            // textBoxTypes
            // 
            textBoxTypes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTypes.Location = new Point(37, 52);
            textBoxTypes.Name = "textBoxTypes";
            textBoxTypes.Size = new Size(487, 33);
            textBoxTypes.TabIndex = 2;
            textBoxTypes.TextChanged += textBoxTypes_TextChanged;
            textBoxTypes.Validating += textBoxTypes_Validating;
            // 
            // label
            // 
            label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label.Location = new Point(37, 12);
            label.Name = "label";
            label.Size = new Size(487, 37);
            label.TabIndex = 1;
            label.Text = "Тип";
            // 
            // panelBut
            // 
            panelBut.Controls.Add(buttonSave);
            panelBut.Controls.Add(buttonCancel);
            panelBut.Dock = DockStyle.Bottom;
            panelBut.Location = new Point(0, 448);
            panelBut.Name = "panelBut";
            panelBut.Size = new Size(549, 75);
            panelBut.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(342, 18);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(119, 36);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(83, 18);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(117, 36);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxNamePartner
            // 
            textBoxNamePartner.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxNamePartner.Location = new Point(37, 139);
            textBoxNamePartner.Name = "textBoxNamePartner";
            textBoxNamePartner.Size = new Size(487, 33);
            textBoxNamePartner.TabIndex = 4;
            textBoxNamePartner.TextChanged += textBoxNamePartner_TextChanged;
            textBoxNamePartner.Validating += textBoxNamePartner_Validating;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(37, 99);
            label1.Name = "label1";
            label1.Size = new Size(487, 37);
            label1.TabIndex = 3;
            label1.Text = "Наименование партнера";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPhone.Location = new Point(37, 313);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(487, 33);
            textBoxPhone.TabIndex = 8;
            textBoxPhone.TextChanged += textBoxPhone_TextChanged;
            textBoxPhone.Validating += textBoxPhone_Validating;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(37, 273);
            label2.Name = "label2";
            label2.Size = new Size(487, 37);
            label2.TabIndex = 7;
            label2.Text = "Номер телефона";
            // 
            // textBoxNameDirector
            // 
            textBoxNameDirector.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxNameDirector.Location = new Point(37, 224);
            textBoxNameDirector.Name = "textBoxNameDirector";
            textBoxNameDirector.Size = new Size(487, 33);
            textBoxNameDirector.TabIndex = 6;
            textBoxNameDirector.TextChanged += textBoxNameDirector_TextChanged;
            textBoxNameDirector.Validating += textBoxNameDirector_Validating;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(37, 184);
            label3.Name = "label3";
            label3.Size = new Size(487, 37);
            label3.TabIndex = 5;
            label3.Text = "Директор";
            // 
            // textBoxRating
            // 
            textBoxRating.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRating.Location = new Point(37, 404);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(487, 33);
            textBoxRating.TabIndex = 10;
            textBoxRating.TextChanged += textBoxRating_TextChanged;
            textBoxRating.Validating += textBoxRating_Validating;
            // 
            // labelRating
            // 
            labelRating.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRating.Location = new Point(37, 364);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(487, 37);
            labelRating.TabIndex = 9;
            labelRating.Text = "Рейтинг";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormEditMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 523);
            Controls.Add(panelFill);
            Name = "FormEditMain";
            Text = "FormEditMain";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            panelBut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        public TextBox textBoxRating;
        public Label labelRating;
        public TextBox textBoxPhone;
        public Label label2;
        public TextBox textBoxNameDirector;
        public Label label3;
        public TextBox textBoxNamePartner;
        public Label label1;
        public TextBox textBoxTypes;
        public Label label;
        private Panel panelBut;
        private Button buttonSave;
        private Button buttonCancel;
        private ErrorProvider errorProvider;
    }
}