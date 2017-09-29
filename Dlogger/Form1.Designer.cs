namespace Dlogger
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
            this.TopButton = new System.Windows.Forms.Button();
            this.ButtonButton = new System.Windows.Forms.Button();
            this.OtherBUtton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopButton
            // 
            this.TopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopButton.Location = new System.Drawing.Point(22, 44);
            this.TopButton.Name = "TopButton";
            this.TopButton.Size = new System.Drawing.Size(130, 55);
            this.TopButton.TabIndex = 0;
            this.TopButton.Text = "<---";
            this.TopButton.UseVisualStyleBackColor = true;
            this.TopButton.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // ButtonButton
            // 
            this.ButtonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonButton.Location = new System.Drawing.Point(22, 172);
            this.ButtonButton.Name = "ButtonButton";
            this.ButtonButton.Size = new System.Drawing.Size(130, 55);
            this.ButtonButton.TabIndex = 1;
            this.ButtonButton.Text = "--->";
            this.ButtonButton.UseVisualStyleBackColor = true;
            this.ButtonButton.Click += new System.EventHandler(this.ButtonButton_Click);
            // 
            // OtherBUtton
            // 
            this.OtherBUtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherBUtton.Location = new System.Drawing.Point(22, 316);
            this.OtherBUtton.Name = "OtherBUtton";
            this.OtherBUtton.Size = new System.Drawing.Size(130, 55);
            this.OtherBUtton.TabIndex = 2;
            this.OtherBUtton.Text = "SouthSide";
            this.OtherBUtton.UseVisualStyleBackColor = true;
            this.OtherBUtton.Click += new System.EventHandler(this.OtherBUtton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(253, 269);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(339, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "LogText";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OtherBUtton);
            this.Controls.Add(this.ButtonButton);
            this.Controls.Add(this.TopButton);
            this.Name = "Form1";
            this.Text = "DLogger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TopButton;
        private System.Windows.Forms.Button ButtonButton;
        private System.Windows.Forms.Button OtherBUtton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

