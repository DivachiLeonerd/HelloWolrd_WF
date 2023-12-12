namespace Say_Hello_WF
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
            sayHello_Button = new Button();
            sayHello_TextBox = new TextBox();
            SuspendLayout();
            // 
            // sayHello_Button
            // 
            sayHello_Button.Location = new Point(146, 241);
            sayHello_Button.Name = "sayHello_Button";
            sayHello_Button.Size = new Size(94, 29);
            sayHello_Button.TabIndex = 0;
            sayHello_Button.Text = "Say Hello";
            sayHello_Button.UseVisualStyleBackColor = true;
            sayHello_Button.Click += SayHelloButton_Click;
            // 
            // sayHello_TextBox
            // 
            sayHello_TextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            sayHello_TextBox.Location = new Point(246, 111);
            sayHello_TextBox.Margin = new Padding(1, 1, 8, 8);
            sayHello_TextBox.Name = "sayHello_TextBox";
            sayHello_TextBox.Size = new Size(360, 61);
            sayHello_TextBox.TabIndex = 1;
            sayHello_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sayHello_TextBox);
            Controls.Add(sayHello_Button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sayHello_Button;
        private TextBox sayHello_TextBox;
    }
}