namespace Pr_4
{
    partial class FormTypesProduct
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
            panelTop = new Panel();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            labelListProducts = new Label();
            panelFill = new Panel();
            dataGridViewType = new DataGridView();
            panelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewType).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonDelete);
            panelTop.Controls.Add(buttonEdit);
            panelTop.Controls.Add(buttonAdd);
            panelTop.Controls.Add(labelListProducts);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(800, 77);
            panelTop.TabIndex = 3;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelete.Location = new Point(342, 19);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(117, 38);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEdit.Location = new Point(165, 19);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(157, 38);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(23, 19);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(117, 38);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelListProducts
            // 
            labelListProducts.Dock = DockStyle.Right;
            labelListProducts.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelListProducts.Location = new Point(538, 10);
            labelListProducts.Name = "labelListProducts";
            labelListProducts.Size = new Size(252, 57);
            labelListProducts.TabIndex = 0;
            labelListProducts.Text = "Типы продукции";
            labelListProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewType);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 77);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 373);
            panelFill.TabIndex = 4;
            // 
            // dataGridViewType
            // 
            dataGridViewType.BackgroundColor = Color.White;
            dataGridViewType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewType.Dock = DockStyle.Fill;
            dataGridViewType.Location = new Point(10, 10);
            dataGridViewType.MultiSelect = false;
            dataGridViewType.Name = "dataGridViewType";
            dataGridViewType.ReadOnly = true;
            dataGridViewType.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewType.Size = new Size(780, 353);
            dataGridViewType.TabIndex = 1;
            // 
            // FormTypesProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            Name = "FormTypesProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Типы продукции";
            panelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewType).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private Label labelListProducts;
        private Panel panelFill;
        private DataGridView dataGridViewType;
    }
}