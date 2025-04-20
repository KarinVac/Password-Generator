namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            passwordLabel = new Label();
            CopyPasswordButton = new Button();
            fontDialog1 = new FontDialog();
            PasswordLengthLabel = new Label();
            passwordLengthSlider = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)passwordLengthSlider).BeginInit();
            SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Microsoft Sans Serif", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(49, 58);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(392, 42);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "label1";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CopyPasswordButton
            // 
            CopyPasswordButton.BackColor = Color.DarkGray;
            CopyPasswordButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CopyPasswordButton.Location = new Point(82, 264);
            CopyPasswordButton.Name = "CopyPasswordButton";
            CopyPasswordButton.Size = new Size(321, 52);
            CopyPasswordButton.TabIndex = 1;
            CopyPasswordButton.Text = "Copy Password";
            CopyPasswordButton.UseVisualStyleBackColor = false;
            CopyPasswordButton.Click += CopyPasswordButton_Click;
            // 
            // PasswordLengthLabel
            // 
            PasswordLengthLabel.BackColor = Color.Transparent;
            PasswordLengthLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PasswordLengthLabel.ForeColor = Color.White;
            PasswordLengthLabel.Location = new Point(100, 128);
            PasswordLengthLabel.Name = "PasswordLengthLabel";
            PasswordLengthLabel.Size = new Size(286, 42);
            PasswordLengthLabel.TabIndex = 0;
            PasswordLengthLabel.Text = "Password Length: 5";
            PasswordLengthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLengthSlider
            // 
            passwordLengthSlider.BackColor = Color.SlateGray;
            passwordLengthSlider.Location = new Point(100, 173);
            passwordLengthSlider.Name = "passwordLengthSlider";
            passwordLengthSlider.Size = new Size(286, 45);
            passwordLengthSlider.TabIndex = 2;
            passwordLengthSlider.Scroll += passwordLengthSlider_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(487, 348);
            Controls.Add(passwordLengthSlider);
            Controls.Add(CopyPasswordButton);
            Controls.Add(PasswordLengthLabel);
            Controls.Add(passwordLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)passwordLengthSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passwordLabel;
        private Button CopyPasswordButton;
        private FontDialog fontDialog1;
        private Label PasswordLengthLabel;
        private TrackBar passwordLengthSlider;
    }
}
