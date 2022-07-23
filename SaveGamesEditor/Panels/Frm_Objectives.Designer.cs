
namespace SaveGamesEditor
{
    partial class Frm_Objectives
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
            this.ContextMenuMain = new System.Windows.Forms.ContextMenu();
            this.MenuItem_CopyLabel = new System.Windows.Forms.MenuItem();
            this.MenuItem_CopyHashCode = new System.Windows.Forms.MenuItem();
            this.MenuItem_CopyValue = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem_EditValue = new System.Windows.Forms.MenuItem();
            this.ListView_Objectives = new SaveGamesEditor.ListView_ColumnSortingClick();
            this.Col_Label = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_HashCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_HashCodeValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ContextMenuMain
            // 
            this.ContextMenuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_CopyLabel,
            this.MenuItem_CopyHashCode,
            this.MenuItem_CopyValue,
            this.menuItem1,
            this.MenuItem_EditValue});
            // 
            // MenuItem_CopyLabel
            // 
            this.MenuItem_CopyLabel.Index = 0;
            this.MenuItem_CopyLabel.Text = "Copy Label";
            this.MenuItem_CopyLabel.Click += new System.EventHandler(this.MenuItem_CopyLabel_Click);
            // 
            // MenuItem_CopyHashCode
            // 
            this.MenuItem_CopyHashCode.Index = 1;
            this.MenuItem_CopyHashCode.Text = "Copy HashCode";
            this.MenuItem_CopyHashCode.Click += new System.EventHandler(this.MenuItem_CopyHashCode_Click);
            // 
            // MenuItem_CopyValue
            // 
            this.MenuItem_CopyValue.Index = 2;
            this.MenuItem_CopyValue.Text = "Copy Value";
            this.MenuItem_CopyValue.Click += new System.EventHandler(this.MenuItem_CopyValue_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 3;
            this.menuItem1.Text = "-";
            // 
            // MenuItem_EditValue
            // 
            this.MenuItem_EditValue.Index = 4;
            this.MenuItem_EditValue.Text = "Edit Value";
            this.MenuItem_EditValue.Click += new System.EventHandler(this.MenuItem_EditValue_Click);
            // 
            // ListView_Objectives
            // 
            this.ListView_Objectives.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Label,
            this.Col_HashCode,
            this.Col_HashCodeValue});
            this.ListView_Objectives.ContextMenu = this.ContextMenuMain;
            this.ListView_Objectives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_Objectives.FullRowSelect = true;
            this.ListView_Objectives.GridLines = true;
            this.ListView_Objectives.HideSelection = false;
            this.ListView_Objectives.Location = new System.Drawing.Point(0, 0);
            this.ListView_Objectives.Name = "ListView_Objectives";
            this.ListView_Objectives.Size = new System.Drawing.Size(426, 465);
            this.ListView_Objectives.TabIndex = 0;
            this.ListView_Objectives.UseCompatibleStateImageBehavior = false;
            this.ListView_Objectives.View = System.Windows.Forms.View.Details;
            this.ListView_Objectives.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Objectives_MouseDoubleClick);
            // 
            // Col_Label
            // 
            this.Col_Label.Text = "Label";
            this.Col_Label.Width = 350;
            // 
            // Col_HashCode
            // 
            this.Col_HashCode.Text = "HashCode";
            this.Col_HashCode.Width = 100;
            // 
            // Col_HashCodeValue
            // 
            this.Col_HashCodeValue.Text = "Value";
            // 
            // Frm_Objectives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 465);
            this.Controls.Add(this.ListView_Objectives);
            this.HideOnClose = true;
            this.Name = "Frm_Objectives";
            this.TabText = "Objectives Array";
            this.Text = "Objectives Array";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView_ColumnSortingClick ListView_Objectives;
        private System.Windows.Forms.ColumnHeader Col_HashCode;
        private System.Windows.Forms.ColumnHeader Col_HashCodeValue;
        private System.Windows.Forms.ContextMenu ContextMenuMain;
        private System.Windows.Forms.MenuItem MenuItem_CopyHashCode;
        private System.Windows.Forms.MenuItem MenuItem_CopyValue;
        private System.Windows.Forms.MenuItem MenuItem_EditValue;
        private System.Windows.Forms.ColumnHeader Col_Label;
        private System.Windows.Forms.MenuItem MenuItem_CopyLabel;
        private System.Windows.Forms.MenuItem menuItem1;
    }
}