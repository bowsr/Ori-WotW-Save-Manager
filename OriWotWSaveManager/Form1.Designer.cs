namespace OriWotWSaveManager {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveSelectionList = new System.Windows.Forms.ListBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.debugButton = new System.Windows.Forms.Button();
            this.debugModeText = new System.Windows.Forms.TextBox();
            this.debugStatusText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveSelectionList
            // 
            this.saveSelectionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.saveSelectionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveSelectionList.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSelectionList.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.saveSelectionList.FormattingEnabled = true;
            this.saveSelectionList.ItemHeight = 16;
            this.saveSelectionList.Location = new System.Drawing.Point(12, 9);
            this.saveSelectionList.Name = "saveSelectionList";
            this.saveSelectionList.Size = new System.Drawing.Size(348, 482);
            this.saveSelectionList.Sorted = true;
            this.saveSelectionList.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.loadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.loadButton.Location = new System.Drawing.Point(12, 502);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(125, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load Save";
            this.loadButton.UseVisualStyleBackColor = false;
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.importButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.importButton.Location = new System.Drawing.Point(12, 531);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(125, 23);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Import Save";
            this.importButton.UseVisualStyleBackColor = false;
            // 
            // debugButton
            // 
            this.debugButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.debugButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.debugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debugButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.debugButton.Location = new System.Drawing.Point(235, 502);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(125, 23);
            this.debugButton.TabIndex = 3;
            this.debugButton.Text = "Toggle Debug Mode";
            this.debugButton.UseVisualStyleBackColor = false;
            // 
            // debugModeText
            // 
            this.debugModeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.debugModeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugModeText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.debugModeText.Location = new System.Drawing.Point(235, 536);
            this.debugModeText.Name = "debugModeText";
            this.debugModeText.Size = new System.Drawing.Size(84, 13);
            this.debugModeText.TabIndex = 4;
            this.debugModeText.Text = "Debug Mode:";
            this.debugModeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // debugStatusText
            // 
            this.debugStatusText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.debugStatusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugStatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.debugStatusText.Location = new System.Drawing.Point(313, 536);
            this.debugStatusText.Name = "debugStatusText";
            this.debugStatusText.Size = new System.Drawing.Size(47, 13);
            this.debugStatusText.TabIndex = 5;
            this.debugStatusText.Text = "Enabled";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(372, 563);
            this.Controls.Add(this.debugStatusText);
            this.Controls.Add(this.debugModeText);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveSelectionList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ori WotW Save Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox saveSelectionList;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.TextBox debugModeText;
        private System.Windows.Forms.TextBox debugStatusText;
    }
}

