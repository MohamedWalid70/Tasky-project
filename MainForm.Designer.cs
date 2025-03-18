
namespace TaskManagementSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainTitle = new System.Windows.Forms.Label();
            this.SortPic = new System.Windows.Forms.PictureBox();
            this.FilterPic = new System.Windows.Forms.PictureBox();
            this.ReportPic = new System.Windows.Forms.PictureBox();
            this.TrackPic = new System.Windows.Forms.PictureBox();
            this.SearchPic = new System.Windows.Forms.PictureBox();
            this.CancelOperationPic = new System.Windows.Forms.PictureBox();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.TaskGridView = new System.Windows.Forms.DataGridView();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PageUpDown = new System.Windows.Forms.NumericUpDown();
            this.LogoutPicBox = new System.Windows.Forms.PictureBox();
            this.AddPicBox = new System.Windows.Forms.PictureBox();
            this.GroupButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SortPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelOperationPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Roboto Cn", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.Location = new System.Drawing.Point(72, 9);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(400, 44);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Task Management System";
            // 
            // SortPic
            // 
            this.SortPic.Image = ((System.Drawing.Image)(resources.GetObject("SortPic.Image")));
            this.SortPic.Location = new System.Drawing.Point(798, 78);
            this.SortPic.MaximumSize = new System.Drawing.Size(40, 34);
            this.SortPic.MinimumSize = new System.Drawing.Size(40, 34);
            this.SortPic.Name = "SortPic";
            this.SortPic.Size = new System.Drawing.Size(40, 34);
            this.SortPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SortPic.TabIndex = 5;
            this.SortPic.TabStop = false;
            this.ToolTip1.SetToolTip(this.SortPic, "Sort");
            this.SortPic.Click += new System.EventHandler(this.SortPic_Click);
            // 
            // FilterPic
            // 
            this.FilterPic.Image = ((System.Drawing.Image)(resources.GetObject("FilterPic.Image")));
            this.FilterPic.Location = new System.Drawing.Point(711, 79);
            this.FilterPic.MaximumSize = new System.Drawing.Size(40, 34);
            this.FilterPic.MinimumSize = new System.Drawing.Size(40, 34);
            this.FilterPic.Name = "FilterPic";
            this.FilterPic.Size = new System.Drawing.Size(40, 34);
            this.FilterPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FilterPic.TabIndex = 6;
            this.FilterPic.TabStop = false;
            this.ToolTip1.SetToolTip(this.FilterPic, "Filter");
            this.FilterPic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FilterPic_MouseClick);
            // 
            // ReportPic
            // 
            this.ReportPic.Image = ((System.Drawing.Image)(resources.GetObject("ReportPic.Image")));
            this.ReportPic.Location = new System.Drawing.Point(623, 78);
            this.ReportPic.MaximumSize = new System.Drawing.Size(40, 34);
            this.ReportPic.MinimumSize = new System.Drawing.Size(40, 34);
            this.ReportPic.Name = "ReportPic";
            this.ReportPic.Size = new System.Drawing.Size(40, 34);
            this.ReportPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReportPic.TabIndex = 7;
            this.ReportPic.TabStop = false;
            this.ToolTip1.SetToolTip(this.ReportPic, "Generate report");
            this.ReportPic.Click += new System.EventHandler(this.ReportPic_Click);
            // 
            // TrackPic
            // 
            this.TrackPic.Image = ((System.Drawing.Image)(resources.GetObject("TrackPic.Image")));
            this.TrackPic.Location = new System.Drawing.Point(530, 78);
            this.TrackPic.MaximumSize = new System.Drawing.Size(40, 34);
            this.TrackPic.MinimumSize = new System.Drawing.Size(40, 36);
            this.TrackPic.Name = "TrackPic";
            this.TrackPic.Size = new System.Drawing.Size(40, 36);
            this.TrackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TrackPic.TabIndex = 8;
            this.TrackPic.TabStop = false;
            this.ToolTip1.SetToolTip(this.TrackPic, "Track overdue tasks");
            this.TrackPic.Click += new System.EventHandler(this.TrackPic_Click);
            // 
            // SearchPic
            // 
            this.SearchPic.Image = ((System.Drawing.Image)(resources.GetObject("SearchPic.Image")));
            this.SearchPic.Location = new System.Drawing.Point(231, 78);
            this.SearchPic.Name = "SearchPic";
            this.SearchPic.Size = new System.Drawing.Size(43, 34);
            this.SearchPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchPic.TabIndex = 9;
            this.SearchPic.TabStop = false;
            this.ToolTip1.SetToolTip(this.SearchPic, "Search");
            this.SearchPic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchPic_MouseClick);
            // 
            // CancelOperationPic
            // 
            this.CancelOperationPic.Image = ((System.Drawing.Image)(resources.GetObject("CancelOperationPic.Image")));
            this.CancelOperationPic.Location = new System.Drawing.Point(295, 78);
            this.CancelOperationPic.MaximumSize = new System.Drawing.Size(43, 34);
            this.CancelOperationPic.MinimumSize = new System.Drawing.Size(43, 34);
            this.CancelOperationPic.Name = "CancelOperationPic";
            this.CancelOperationPic.Size = new System.Drawing.Size(43, 34);
            this.CancelOperationPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelOperationPic.TabIndex = 10;
            this.CancelOperationPic.TabStop = false;
            this.ToolTip1.SetToolTip(this.CancelOperationPic, "Cancels all the previous operations ");
            this.CancelOperationPic.Click += new System.EventHandler(this.CancelOperationPic_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTxt.Location = new System.Drawing.Point(51, 79);
            this.SearchTxt.MaximumSize = new System.Drawing.Size(163, 34);
            this.SearchTxt.MinimumSize = new System.Drawing.Size(163, 34);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PlaceholderText = "Search your tasks";
            this.SearchTxt.Size = new System.Drawing.Size(163, 30);
            this.SearchTxt.TabIndex = 11;
            // 
            // TaskGridView
            // 
            this.TaskGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TaskGridView.ColumnHeadersHeight = 30;
            this.TaskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TaskGridView.Location = new System.Drawing.Point(3, 151);
            this.TaskGridView.MaximumSize = new System.Drawing.Size(900, 362);
            this.TaskGridView.MinimumSize = new System.Drawing.Size(900, 362);
            this.TaskGridView.Name = "TaskGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TaskGridView.RowTemplate.Height = 25;
            this.TaskGridView.Size = new System.Drawing.Size(900, 362);
            this.TaskGridView.TabIndex = 12;
            this.TaskGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TaskGridView_MouseDoubleClick);
            // 
            // ToolTip1
            // 
            this.ToolTip1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ToolTip1.ForeColor = System.Drawing.SystemColors.Info;
            // 
            // PageUpDown
            // 
            this.PageUpDown.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PageUpDown.Location = new System.Drawing.Point(395, 536);
            this.PageUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.PageUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageUpDown.Name = "PageUpDown";
            this.PageUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PageUpDown.Size = new System.Drawing.Size(91, 26);
            this.PageUpDown.TabIndex = 16;
            this.PageUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip1.SetToolTip(this.PageUpDown, "Pagination");
            this.PageUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageUpDown.ValueChanged += new System.EventHandler(this.PageUpDown_ValueChanged);
            // 
            // LogoutPicBox
            // 
            this.LogoutPicBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoutPicBox.Image")));
            this.LogoutPicBox.Location = new System.Drawing.Point(134, 530);
            this.LogoutPicBox.MaximumSize = new System.Drawing.Size(43, 34);
            this.LogoutPicBox.MinimumSize = new System.Drawing.Size(43, 34);
            this.LogoutPicBox.Name = "LogoutPicBox";
            this.LogoutPicBox.Size = new System.Drawing.Size(43, 34);
            this.LogoutPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoutPicBox.TabIndex = 17;
            this.LogoutPicBox.TabStop = false;
            this.ToolTip1.SetToolTip(this.LogoutPicBox, "Logout");
            this.LogoutPicBox.Click += new System.EventHandler(this.LogoutPicBox_Click);
            // 
            // AddPicBox
            // 
            this.AddPicBox.Image = ((System.Drawing.Image)(resources.GetObject("AddPicBox.Image")));
            this.AddPicBox.Location = new System.Drawing.Point(413, 78);
            this.AddPicBox.MaximumSize = new System.Drawing.Size(43, 34);
            this.AddPicBox.MinimumSize = new System.Drawing.Size(43, 34);
            this.AddPicBox.Name = "AddPicBox";
            this.AddPicBox.Size = new System.Drawing.Size(43, 34);
            this.AddPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPicBox.TabIndex = 18;
            this.AddPicBox.TabStop = false;
            this.ToolTip1.SetToolTip(this.AddPicBox, "Adds a new task");
            this.AddPicBox.Click += new System.EventHandler(this.AddPicBox_Click);
            // 
            // GroupButton
            // 
            this.GroupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GroupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GroupButton.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupButton.Location = new System.Drawing.Point(725, 530);
            this.GroupButton.MaximumSize = new System.Drawing.Size(100, 34);
            this.GroupButton.MinimumSize = new System.Drawing.Size(43, 34);
            this.GroupButton.Name = "GroupButton";
            this.GroupButton.Size = new System.Drawing.Size(56, 34);
            this.GroupButton.TabIndex = 14;
            this.GroupButton.Text = "Group";
            this.GroupButton.UseVisualStyleBackColor = true;
            this.GroupButton.Click += new System.EventHandler(this.GroupButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 582);
            this.ControlBox = false;
            this.Controls.Add(this.AddPicBox);
            this.Controls.Add(this.LogoutPicBox);
            this.Controls.Add(this.PageUpDown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GroupButton);
            this.Controls.Add(this.TaskGridView);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.CancelOperationPic);
            this.Controls.Add(this.SearchPic);
            this.Controls.Add(this.TrackPic);
            this.Controls.Add(this.ReportPic);
            this.Controls.Add(this.FilterPic);
            this.Controls.Add(this.SortPic);
            this.Controls.Add(this.MainTitle);
            this.MaximumSize = new System.Drawing.Size(922, 620);
            this.MinimumSize = new System.Drawing.Size(922, 620);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.SortPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelOperationPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.PictureBox SortPic;
        private System.Windows.Forms.PictureBox FilterPic;
        private System.Windows.Forms.PictureBox ReportPic;
        private System.Windows.Forms.PictureBox TrackPic;
        private System.Windows.Forms.PictureBox SearchPic;
        private System.Windows.Forms.PictureBox CancelOperationPic;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.DataGridView TaskGridView;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.Button GroupButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown PageUpDown;
        private System.Windows.Forms.PictureBox LogoutPicBox;
        private System.Windows.Forms.PictureBox AddPicBox;
    }
}

