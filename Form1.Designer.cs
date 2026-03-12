namespace CatchButton
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
            catchMeButton = new Button();
            SuspendLayout();
            // 
            // catchMeButton
            // 
            catchMeButton.BackColor = SystemColors.ActiveCaption;
            catchMeButton.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            catchMeButton.Location = new Point(264, 162);
            catchMeButton.Name = "catchMeButton";
            catchMeButton.Size = new Size(267, 91);
            catchMeButton.TabIndex = 0;
            catchMeButton.Text = "나를 잡아봐";
            catchMeButton.UseVisualStyleBackColor = false;
            catchMeButton.MouseDown += catchMeButton_MouseDown;
            catchMeButton.MouseEnter += catchMeButton_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(catchMeButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button catchMeButton;
    }
}
