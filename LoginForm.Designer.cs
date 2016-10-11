namespace LoginFormExample
{
    partial class LoginForm
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
            this.LoginStatusStrip = new System.Windows.Forms.StatusStrip();
            this.LoginProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.LoginFormLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginStatusStrip.SuspendLayout();
            this.LoginFormLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginStatusStrip
            // 
            this.LoginStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginProgressBar});
            this.LoginStatusStrip.Location = new System.Drawing.Point(0, 179);
            this.LoginStatusStrip.Name = "LoginStatusStrip";
            this.LoginStatusStrip.Size = new System.Drawing.Size(304, 22);
            this.LoginStatusStrip.TabIndex = 0;
            // 
            // LoginProgressBar
            // 
            this.LoginProgressBar.Name = "LoginProgressBar";
            this.LoginProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // LoginFormLayout
            // 
            this.LoginFormLayout.ColumnCount = 1;
            this.LoginFormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LoginFormLayout.Controls.Add(this.UsernameLabel, 0, 0);
            this.LoginFormLayout.Controls.Add(this.UsernameTextBox, 0, 1);
            this.LoginFormLayout.Controls.Add(this.PasswordLabel, 0, 2);
            this.LoginFormLayout.Controls.Add(this.PasswordTextBox, 0, 3);
            this.LoginFormLayout.Controls.Add(this.RememberMeCheckBox, 0, 4);
            this.LoginFormLayout.Controls.Add(this.LoginButton, 0, 5);
            this.LoginFormLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginFormLayout.Location = new System.Drawing.Point(0, 0);
            this.LoginFormLayout.Name = "LoginFormLayout";
            this.LoginFormLayout.RowCount = 6;
            this.LoginFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LoginFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.LoginFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LoginFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.LoginFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.LoginFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LoginFormLayout.Size = new System.Drawing.Size(304, 179);
            this.LoginFormLayout.TabIndex = 1;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameLabel.Location = new System.Drawing.Point(3, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(298, 26);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(3, 29);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(298, 23);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(3, 58);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(298, 26);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(3, 87);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(298, 23);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.AutoSize = true;
            this.RememberMeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RememberMeCheckBox.Location = new System.Drawing.Point(3, 119);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Size = new System.Drawing.Size(298, 19);
            this.RememberMeCheckBox.TabIndex = 3;
            this.RememberMeCheckBox.Text = "Remember me?";
            this.RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginButton.Location = new System.Drawing.Point(226, 144);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 32);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.LoginFormLayout);
            this.Controls.Add(this.LoginStatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.LoginStatusStrip.ResumeLayout(false);
            this.LoginStatusStrip.PerformLayout();
            this.LoginFormLayout.ResumeLayout(false);
            this.LoginFormLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip LoginStatusStrip;
        private System.Windows.Forms.TableLayoutPanel LoginFormLayout;
        private System.Windows.Forms.ToolStripProgressBar LoginProgressBar;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox RememberMeCheckBox;
        private System.Windows.Forms.Button LoginButton;
    }
}

