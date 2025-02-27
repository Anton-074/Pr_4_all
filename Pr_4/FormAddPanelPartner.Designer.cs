namespace Pr_4
{
    partial class FormAddPanelPartner
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
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxINN = new TextBox();
            labelINN = new Label();
            textBoxAdress = new TextBox();
            labelAdress = new Label();
            comboBoxType = new ComboBox();
            textBoxRating = new TextBox();
            labelRating = new Label();
            textBoxPhone = new TextBox();
            label2 = new Label();
            textBoxNameDirector = new TextBox();
            label3 = new Label();
            textBoxNamePartner = new TextBox();
            label1 = new Label();
            label = new Label();
            panelBut = new Panel();
            buttonSave = new Button();
            buttonCancel = new Button();
            errorProvider = new ErrorProvider(components);
            panelFill.SuspendLayout();
            panelBut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxEmail);
            panelFill.Controls.Add(labelEmail);
            panelFill.Controls.Add(textBoxINN);
            panelFill.Controls.Add(labelINN);
            panelFill.Controls.Add(textBoxAdress);
            panelFill.Controls.Add(labelAdress);
            panelFill.Controls.Add(comboBoxType);
            panelFill.Controls.Add(textBoxRating);
            panelFill.Controls.Add(labelRating);
            panelFill.Controls.Add(textBoxPhone);
            panelFill.Controls.Add(label2);
            panelFill.Controls.Add(textBoxNameDirector);
            panelFill.Controls.Add(label3);
            panelFill.Controls.Add(textBoxNamePartner);
            panelFill.Controls.Add(label1);
            panelFill.Controls.Add(label);
            panelFill.Controls.Add(panelBut);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(561, 606);
            panelFill.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxEmail.Location = new Point(37, 406);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(487, 26);
            textBoxEmail.TabIndex = 17;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            textBoxEmail.Validating += textBoxEmail_Validating;
            // 
            // labelEmail
            // 
            labelEmail.Font = new Font("Microsoft Sans Serif", 12F);
            labelEmail.Location = new Point(37, 375);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(487, 28);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Email";
            // 
            // textBoxINN
            // 
            textBoxINN.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxINN.Location = new Point(37, 225);
            textBoxINN.Name = "textBoxINN";
            textBoxINN.Size = new Size(487, 26);
            textBoxINN.TabIndex = 15;
            textBoxINN.TextChanged += textBoxINN_TextChanged;
            textBoxINN.Validating += textBoxINN_Validating;
            // 
            // labelINN
            // 
            labelINN.Font = new Font("Microsoft Sans Serif", 12F);
            labelINN.Location = new Point(37, 194);
            labelINN.Name = "labelINN";
            labelINN.Size = new Size(487, 28);
            labelINN.TabIndex = 14;
            labelINN.Text = "ИНН";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxAdress.Location = new Point(37, 165);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(487, 26);
            textBoxAdress.TabIndex = 13;
            textBoxAdress.TextChanged += textBoxAdress_TextChanged;
            textBoxAdress.Validating += textBoxAdress_Validating;
            // 
            // labelAdress
            // 
            labelAdress.Font = new Font("Microsoft Sans Serif", 12F);
            labelAdress.Location = new Point(37, 134);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(487, 28);
            labelAdress.TabIndex = 12;
            labelAdress.Text = "Адресс";
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new Font("Microsoft Sans Serif", 12F);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(37, 43);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(487, 28);
            comboBoxType.TabIndex = 11;
            // 
            // textBoxRating
            // 
            textBoxRating.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxRating.Location = new Point(37, 466);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(487, 26);
            textBoxRating.TabIndex = 10;
            textBoxRating.TextChanged += textBoxRating_TextChanged;
            textBoxRating.Validating += textBoxRating_Validating;
            // 
            // labelRating
            // 
            labelRating.Font = new Font("Microsoft Sans Serif", 12F);
            labelRating.Location = new Point(37, 435);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(487, 28);
            labelRating.TabIndex = 9;
            labelRating.Text = "Рейтинг";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxPhone.Location = new Point(37, 346);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(487, 26);
            textBoxPhone.TabIndex = 8;
            textBoxPhone.TextChanged += textBoxPhone_TextChanged;
            textBoxPhone.Validating += textBoxPhone_Validating;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(37, 315);
            label2.Name = "label2";
            label2.Size = new Size(487, 28);
            label2.TabIndex = 7;
            label2.Text = "Номер телефона";
            // 
            // textBoxNameDirector
            // 
            textBoxNameDirector.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxNameDirector.Location = new Point(37, 286);
            textBoxNameDirector.Name = "textBoxNameDirector";
            textBoxNameDirector.Size = new Size(487, 26);
            textBoxNameDirector.TabIndex = 6;
            textBoxNameDirector.TextChanged += textBoxNameDirector_TextChanged;
            textBoxNameDirector.Validating += textBoxNameDirector_Validating;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(37, 255);
            label3.Name = "label3";
            label3.Size = new Size(487, 28);
            label3.TabIndex = 5;
            label3.Text = "Директор";
            // 
            // textBoxNamePartner
            // 
            textBoxNamePartner.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxNamePartner.Location = new Point(37, 105);
            textBoxNamePartner.Name = "textBoxNamePartner";
            textBoxNamePartner.Size = new Size(487, 26);
            textBoxNamePartner.TabIndex = 4;
            textBoxNamePartner.TextChanged += textBoxNamePartner_TextChanged;
            textBoxNamePartner.Validating += textBoxNamePartner_Validating;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(37, 74);
            label1.Name = "label1";
            label1.Size = new Size(487, 28);
            label1.TabIndex = 3;
            label1.Text = "Наименование партнера";
            // 
            // label
            // 
            label.Font = new Font("Microsoft Sans Serif", 12F);
            label.Location = new Point(37, 12);
            label.Name = "label";
            label.Size = new Size(487, 28);
            label.TabIndex = 1;
            label.Text = "Тип";
            // 
            // panelBut
            // 
            panelBut.Controls.Add(buttonSave);
            panelBut.Controls.Add(buttonCancel);
            panelBut.Dock = DockStyle.Bottom;
            panelBut.Location = new Point(0, 531);
            panelBut.Name = "panelBut";
            panelBut.Size = new Size(561, 75);
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
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddPanelPartner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 606);
            Controls.Add(panelFill);
            Name = "FormAddPanelPartner";
            Text = "FormAddPanelPartner";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            panelBut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        public TextBox textBoxAdress;
        public Label labelAdress;
        public ComboBox comboBoxType;
        public TextBox textBoxRating;
        public Label labelRating;
        public TextBox textBoxPhone;
        public Label label2;
        public TextBox textBoxNameDirector;
        public Label label3;
        public TextBox textBoxNamePartner;
        public Label label1;
        public Label label;
        private Panel panelBut;
        private Button buttonSave;
        private Button buttonCancel;
        public TextBox textBoxEmail;
        public Label labelEmail;
        public TextBox textBoxINN;
        public Label labelINN;
        private ErrorProvider errorProvider;
    }
}