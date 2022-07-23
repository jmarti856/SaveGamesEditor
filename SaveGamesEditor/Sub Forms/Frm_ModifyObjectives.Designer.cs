
namespace SaveGamesEditor
{
    partial class Frm_ModifyObjectives
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
            this.Textbox_HashCode = new System.Windows.Forms.TextBox();
            this.Listbox_HashCode = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Numeric_CurrentCount = new System.Windows.Forms.NumericUpDown();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_CurrentCount)).BeginInit();
            this.SuspendLayout();
            // 
            // Textbox_HashCode
            // 
            this.Textbox_HashCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_HashCode.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_HashCode.Location = new System.Drawing.Point(78, 12);
            this.Textbox_HashCode.Name = "Textbox_HashCode";
            this.Textbox_HashCode.ReadOnly = true;
            this.Textbox_HashCode.Size = new System.Drawing.Size(354, 20);
            this.Textbox_HashCode.TabIndex = 3;
            // 
            // Listbox_HashCode
            // 
            this.Listbox_HashCode.AutoSize = true;
            this.Listbox_HashCode.Location = new System.Drawing.Point(12, 15);
            this.Listbox_HashCode.Name = "Listbox_HashCode";
            this.Listbox_HashCode.Size = new System.Drawing.Size(60, 13);
            this.Listbox_HashCode.TabIndex = 2;
            this.Listbox_HashCode.Text = "HashCode:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Numeric_CurrentCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Value";
            // 
            // Numeric_CurrentCount
            // 
            this.Numeric_CurrentCount.Location = new System.Drawing.Point(6, 19);
            this.Numeric_CurrentCount.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Numeric_CurrentCount.Name = "Numeric_CurrentCount";
            this.Numeric_CurrentCount.Size = new System.Drawing.Size(131, 20);
            this.Numeric_CurrentCount.TabIndex = 5;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(357, 110);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 7;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Button_Ok
            // 
            this.Button_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Ok.Location = new System.Drawing.Point(276, 110);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(75, 23);
            this.Button_Ok.TabIndex = 6;
            this.Button_Ok.Text = "OK";
            this.Button_Ok.UseVisualStyleBackColor = true;
            // 
            // Frm_ModifyObjectives
            // 
            this.AcceptButton = this.Button_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(444, 145);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Textbox_HashCode);
            this.Controls.Add(this.Listbox_HashCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ModifyObjectives";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Objective Value";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_CurrentCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.TextBox Textbox_HashCode;
        private System.Windows.Forms.Label Listbox_HashCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Ok;
        protected internal System.Windows.Forms.NumericUpDown Numeric_CurrentCount;
    }
}