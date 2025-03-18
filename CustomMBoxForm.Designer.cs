
namespace TaskManagementSystem
{
    partial class CustomMBoxForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChoiceCombo = new System.Windows.Forms.ComboBox();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-8, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 28);
            this.panel1.TabIndex = 0;
            // 
            // ChoiceCombo
            // 
            this.ChoiceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiceCombo.FormattingEnabled = true;
            this.ChoiceCombo.Location = new System.Drawing.Point(61, 12);
            this.ChoiceCombo.Name = "ChoiceCombo";
            this.ChoiceCombo.Size = new System.Drawing.Size(121, 23);
            this.ChoiceCombo.TabIndex = 1;
            // 
            // SelectBtn
            // 
            this.SelectBtn.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectBtn.Location = new System.Drawing.Point(88, 54);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(75, 25);
            this.SelectBtn.TabIndex = 2;
            this.SelectBtn.Text = "Ok";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // CustomMBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 116);
            this.ControlBox = false;
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.ChoiceCombo);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(258, 132);
            this.MinimumSize = new System.Drawing.Size(258, 132);
            this.Name = "CustomMBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomMBoxForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ChoiceCombo;
        private System.Windows.Forms.Button SelectBtn;
    }
}