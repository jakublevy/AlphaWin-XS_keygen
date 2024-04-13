namespace AlphaLink_keygen
{
    partial class Form1
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
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.permanentRadioButton = new System.Windows.Forms.RadioButton();
            this.trialRadioButton = new System.Windows.Forms.RadioButton();
            this.muteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationNumberTextBox.Location = new System.Drawing.Point(12, 25);
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(345, 20);
            this.registrationNumberTextBox.TabIndex = 0;
            this.registrationNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(12, 101);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(345, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.Location = new System.Drawing.Point(12, 271);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(345, 20);
            this.resultTextBox.TabIndex = 6;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultTextBox.Enter += new System.EventHandler(this.resultTextBox_Enter);
            // 
            // generateButton
            // 
            this.generateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.generateButton.Location = new System.Drawing.Point(115, 194);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(144, 52);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // permanentRadioButton
            // 
            this.permanentRadioButton.AutoSize = true;
            this.permanentRadioButton.Checked = true;
            this.permanentRadioButton.Location = new System.Drawing.Point(68, 148);
            this.permanentRadioButton.Name = "permanentRadioButton";
            this.permanentRadioButton.Size = new System.Drawing.Size(76, 17);
            this.permanentRadioButton.TabIndex = 2;
            this.permanentRadioButton.TabStop = true;
            this.permanentRadioButton.Text = "Permanent";
            this.permanentRadioButton.UseVisualStyleBackColor = true;
            this.permanentRadioButton.CheckedChanged += new System.EventHandler(this.radiobutton_CheckedChanged);
            // 
            // trialRadioButton
            // 
            this.trialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trialRadioButton.AutoSize = true;
            this.trialRadioButton.Location = new System.Drawing.Point(241, 148);
            this.trialRadioButton.Name = "trialRadioButton";
            this.trialRadioButton.Size = new System.Drawing.Size(62, 17);
            this.trialRadioButton.TabIndex = 3;
            this.trialRadioButton.Text = "90 days";
            this.trialRadioButton.UseVisualStyleBackColor = true;
            this.trialRadioButton.CheckedChanged += new System.EventHandler(this.radiobutton_CheckedChanged);
            // 
            // muteButton
            // 
            this.muteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.muteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.muteButton.Location = new System.Drawing.Point(287, 185);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(70, 70);
            this.muteButton.TabIndex = 5;
            this.muteButton.UseVisualStyleBackColor = true;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 303);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.trialRadioButton);
            this.Controls.Add(this.permanentRadioButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrationNumberTextBox);
            this.MinimumSize = new System.Drawing.Size(385, 342);
            this.Name = "Form1";
            this.Text = "AlphaLink keygen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.RadioButton permanentRadioButton;
        private System.Windows.Forms.RadioButton trialRadioButton;
        private System.Windows.Forms.Button muteButton;
    }
}

