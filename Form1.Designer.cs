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
            moving_button = new Button();
            SuspendLayout();
            // 
            // moving_button
            // 
            moving_button.BackColor = Color.Red;
            moving_button.Font = new Font("휴먼둥근헤드라인", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            moving_button.ForeColor = Color.Yellow;
            moving_button.Location = new Point(170, 103);
            moving_button.Name = "moving_button";
            moving_button.Size = new Size(301, 121);
            moving_button.TabIndex = 0;
            moving_button.Text = "나를 잡아봐";
            moving_button.UseVisualStyleBackColor = false;
            moving_button.Click += moving_button_Click;
            moving_button.MouseEnter += moving_button_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(moving_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button moving_button;
    }
}
