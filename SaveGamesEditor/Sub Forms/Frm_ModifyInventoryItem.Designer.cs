
namespace SaveGamesEditor
{
    partial class Frm_ModifyInventoryItem
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
            this.Button_Ok = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Listbox_HashCode = new System.Windows.Forms.Label();
            this.Textbox_HashCode = new System.Windows.Forms.TextBox();
            this.Numeric_CurrentCount = new System.Windows.Forms.NumericUpDown();
            this.Numeric_MaxCount = new System.Windows.Forms.NumericUpDown();
            this.Textbox_Flags = new System.Windows.Forms.TextBox();
            this.Label_CurrentCount = new System.Windows.Forms.Label();
            this.Label_MaxCount = new System.Windows.Forms.Label();
            this.Groupbox_Count = new System.Windows.Forms.GroupBox();
            this.GroupBox_Flags = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_CurrentCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxCount)).BeginInit();
            this.Groupbox_Count.SuspendLayout();
            this.GroupBox_Flags.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Ok
            // 
            this.Button_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Ok.Location = new System.Drawing.Point(196, 129);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(75, 23);
            this.Button_Ok.TabIndex = 4;
            this.Button_Ok.Text = "OK";
            this.Button_Ok.UseVisualStyleBackColor = true;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(277, 129);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 5;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Listbox_HashCode
            // 
            this.Listbox_HashCode.AutoSize = true;
            this.Listbox_HashCode.Location = new System.Drawing.Point(12, 15);
            this.Listbox_HashCode.Name = "Listbox_HashCode";
            this.Listbox_HashCode.Size = new System.Drawing.Size(60, 13);
            this.Listbox_HashCode.TabIndex = 0;
            this.Listbox_HashCode.Text = "HashCode:";
            // 
            // Textbox_HashCode
            // 
            this.Textbox_HashCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_HashCode.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_HashCode.Location = new System.Drawing.Point(78, 12);
            this.Textbox_HashCode.Name = "Textbox_HashCode";
            this.Textbox_HashCode.ReadOnly = true;
            this.Textbox_HashCode.Size = new System.Drawing.Size(274, 20);
            this.Textbox_HashCode.TabIndex = 1;
            // 
            // Numeric_CurrentCount
            // 
            this.Numeric_CurrentCount.Location = new System.Drawing.Point(53, 19);
            this.Numeric_CurrentCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Numeric_CurrentCount.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.Numeric_CurrentCount.Name = "Numeric_CurrentCount";
            this.Numeric_CurrentCount.Size = new System.Drawing.Size(131, 20);
            this.Numeric_CurrentCount.TabIndex = 4;
            // 
            // Numeric_MaxCount
            // 
            this.Numeric_MaxCount.Location = new System.Drawing.Point(53, 45);
            this.Numeric_MaxCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Numeric_MaxCount.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.Numeric_MaxCount.Name = "Numeric_MaxCount";
            this.Numeric_MaxCount.Size = new System.Drawing.Size(131, 20);
            this.Numeric_MaxCount.TabIndex = 5;
            // 
            // Textbox_Flags
            // 
            this.Textbox_Flags.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_Flags.Location = new System.Drawing.Point(6, 19);
            this.Textbox_Flags.Name = "Textbox_Flags";
            this.Textbox_Flags.ReadOnly = true;
            this.Textbox_Flags.Size = new System.Drawing.Size(132, 20);
            this.Textbox_Flags.TabIndex = 6;
            this.Textbox_Flags.Click += new System.EventHandler(this.Textbox_Flags_Click);
            // 
            // Label_CurrentCount
            // 
            this.Label_CurrentCount.AutoSize = true;
            this.Label_CurrentCount.Location = new System.Drawing.Point(6, 21);
            this.Label_CurrentCount.Name = "Label_CurrentCount";
            this.Label_CurrentCount.Size = new System.Drawing.Size(41, 13);
            this.Label_CurrentCount.TabIndex = 7;
            this.Label_CurrentCount.Text = "Current";
            // 
            // Label_MaxCount
            // 
            this.Label_MaxCount.AutoSize = true;
            this.Label_MaxCount.Location = new System.Drawing.Point(20, 47);
            this.Label_MaxCount.Name = "Label_MaxCount";
            this.Label_MaxCount.Size = new System.Drawing.Size(27, 13);
            this.Label_MaxCount.TabIndex = 8;
            this.Label_MaxCount.Text = "Max";
            // 
            // Groupbox_Count
            // 
            this.Groupbox_Count.Controls.Add(this.Numeric_CurrentCount);
            this.Groupbox_Count.Controls.Add(this.Numeric_MaxCount);
            this.Groupbox_Count.Controls.Add(this.Label_MaxCount);
            this.Groupbox_Count.Controls.Add(this.Label_CurrentCount);
            this.Groupbox_Count.Location = new System.Drawing.Point(12, 38);
            this.Groupbox_Count.Name = "Groupbox_Count";
            this.Groupbox_Count.Size = new System.Drawing.Size(190, 83);
            this.Groupbox_Count.TabIndex = 2;
            this.Groupbox_Count.TabStop = false;
            this.Groupbox_Count.Text = "Count:";
            // 
            // GroupBox_Flags
            // 
            this.GroupBox_Flags.Controls.Add(this.Textbox_Flags);
            this.GroupBox_Flags.Location = new System.Drawing.Point(208, 38);
            this.GroupBox_Flags.Name = "GroupBox_Flags";
            this.GroupBox_Flags.Size = new System.Drawing.Size(144, 83);
            this.GroupBox_Flags.TabIndex = 3;
            this.GroupBox_Flags.TabStop = false;
            this.GroupBox_Flags.Text = "Flags";
            // 
            // Frm_ModifyInventoryItem
            // 
            this.AcceptButton = this.Button_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(364, 164);
            this.Controls.Add(this.GroupBox_Flags);
            this.Controls.Add(this.Groupbox_Count);
            this.Controls.Add(this.Textbox_HashCode);
            this.Controls.Add(this.Listbox_HashCode);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ModifyInventoryItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Item Properties";
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_CurrentCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxCount)).EndInit();
            this.Groupbox_Count.ResumeLayout(false);
            this.Groupbox_Count.PerformLayout();
            this.GroupBox_Flags.ResumeLayout(false);
            this.GroupBox_Flags.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Ok;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Label Listbox_HashCode;
        private System.Windows.Forms.Label Label_CurrentCount;
        private System.Windows.Forms.Label Label_MaxCount;
        protected internal System.Windows.Forms.NumericUpDown Numeric_CurrentCount;
        protected internal System.Windows.Forms.NumericUpDown Numeric_MaxCount;
        protected internal System.Windows.Forms.TextBox Textbox_Flags;
        protected internal System.Windows.Forms.TextBox Textbox_HashCode;
        private System.Windows.Forms.GroupBox Groupbox_Count;
        private System.Windows.Forms.GroupBox GroupBox_Flags;
    }
}