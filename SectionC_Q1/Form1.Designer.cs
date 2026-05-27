namespace SectionC_Q1
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
            lblOutput = new Label();
            lblMobileCode = new Label();
            lblMake = new Label();
            lblQuantity = new Label();
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOutput.ForeColor = Color.White;
            lblOutput.Location = new Point(323, 29);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(65, 23);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "Output";
            // 
            // lblMobileCode
            // 
            lblMobileCode.AutoSize = true;
            lblMobileCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMobileCode.ForeColor = Color.White;
            lblMobileCode.Location = new Point(179, 148);
            lblMobileCode.Name = "lblMobileCode";
            lblMobileCode.Size = new Size(96, 20);
            lblMobileCode.TabIndex = 1;
            lblMobileCode.Text = "Mobile Code";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMake.ForeColor = Color.White;
            lblMake.Location = new Point(179, 199);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(47, 20);
            lblMake.TabIndex = 2;
            lblMake.Text = "Make";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(179, 250);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(70, 20);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(323, 145);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(240, 27);
            txtCode.TabIndex = 4;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(323, 199);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(240, 27);
            txtMake.TabIndex = 5;
            txtMake.TextChanged += txtMake_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(323, 250);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(240, 27);
            txtQuantity.TabIndex = 6;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(179, 330);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(323, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(469, 330);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 9;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Controls.Add(lblQuantity);
            Controls.Add(lblMake);
            Controls.Add(lblMobileCode);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Label lblMobileCode;
        private Label lblMake;
        private Label lblQuantity;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
    }
}
