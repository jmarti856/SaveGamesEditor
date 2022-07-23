
namespace SaveGamesEditor.Custom_Controls
{
    partial class UserControl_Inventory
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContextMenu_ListView = new System.Windows.Forms.ContextMenu();
            this.MenuItem_CopyLabel = new System.Windows.Forms.MenuItem();
            this.MenuItem_CopyHashCode = new System.Windows.Forms.MenuItem();
            this.MenuItem_EditValues = new System.Windows.Forms.MenuItem();
            this.ListView_Inventory = new SaveGamesEditor.ListView_ColumnSortingClick();
            this.Col_DartItemsLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_DartItems_HashCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_DartItems_CurrentCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_DartItems_MaxCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_DartItems_Flags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuItem_Divisor1 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // ContextMenu_ListView
            // 
            this.ContextMenu_ListView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_CopyLabel,
            this.MenuItem_CopyHashCode,
            this.MenuItem_Divisor1,
            this.MenuItem_EditValues});
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
            // MenuItem_EditValues
            // 
            this.MenuItem_EditValues.Index = 3;
            this.MenuItem_EditValues.Text = "Edit Values";
            this.MenuItem_EditValues.Click += new System.EventHandler(this.MenuItem_EditValues_Click);
            // 
            // ListView_Inventory
            // 
            this.ListView_Inventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_DartItemsLabel,
            this.Col_DartItems_HashCode,
            this.Col_DartItems_CurrentCount,
            this.Col_DartItems_MaxCount,
            this.Col_DartItems_Flags});
            this.ListView_Inventory.ContextMenu = this.ContextMenu_ListView;
            this.ListView_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_Inventory.FullRowSelect = true;
            this.ListView_Inventory.GridLines = true;
            this.ListView_Inventory.HideSelection = false;
            this.ListView_Inventory.Location = new System.Drawing.Point(0, 0);
            this.ListView_Inventory.Name = "ListView_Inventory";
            this.ListView_Inventory.Size = new System.Drawing.Size(493, 323);
            this.ListView_Inventory.TabIndex = 1;
            this.ListView_Inventory.UseCompatibleStateImageBehavior = false;
            this.ListView_Inventory.View = System.Windows.Forms.View.Details;
            this.ListView_Inventory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Inventory_MouseDoubleClick);
            // 
            // Col_DartItemsLabel
            // 
            this.Col_DartItemsLabel.Text = "Label";
            this.Col_DartItemsLabel.Width = 250;
            // 
            // Col_DartItems_HashCode
            // 
            this.Col_DartItems_HashCode.Text = "HashCode";
            this.Col_DartItems_HashCode.Width = 100;
            // 
            // Col_DartItems_CurrentCount
            // 
            this.Col_DartItems_CurrentCount.Text = "Current Count";
            this.Col_DartItems_CurrentCount.Width = 80;
            // 
            // Col_DartItems_MaxCount
            // 
            this.Col_DartItems_MaxCount.Text = "Max Count";
            this.Col_DartItems_MaxCount.Width = 80;
            // 
            // Col_DartItems_Flags
            // 
            this.Col_DartItems_Flags.Text = "Flags";
            this.Col_DartItems_Flags.Width = 80;
            // 
            // MenuItem_Divisor1
            // 
            this.MenuItem_Divisor1.Index = 2;
            this.MenuItem_Divisor1.Text = "-";
            // 
            // UserControl_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListView_Inventory);
            this.Name = "UserControl_Inventory";
            this.Size = new System.Drawing.Size(493, 323);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader Col_DartItemsLabel;
        private System.Windows.Forms.ColumnHeader Col_DartItems_HashCode;
        private System.Windows.Forms.ColumnHeader Col_DartItems_CurrentCount;
        private System.Windows.Forms.ColumnHeader Col_DartItems_MaxCount;
        private System.Windows.Forms.ColumnHeader Col_DartItems_Flags;
        private System.Windows.Forms.ContextMenu ContextMenu_ListView;
        private System.Windows.Forms.MenuItem MenuItem_CopyLabel;
        private System.Windows.Forms.MenuItem MenuItem_CopyHashCode;
        protected internal ListView_ColumnSortingClick ListView_Inventory;
        private System.Windows.Forms.MenuItem MenuItem_EditValues;
        private System.Windows.Forms.MenuItem MenuItem_Divisor1;
    }
}
