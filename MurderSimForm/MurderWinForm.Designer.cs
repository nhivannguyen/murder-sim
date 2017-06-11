namespace MurderSimForm
{
    partial class MurderWinForm
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
			this.inputBox = new System.Windows.Forms.TextBox();
			this.enterButt = new System.Windows.Forms.Button();
			this.nameLb = new System.Windows.Forms.Label();
			this.locationLb = new System.Windows.Forms.Label();
			this.dispBox = new System.Windows.Forms.RichTextBox();
			this.inventoryLb = new System.Windows.Forms.Label();
			this.nameData = new System.Windows.Forms.TextBox();
			this.locData = new System.Windows.Forms.TextBox();
			this.invenData = new System.Windows.Forms.TextBox();
			this.targetLb = new System.Windows.Forms.Label();
			this.targetData = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// inputBox
			// 
			this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.inputBox.Location = new System.Drawing.Point(12, 578);
			this.inputBox.Multiline = true;
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(730, 42);
			this.inputBox.TabIndex = 0;
			// 
			// enterButt
			// 
			this.enterButt.BackColor = System.Drawing.SystemColors.Highlight;
			this.enterButt.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.enterButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
			this.enterButt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.enterButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.enterButt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.enterButt.Location = new System.Drawing.Point(754, 578);
			this.enterButt.Name = "enterButt";
			this.enterButt.Size = new System.Drawing.Size(107, 42);
			this.enterButt.TabIndex = 1;
			this.enterButt.Text = "Enter";
			this.enterButt.UseVisualStyleBackColor = false;
			this.enterButt.Click += new System.EventHandler(this.enterButt_Click);
			// 
			// nameLb
			// 
			this.nameLb.AutoSize = true;
			this.nameLb.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameLb.Location = new System.Drawing.Point(882, 13);
			this.nameLb.Name = "nameLb";
			this.nameLb.Size = new System.Drawing.Size(54, 23);
			this.nameLb.TabIndex = 2;
			this.nameLb.Text = "Name";
			// 
			// locationLb
			// 
			this.locationLb.AutoSize = true;
			this.locationLb.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.locationLb.Location = new System.Drawing.Point(882, 216);
			this.locationLb.Name = "locationLb";
			this.locationLb.Size = new System.Drawing.Size(98, 23);
			this.locationLb.TabIndex = 3;
			this.locationLb.Text = "Location";
			// 
			// dispBox
			// 
			this.dispBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dispBox.Location = new System.Drawing.Point(13, 13);
			this.dispBox.Name = "dispBox";
			this.dispBox.ReadOnly = true;
			this.dispBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.dispBox.ShowSelectionMargin = true;
			this.dispBox.Size = new System.Drawing.Size(848, 551);
			this.dispBox.TabIndex = 5;
			this.dispBox.Text = "";
			// 
			// inventoryLb
			// 
			this.inventoryLb.AutoSize = true;
			this.inventoryLb.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inventoryLb.Location = new System.Drawing.Point(882, 392);
			this.inventoryLb.Name = "inventoryLb";
			this.inventoryLb.Size = new System.Drawing.Size(109, 23);
			this.inventoryLb.TabIndex = 6;
			this.inventoryLb.Text = "Inventory";
			// 
			// nameData
			// 
			this.nameData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameData.Location = new System.Drawing.Point(886, 37);
			this.nameData.Name = "nameData";
			this.nameData.ReadOnly = true;
			this.nameData.Size = new System.Drawing.Size(192, 31);
			this.nameData.TabIndex = 8;
			// 
			// locData
			// 
			this.locData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.locData.Location = new System.Drawing.Point(886, 239);
			this.locData.Multiline = true;
			this.locData.Name = "locData";
			this.locData.ReadOnly = true;
			this.locData.Size = new System.Drawing.Size(192, 139);
			this.locData.TabIndex = 9;
			// 
			// invenData
			// 
			this.invenData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.invenData.Location = new System.Drawing.Point(886, 415);
			this.invenData.Multiline = true;
			this.invenData.Name = "invenData";
			this.invenData.ReadOnly = true;
			this.invenData.Size = new System.Drawing.Size(192, 205);
			this.invenData.TabIndex = 10;
			// 
			// targetLb
			// 
			this.targetLb.AutoSize = true;
			this.targetLb.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.targetLb.Location = new System.Drawing.Point(882, 81);
			this.targetLb.Name = "targetLb";
			this.targetLb.Size = new System.Drawing.Size(109, 23);
			this.targetLb.TabIndex = 11;
			this.targetLb.Text = "Target(s)";
			// 
			// targetData
			// 
			this.targetData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.targetData.Location = new System.Drawing.Point(886, 105);
			this.targetData.Multiline = true;
			this.targetData.Name = "targetData";
			this.targetData.ReadOnly = true;
			this.targetData.Size = new System.Drawing.Size(192, 92);
			this.targetData.TabIndex = 12;
			// 
			// MurderWinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(1090, 632);
			this.Controls.Add(this.targetData);
			this.Controls.Add(this.targetLb);
			this.Controls.Add(this.invenData);
			this.Controls.Add(this.locData);
			this.Controls.Add(this.nameData);
			this.Controls.Add(this.inventoryLb);
			this.Controls.Add(this.dispBox);
			this.Controls.Add(this.locationLb);
			this.Controls.Add(this.nameLb);
			this.Controls.Add(this.enterButt);
			this.Controls.Add(this.inputBox);
			this.Name = "MurderWinForm";
			this.Text = "MurderWinForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button enterButt;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label locationLb;
        private System.Windows.Forms.RichTextBox dispBox;
		private System.Windows.Forms.Label inventoryLb;
		private System.Windows.Forms.TextBox nameData;
		private System.Windows.Forms.TextBox locData;
		private System.Windows.Forms.TextBox invenData;
		private System.Windows.Forms.Label targetLb;
		private System.Windows.Forms.TextBox targetData;
	}
}

