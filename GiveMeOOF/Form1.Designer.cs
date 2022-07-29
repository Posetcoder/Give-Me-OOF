namespace GiveMeOOF
{
    partial class GiveMeOof
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveMeOof));
            this.changeOof = new System.Windows.Forms.Button();
            this.changeAllVersionsOof = new System.Windows.Forms.CheckBox();
            this.versionTextBoxOof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeOof
            // 
            this.changeOof.BackColor = System.Drawing.Color.Gray;
            this.changeOof.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOof.ForeColor = System.Drawing.SystemColors.WindowText;
            this.changeOof.Location = new System.Drawing.Point(12, 120);
            this.changeOof.Name = "changeOof";
            this.changeOof.Size = new System.Drawing.Size(193, 37);
            this.changeOof.TabIndex = 0;
            this.changeOof.Text = "Change Sound To OOF";
            this.changeOof.UseVisualStyleBackColor = false;
            this.changeOof.Click += new System.EventHandler(this.changeOof_Click);
            // 
            // changeAllVersionsOof
            // 
            this.changeAllVersionsOof.AutoSize = true;
            this.changeAllVersionsOof.Checked = true;
            this.changeAllVersionsOof.CheckState = System.Windows.Forms.CheckState.Checked;
            this.changeAllVersionsOof.Location = new System.Drawing.Point(43, 25);
            this.changeAllVersionsOof.Name = "changeAllVersionsOof";
            this.changeAllVersionsOof.Size = new System.Drawing.Size(118, 17);
            this.changeAllVersionsOof.TabIndex = 1;
            this.changeAllVersionsOof.Text = "Change all versions";
            this.changeAllVersionsOof.UseVisualStyleBackColor = true;
            this.changeAllVersionsOof.CheckedChanged += new System.EventHandler(this.changeAllVersionsOof_CheckedChanged);
            // 
            // versionTextBoxOof
            // 
            this.versionTextBoxOof.Location = new System.Drawing.Point(52, 81);
            this.versionTextBoxOof.Name = "versionTextBoxOof";
            this.versionTextBoxOof.Size = new System.Drawing.Size(100, 20);
            this.versionTextBoxOof.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter version:";
            // 
            // GiveMeOof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.versionTextBoxOof);
            this.Controls.Add(this.changeAllVersionsOof);
            this.Controls.Add(this.changeOof);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiveMeOof";
            this.Text = "Give Me OOF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeOof;
        private System.Windows.Forms.CheckBox changeAllVersionsOof;
        private System.Windows.Forms.TextBox versionTextBoxOof;
        private System.Windows.Forms.Label label1;
    }
}

