namespace Devoir2
{
    partial class formTree
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
            txtInput = new TextBox();
            pictureBox = new PictureBox();
            btnSubmit = new Button();
            lblMessage = new Label();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(494, 52);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(294, 27);
            txtInput.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(2, 52);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(476, 478);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(688, 94);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 31);
            btnSubmit.TabIndex = 2;
            btnSubmit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(318, 9);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(470, 20);
            lblMessage.TabIndex = 3;
            lblMessage.ForeColor = System.Drawing.Color.DarkSlateBlue;
            lblMessage.Text = "Put the numbers separated by a comma without space to get the tree.";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(34, 557);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.TabIndex = 4;
            // 
            // formTree
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 586);
            Controls.Add(lblError);
            Controls.Add(lblMessage);
            Controls.Add(btnSubmit);
            Controls.Add(pictureBox);
            Controls.Add(txtInput);
            Name = "formTree";
            Text = "devoir 2 St Cyr";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private PictureBox pictureBox;
        private Button btnSubmit;
        private Label lblMessage;
        private Label lblError;
    }
}
