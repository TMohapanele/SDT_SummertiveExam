namespace SectionB_Q2
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
            lblName = new Label();
            txtName = new TextBox();
            btnGreet = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(178, 147);
            lblName.Name = "lblName";
            lblName.Size = new Size(124, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Enter your name: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(341, 147);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnGreet
            // 
            btnGreet.Location = new Point(402, 201);
            btnGreet.Name = "btnGreet";
            btnGreet.Size = new Size(94, 29);
            btnGreet.TabIndex = 2;
            btnGreet.Text = "Greeting";
            btnGreet.UseVisualStyleBackColor = true;
            btnGreet.Click += btnGreet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGreet);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Button btnGreet;
    }
}
