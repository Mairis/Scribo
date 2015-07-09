namespace Scribo
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainTstrip = new System.Windows.Forms.ToolStrip();
            this.newTstripBtn = new System.Windows.Forms.ToolStripButton();
            this.openTstripBtn = new System.Windows.Forms.ToolStripButton();
            this.saveTstripBtn = new System.Windows.Forms.ToolStripButton();
            this.mainTxtBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mainTstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTstrip
            // 
            this.mainTstrip.AutoSize = false;
            this.mainTstrip.BackColor = System.Drawing.Color.White;
            this.mainTstrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainTstrip.CanOverflow = false;
            this.mainTstrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.mainTstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainTstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTstripBtn,
            this.openTstripBtn,
            this.saveTstripBtn});
            this.mainTstrip.Location = new System.Drawing.Point(0, 0);
            this.mainTstrip.Name = "mainTstrip";
            this.mainTstrip.Padding = new System.Windows.Forms.Padding(0);
            this.mainTstrip.Size = new System.Drawing.Size(484, 52);
            this.mainTstrip.TabIndex = 0;
            // 
            // newTstripBtn
            // 
            this.newTstripBtn.AutoSize = false;
            this.newTstripBtn.Image = ((System.Drawing.Image)(resources.GetObject("newTstripBtn.Image")));
            this.newTstripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTstripBtn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.newTstripBtn.Name = "newTstripBtn";
            this.newTstripBtn.Size = new System.Drawing.Size(48, 48);
            this.newTstripBtn.Text = "&New";
            this.newTstripBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newTstripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newTstripBtn.ToolTipText = "New file";
            // 
            // openTstripBtn
            // 
            this.openTstripBtn.AutoSize = false;
            this.openTstripBtn.Image = ((System.Drawing.Image)(resources.GetObject("openTstripBtn.Image")));
            this.openTstripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openTstripBtn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.openTstripBtn.Name = "openTstripBtn";
            this.openTstripBtn.Size = new System.Drawing.Size(48, 48);
            this.openTstripBtn.Text = "&Open";
            this.openTstripBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openTstripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.openTstripBtn.ToolTipText = "Open a file";
            // 
            // saveTstripBtn
            // 
            this.saveTstripBtn.AutoSize = false;
            this.saveTstripBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveTstripBtn.Image")));
            this.saveTstripBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveTstripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTstripBtn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.saveTstripBtn.Name = "saveTstripBtn";
            this.saveTstripBtn.Size = new System.Drawing.Size(48, 48);
            this.saveTstripBtn.Text = "&Save";
            this.saveTstripBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveTstripBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveTstripBtn.ToolTipText = "Save the current file";
            // 
            // mainTxtBox
            // 
            this.mainTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTxtBox.BackColor = System.Drawing.Color.White;
            this.mainTxtBox.Location = new System.Drawing.Point(0, 52);
            this.mainTxtBox.Multiline = true;
            this.mainTxtBox.Name = "mainTxtBox";
            this.mainTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainTxtBox.Size = new System.Drawing.Size(484, 409);
            this.mainTxtBox.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.mainTxtBox);
            this.Controls.Add(this.mainTstrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scribo";
            this.mainTstrip.ResumeLayout(false);
            this.mainTstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainTstrip;
        private System.Windows.Forms.TextBox mainTxtBox;
        private System.Windows.Forms.ToolStripButton saveTstripBtn;
        private System.Windows.Forms.ToolStripButton newTstripBtn;
        private System.Windows.Forms.ToolStripButton openTstripBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

