
namespace RSA
{
    partial class RSAForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateButton = new System.Windows.Forms.Button();
            this.DecryptCheck = new System.Windows.Forms.CheckBox();
            this.InputTextFeld = new System.Windows.Forms.RichTextBox();
            this.InputText = new System.Windows.Forms.Label();
            this.OutputText = new System.Windows.Forms.Label();
            this.OutputTextFeld = new System.Windows.Forms.RichTextBox();
            this.Encryptcheck = new System.Windows.Forms.CheckBox();
            this.Title = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GenerateButton.BackgroundImage = global::RSA.Properties.Resources.background;
            this.GenerateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GenerateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GenerateButton.FlatAppearance.BorderSize = 5;
            this.GenerateButton.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.ForeColor = System.Drawing.Color.Black;
            this.GenerateButton.Location = new System.Drawing.Point(895, 480);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(272, 79);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DecryptCheck
            // 
            this.DecryptCheck.AutoSize = true;
            this.DecryptCheck.BackColor = System.Drawing.Color.Transparent;
            this.DecryptCheck.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptCheck.ForeColor = System.Drawing.Color.White;
            this.DecryptCheck.Location = new System.Drawing.Point(308, 113);
            this.DecryptCheck.Margin = new System.Windows.Forms.Padding(4);
            this.DecryptCheck.Name = "DecryptCheck";
            this.DecryptCheck.Size = new System.Drawing.Size(84, 23);
            this.DecryptCheck.TabIndex = 1;
            this.DecryptCheck.Text = "Decrypt ";
            this.DecryptCheck.UseVisualStyleBackColor = false;
            this.DecryptCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // InputTextFeld
            // 
            this.InputTextFeld.Location = new System.Drawing.Point(213, 144);
            this.InputTextFeld.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextFeld.Name = "InputTextFeld";
            this.InputTextFeld.Size = new System.Drawing.Size(835, 98);
            this.InputTextFeld.TabIndex = 3;
            this.InputTextFeld.Text = "";
            this.InputTextFeld.TextChanged += new System.EventHandler(this.InputTextFeld_TextChanged);
            // 
            // InputText
            // 
            this.InputText.AutoSize = true;
            this.InputText.BackColor = System.Drawing.Color.Transparent;
            this.InputText.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText.ForeColor = System.Drawing.Color.White;
            this.InputText.Location = new System.Drawing.Point(81, 144);
            this.InputText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(118, 28);
            this.InputText.TabIndex = 4;
            this.InputText.Text = "Plaintext: ";
            // 
            // OutputText
            // 
            this.OutputText.AutoSize = true;
            this.OutputText.BackColor = System.Drawing.Color.Transparent;
            this.OutputText.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputText.ForeColor = System.Drawing.Color.White;
            this.OutputText.Location = new System.Drawing.Point(81, 294);
            this.OutputText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(118, 26);
            this.OutputText.TabIndex = 5;
            this.OutputText.Text = "Ciphertext:";
            this.OutputText.Click += new System.EventHandler(this.label2_Click);
            // 
            // OutputTextFeld
            // 
            this.OutputTextFeld.BackColor = System.Drawing.Color.White;
            this.OutputTextFeld.Location = new System.Drawing.Point(213, 296);
            this.OutputTextFeld.Margin = new System.Windows.Forms.Padding(4);
            this.OutputTextFeld.Name = "OutputTextFeld";
            this.OutputTextFeld.Size = new System.Drawing.Size(835, 116);
            this.OutputTextFeld.TabIndex = 6;
            this.OutputTextFeld.Text = "";
            // 
            // Encryptcheck
            // 
            this.Encryptcheck.AutoSize = true;
            this.Encryptcheck.BackColor = System.Drawing.Color.Transparent;
            this.Encryptcheck.Checked = true;
            this.Encryptcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Encryptcheck.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encryptcheck.ForeColor = System.Drawing.Color.White;
            this.Encryptcheck.Location = new System.Drawing.Point(213, 113);
            this.Encryptcheck.Margin = new System.Windows.Forms.Padding(4);
            this.Encryptcheck.Name = "Encryptcheck";
            this.Encryptcheck.Size = new System.Drawing.Size(77, 23);
            this.Encryptcheck.TabIndex = 7;
            this.Encryptcheck.Text = "Encrypt";
            this.Encryptcheck.UseVisualStyleBackColor = false;
            this.Encryptcheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(-4, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(169, 86);
            this.Title.TabIndex = 8;
            this.Title.Text = "RSA";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.KeyLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.KeyLabel.Location = new System.Drawing.Point(788, 114);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(52, 26);
            this.KeyLabel.TabIndex = 9;
            this.KeyLabel.Text = "Key:";
            this.KeyLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // KeyText
            // 
            this.KeyText.Location = new System.Drawing.Point(837, 116);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(100, 24);
            this.KeyText.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(943, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "N:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(973, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 24);
            this.textBox1.TabIndex = 12;
            // 
            // RSAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RSA.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyText);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Encryptcheck);
            this.Controls.Add(this.OutputTextFeld);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.InputTextFeld);
            this.Controls.Add(this.DecryptCheck);
            this.Controls.Add(this.GenerateButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RSAForm";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.textBox1.Visible = false;
            this.label1.Visible = false;

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox DecryptCheck;
        private System.Windows.Forms.RichTextBox InputTextFeld;
        private System.Windows.Forms.Label InputText;
        private System.Windows.Forms.Label OutputText;
        private System.Windows.Forms.RichTextBox OutputTextFeld;
        private System.Windows.Forms.CheckBox Encryptcheck;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.TextBox KeyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

