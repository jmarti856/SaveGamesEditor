
namespace SaveGamesEditor
{
    partial class Frm_BehaviourFlags
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
            this.CheckListbox_Flags = new System.Windows.Forms.CheckedListBox();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckListbox_Flags
            // 
            this.CheckListbox_Flags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckListbox_Flags.CheckOnClick = true;
            this.CheckListbox_Flags.FormattingEnabled = true;
            this.CheckListbox_Flags.Items.AddRange(new object[] {
            "Ability",
            "PassiveAbility",
            "UseInFirstPerson",
            "UseInThirdPerson",
            "QuestItem",
            "PresentItem",
            "BeetleItem",
            "DartItem",
            "KeyItem",
            "UseUnderWater",
            "UseOutOfWater",
            "ProgrammableItem",
            "UniqueItem",
            "MiniGameItem",
            "SpecialItem",
            "ReleaseMonster",
            "Ka Item",
            "Possession Item",
            "RemoveWhenZero",
            "InfiniteAmount",
            "DontShowMaxAmount",
            "DontShowInBOS",
            "Flag # 23 Unused",
            "Flag # 24 Unused",
            "Flag # 25 Unused",
            "CatagoryFlag01  (1)",
            "CatagoryFlag02  (2)",
            "CatagoryFlag03  (4)",
            "CatagoryFlag04  (8)",
            "CatagoryFlag05  (16)",
            "CatagoryFlag06  (32)",
            "CatagoryFlag07  (64)"});
            this.CheckListbox_Flags.Location = new System.Drawing.Point(12, 12);
            this.CheckListbox_Flags.MultiColumn = true;
            this.CheckListbox_Flags.Name = "CheckListbox_Flags";
            this.CheckListbox_Flags.Size = new System.Drawing.Size(260, 244);
            this.CheckListbox_Flags.TabIndex = 0;
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_OK.Location = new System.Drawing.Point(116, 262);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 1;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(197, 262);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 2;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Frm_BehaviourFlags
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(284, 297);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.CheckListbox_Flags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BehaviourFlags";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Behaviour Flags";
            this.Load += new System.EventHandler(this.Frm_BehaviourFlags_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckListbox_Flags;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
    }
}