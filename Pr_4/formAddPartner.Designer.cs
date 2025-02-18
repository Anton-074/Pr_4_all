namespace Pr_4
{
    partial class formAdd
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
            errorProvider = new ErrorProvider(components);
            panelFill.SuspendLayout();
            panelBut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxTypes);
            panelFill.Controls.Add(label);
            panelFill.Controls.Add(panelBut);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(556, 195);
            panelFill.TabIndex = 0;
            // 
            // textBoxTypes
            // 
            textBoxTypes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTypes.Location = new Point(37, 59);
            textBoxTypes.Name = "textBoxTypes";
            textBoxTypes.Size = new Size(487, 33);
            textBoxTypes.TabIndex = 2;
            textBoxTypes.TextChanged += textBoxTypePartner_TextChanged;
            textBoxTypes.Validating += textBoxTypePartner_Validating;
            // 
            // label
            // 
            label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label.Location = new Point(37, 19);
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
            panelBut.Location = new Point(0, 120);
            panelBut.Name = "panelBut";
            panelBut.Size = new Size(556, 75);
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
            // formAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 195);
            Controls.Add(panelFill);
            Name = "formAdd";
            Text = "formAdd";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            panelBut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private Panel panelBut;
        private Button buttonCancel;
        private Button buttonSave;
        public TextBox textBoxTypes;
        private ErrorProvider errorProvider;
        public Label label;
    }
}