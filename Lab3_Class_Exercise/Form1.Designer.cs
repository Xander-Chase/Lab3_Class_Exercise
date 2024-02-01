namespace Lab3_Class_Exercise
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
            BtnDisplayInfo = new Button();
            SuspendLayout();
            // 
            // BtnDisplayInfo
            // 
            BtnDisplayInfo.Location = new Point(500, 212);
            BtnDisplayInfo.Name = "BtnDisplayInfo";
            BtnDisplayInfo.Size = new Size(94, 29);
            BtnDisplayInfo.TabIndex = 0;
            BtnDisplayInfo.Text = "button1";
            BtnDisplayInfo.UseVisualStyleBackColor = true;
            BtnDisplayInfo.Click += BtnDisplayInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDisplayInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnDisplayInfo;
    }
}
