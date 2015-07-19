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
            this.headLbl = new System.Windows.Forms.Label();
            this.captionLbl = new System.Windows.Forms.Label();
            this.recentsPanel = new System.Windows.Forms.Panel();
            this.recentsHeadLbl = new System.Windows.Forms.Label();
            this.recentBtn = new Scribo.UI.Contorls.startPageButton();
            this.openBtn = new Scribo.UI.Contorls.startPageButton();
            this.newBtn = new Scribo.UI.Contorls.startPageButton();
            this.recentsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headLbl
            // 
            this.headLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headLbl.AutoSize = true;
            this.headLbl.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLbl.Location = new System.Drawing.Point(179, 94);
            this.headLbl.Name = "headLbl";
            this.headLbl.Size = new System.Drawing.Size(117, 47);
            this.headLbl.TabIndex = 0;
            this.headLbl.Tag = "startPage";
            this.headLbl.Text = "Scribo";
            this.headLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // captionLbl
            // 
            this.captionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captionLbl.AutoSize = true;
            this.captionLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLbl.ForeColor = System.Drawing.Color.DimGray;
            this.captionLbl.Location = new System.Drawing.Point(169, 141);
            this.captionLbl.Name = "captionLbl";
            this.captionLbl.Size = new System.Drawing.Size(137, 30);
            this.captionLbl.TabIndex = 1;
            this.captionLbl.Tag = "startPage";
            this.captionLbl.Text = "No files open";
            this.captionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recentsPanel
            // 
            this.recentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.recentsPanel.Controls.Add(this.recentsHeadLbl);
            this.recentsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recentsPanel.Location = new System.Drawing.Point(0, 276);
            this.recentsPanel.Name = "recentsPanel";
            this.recentsPanel.Size = new System.Drawing.Size(484, 185);
            this.recentsPanel.TabIndex = 5;
            this.recentsPanel.Visible = false;
            // 
            // recentsHeadLbl
            // 
            this.recentsHeadLbl.BackColor = System.Drawing.Color.Transparent;
            this.recentsHeadLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.recentsHeadLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentsHeadLbl.ForeColor = System.Drawing.Color.White;
            this.recentsHeadLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.recentsHeadLbl.Location = new System.Drawing.Point(0, 0);
            this.recentsHeadLbl.Name = "recentsHeadLbl";
            this.recentsHeadLbl.Size = new System.Drawing.Size(484, 26);
            this.recentsHeadLbl.TabIndex = 0;
            this.recentsHeadLbl.Tag = "lbl";
            this.recentsHeadLbl.Text = "Select a recent document...";
            this.recentsHeadLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // recentBtn
            // 
            this.recentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentBtn.AutoSize = true;
            this.recentBtn.BackColor = System.Drawing.Color.Transparent;
            this.recentBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.recentBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.recentBtn.Location = new System.Drawing.Point(303, 198);
            this.recentBtn.MaximumSize = new System.Drawing.Size(94, 104);
            this.recentBtn.MinimumSize = new System.Drawing.Size(94, 104);
            this.recentBtn.Name = "recentBtn";
            this.recentBtn.Size = new System.Drawing.Size(94, 104);
            this.recentBtn.TabIndex = 4;
            this.recentBtn.Tag = "startPage";
            this.recentBtn.Text = "Recent";
            this.recentBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // openBtn
            // 
            this.openBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openBtn.AutoSize = true;
            this.openBtn.BackColor = System.Drawing.Color.Transparent;
            this.openBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.openBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openBtn.Location = new System.Drawing.Point(195, 198);
            this.openBtn.MaximumSize = new System.Drawing.Size(94, 104);
            this.openBtn.MinimumSize = new System.Drawing.Size(94, 104);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(94, 104);
            this.openBtn.TabIndex = 3;
            this.openBtn.Tag = "startPage";
            this.openBtn.Text = "Open";
            this.openBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // newBtn
            // 
            this.newBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newBtn.AutoSize = true;
            this.newBtn.BackColor = System.Drawing.Color.Transparent;
            this.newBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newBtn.Location = new System.Drawing.Point(87, 198);
            this.newBtn.MaximumSize = new System.Drawing.Size(94, 104);
            this.newBtn.MinimumSize = new System.Drawing.Size(94, 104);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(94, 104);
            this.newBtn.TabIndex = 2;
            this.newBtn.Tag = "startPage";
            this.newBtn.Text = "New";
            this.newBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.recentsPanel);
            this.Controls.Add(this.recentBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.captionLbl);
            this.Controls.Add(this.headLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scribo";
            this.recentsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headLbl;
        private System.Windows.Forms.Label captionLbl;
        private UI.Contorls.startPageButton newBtn;
        private UI.Contorls.startPageButton openBtn;
        private UI.Contorls.startPageButton recentBtn;
        private System.Windows.Forms.Panel recentsPanel;
        private System.Windows.Forms.Label recentsHeadLbl;
    }
}

