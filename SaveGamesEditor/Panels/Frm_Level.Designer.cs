
namespace SaveGamesEditor
{
    partial class Frm_Level
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
            this.GroupBox_HashCode = new System.Windows.Forms.GroupBox();
            this.UserControl_HashCodeSelector = new SaveGamesEditor.Custom_Controls.UserControl_HashCodesSelector();
            this.GroupBox_EntranceNumber = new System.Windows.Forms.GroupBox();
            this.Numeric_Entrance = new System.Windows.Forms.NumericUpDown();
            this.GroupBox_MapData = new System.Windows.Forms.GroupBox();
            this.GroupBox_RestartId = new System.Windows.Forms.GroupBox();
            this.Numeric_RestartID = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Numeric_Timer = new System.Windows.Forms.NumericUpDown();
            this.GroupBox_HashCode.SuspendLayout();
            this.GroupBox_EntranceNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Entrance)).BeginInit();
            this.GroupBox_MapData.SuspendLayout();
            this.GroupBox_RestartId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_RestartID)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Timer)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_HashCode
            // 
            this.GroupBox_HashCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_HashCode.Controls.Add(this.UserControl_HashCodeSelector);
            this.GroupBox_HashCode.Location = new System.Drawing.Point(6, 19);
            this.GroupBox_HashCode.Name = "GroupBox_HashCode";
            this.GroupBox_HashCode.Size = new System.Drawing.Size(389, 51);
            this.GroupBox_HashCode.TabIndex = 0;
            this.GroupBox_HashCode.TabStop = false;
            this.GroupBox_HashCode.Text = "HashCode";
            // 
            // UserControl_HashCodeSelector
            // 
            this.UserControl_HashCodeSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl_HashCodeSelector.Location = new System.Drawing.Point(3, 16);
            this.UserControl_HashCodeSelector.Name = "UserControl_HashCodeSelector";
            this.UserControl_HashCodeSelector.Size = new System.Drawing.Size(383, 32);
            this.UserControl_HashCodeSelector.TabIndex = 0;
            // 
            // GroupBox_EntranceNumber
            // 
            this.GroupBox_EntranceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_EntranceNumber.Controls.Add(this.Numeric_Entrance);
            this.GroupBox_EntranceNumber.Location = new System.Drawing.Point(6, 76);
            this.GroupBox_EntranceNumber.Name = "GroupBox_EntranceNumber";
            this.GroupBox_EntranceNumber.Size = new System.Drawing.Size(389, 49);
            this.GroupBox_EntranceNumber.TabIndex = 1;
            this.GroupBox_EntranceNumber.TabStop = false;
            this.GroupBox_EntranceNumber.Text = "Entrance Number";
            // 
            // Numeric_Entrance
            // 
            this.Numeric_Entrance.Location = new System.Drawing.Point(6, 19);
            this.Numeric_Entrance.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Numeric_Entrance.Name = "Numeric_Entrance";
            this.Numeric_Entrance.Size = new System.Drawing.Size(120, 20);
            this.Numeric_Entrance.TabIndex = 0;
            // 
            // GroupBox_MapData
            // 
            this.GroupBox_MapData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_MapData.Controls.Add(this.groupBox1);
            this.GroupBox_MapData.Controls.Add(this.GroupBox_RestartId);
            this.GroupBox_MapData.Controls.Add(this.GroupBox_HashCode);
            this.GroupBox_MapData.Controls.Add(this.GroupBox_EntranceNumber);
            this.GroupBox_MapData.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_MapData.Name = "GroupBox_MapData";
            this.GroupBox_MapData.Size = new System.Drawing.Size(401, 243);
            this.GroupBox_MapData.TabIndex = 2;
            this.GroupBox_MapData.TabStop = false;
            this.GroupBox_MapData.Text = "Current Map";
            // 
            // GroupBox_RestartId
            // 
            this.GroupBox_RestartId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_RestartId.Controls.Add(this.Numeric_RestartID);
            this.GroupBox_RestartId.Location = new System.Drawing.Point(6, 131);
            this.GroupBox_RestartId.Name = "GroupBox_RestartId";
            this.GroupBox_RestartId.Size = new System.Drawing.Size(389, 49);
            this.GroupBox_RestartId.TabIndex = 2;
            this.GroupBox_RestartId.TabStop = false;
            this.GroupBox_RestartId.Text = "Restart ID";
            // 
            // Numeric_RestartID
            // 
            this.Numeric_RestartID.Location = new System.Drawing.Point(6, 19);
            this.Numeric_RestartID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Numeric_RestartID.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.Numeric_RestartID.Name = "Numeric_RestartID";
            this.Numeric_RestartID.Size = new System.Drawing.Size(120, 20);
            this.Numeric_RestartID.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Numeric_Timer);
            this.groupBox1.Location = new System.Drawing.Point(6, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 49);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // Numeric_Timer
            // 
            this.Numeric_Timer.Location = new System.Drawing.Point(6, 19);
            this.Numeric_Timer.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.Numeric_Timer.Name = "Numeric_Timer";
            this.Numeric_Timer.Size = new System.Drawing.Size(120, 20);
            this.Numeric_Timer.TabIndex = 0;
            // 
            // Frm_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 267);
            this.Controls.Add(this.GroupBox_MapData);
            this.HideOnClose = true;
            this.Name = "Frm_Level";
            this.TabText = "Map HashCode";
            this.Text = "Map HashCode";
            this.GroupBox_HashCode.ResumeLayout(false);
            this.GroupBox_EntranceNumber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Entrance)).EndInit();
            this.GroupBox_MapData.ResumeLayout(false);
            this.GroupBox_RestartId.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_RestartID)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Timer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_HashCode;
        private System.Windows.Forms.GroupBox GroupBox_EntranceNumber;
        private System.Windows.Forms.NumericUpDown Numeric_Entrance;
        private Custom_Controls.UserControl_HashCodesSelector UserControl_HashCodeSelector;
        private System.Windows.Forms.GroupBox GroupBox_MapData;
        private System.Windows.Forms.GroupBox GroupBox_RestartId;
        private System.Windows.Forms.NumericUpDown Numeric_RestartID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Numeric_Timer;
    }
}