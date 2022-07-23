
namespace SaveGamesEditor
{
    partial class UserControl_NotesEditor
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
            this.ListView_Notes = new System.Windows.Forms.ListView();
            this.Col_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_TitleHashCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListView_Notes
            // 
            this.ListView_Notes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Title,
            this.Col_TitleHashCode,
            this.Col_Desc,
            this.columnHeader1});
            this.ListView_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_Notes.FullRowSelect = true;
            this.ListView_Notes.GridLines = true;
            this.ListView_Notes.HideSelection = false;
            this.ListView_Notes.Location = new System.Drawing.Point(0, 0);
            this.ListView_Notes.Name = "ListView_Notes";
            this.ListView_Notes.Size = new System.Drawing.Size(574, 377);
            this.ListView_Notes.TabIndex = 0;
            this.ListView_Notes.UseCompatibleStateImageBehavior = false;
            this.ListView_Notes.View = System.Windows.Forms.View.Details;
            // 
            // Col_Title
            // 
            this.Col_Title.Text = "Title";
            this.Col_Title.Width = 200;
            // 
            // Col_TitleHashCode
            // 
            this.Col_TitleHashCode.Text = "HashCode";
            this.Col_TitleHashCode.Width = 80;
            // 
            // Col_Desc
            // 
            this.Col_Desc.Text = "Desc";
            this.Col_Desc.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "HashCode";
            this.columnHeader1.Width = 80;
            // 
            // UserControl_NotesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListView_Notes);
            this.Name = "UserControl_NotesEditor";
            this.Size = new System.Drawing.Size(574, 377);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader Col_Title;
        private System.Windows.Forms.ColumnHeader Col_TitleHashCode;
        private System.Windows.Forms.ColumnHeader Col_Desc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        protected internal System.Windows.Forms.ListView ListView_Notes;
    }
}
