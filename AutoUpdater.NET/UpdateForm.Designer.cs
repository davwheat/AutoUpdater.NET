namespace AutoUpdater.NET
{
    partial class UpdateForm
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
            this.newUpdateAvailableLabel = new System.Windows.Forms.Label();
            this.changeLogTextBox = new System.Windows.Forms.RichTextBox();
            this.changeLogLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.installUpdateButton = new System.Windows.Forms.Button();
            this.ignoreUpdateButton = new System.Windows.Forms.LinkLabel();
            this.oldVersionLabel = new System.Windows.Forms.Label();
            this.newVersionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newUpdateAvailableLabel
            // 
            this.newUpdateAvailableLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUpdateAvailableLabel.Location = new System.Drawing.Point(12, 9);
            this.newUpdateAvailableLabel.Name = "newUpdateAvailableLabel";
            this.newUpdateAvailableLabel.Size = new System.Drawing.Size(360, 40);
            this.newUpdateAvailableLabel.TabIndex = 0;
            this.newUpdateAvailableLabel.Text = "A new update is available!";
            this.newUpdateAvailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeLogTextBox
            // 
            this.changeLogTextBox.Location = new System.Drawing.Point(12, 137);
            this.changeLogTextBox.Name = "changeLogTextBox";
            this.changeLogTextBox.ReadOnly = true;
            this.changeLogTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.changeLogTextBox.Size = new System.Drawing.Size(360, 124);
            this.changeLogTextBox.TabIndex = 1;
            this.changeLogTextBox.Text = "";
            // 
            // changeLogLabel
            // 
            this.changeLogLabel.Location = new System.Drawing.Point(15, 114);
            this.changeLogLabel.Name = "changeLogLabel";
            this.changeLogLabel.Size = new System.Drawing.Size(357, 20);
            this.changeLogLabel.TabIndex = 2;
            this.changeLogLabel.Text = "Changelog";
            this.changeLogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(176, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "→";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your version";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // installUpdateButton
            // 
            this.installUpdateButton.Location = new System.Drawing.Point(109, 267);
            this.installUpdateButton.Name = "installUpdateButton";
            this.installUpdateButton.Size = new System.Drawing.Size(166, 32);
            this.installUpdateButton.TabIndex = 7;
            this.installUpdateButton.Text = "Install update";
            this.installUpdateButton.UseVisualStyleBackColor = true;
            this.installUpdateButton.Click += new System.EventHandler(this.InstallUpdateButton_Click);
            // 
            // ignoreUpdateButton
            // 
            this.ignoreUpdateButton.AutoSize = true;
            this.ignoreUpdateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ignoreUpdateButton.Location = new System.Drawing.Point(4, 293);
            this.ignoreUpdateButton.Name = "ignoreUpdateButton";
            this.ignoreUpdateButton.Size = new System.Drawing.Size(41, 15);
            this.ignoreUpdateButton.TabIndex = 8;
            this.ignoreUpdateButton.TabStop = true;
            this.ignoreUpdateButton.Text = "Ignore";
            // 
            // oldVersionLabel
            // 
            this.oldVersionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldVersionLabel.Location = new System.Drawing.Point(12, 82);
            this.oldVersionLabel.Name = "oldVersionLabel";
            this.oldVersionLabel.Size = new System.Drawing.Size(158, 22);
            this.oldVersionLabel.TabIndex = 9;
            this.oldVersionLabel.Text = "1.0.0.0";
            this.oldVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newVersionLabel
            // 
            this.newVersionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVersionLabel.Location = new System.Drawing.Point(215, 82);
            this.newVersionLabel.Name = "newVersionLabel";
            this.newVersionLabel.Size = new System.Drawing.Size(158, 22);
            this.newVersionLabel.TabIndex = 11;
            this.newVersionLabel.Text = "1.0.0.0";
            this.newVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "New version";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateForm
            // 
            this.AcceptButton = this.installUpdateButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.ignoreUpdateButton;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.ControlBox = false;
            this.Controls.Add(this.newVersionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oldVersionLabel);
            this.Controls.Add(this.ignoreUpdateButton);
            this.Controls.Add(this.installUpdateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeLogLabel);
            this.Controls.Add(this.changeLogTextBox);
            this.Controls.Add(this.newUpdateAvailableLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newUpdateAvailableLabel;
        private System.Windows.Forms.RichTextBox changeLogTextBox;
        private System.Windows.Forms.Label changeLogLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button installUpdateButton;
        private System.Windows.Forms.LinkLabel ignoreUpdateButton;
        private System.Windows.Forms.Label oldVersionLabel;
        private System.Windows.Forms.Label newVersionLabel;
        private System.Windows.Forms.Label label3;
    }
}