
namespace SaveGamesEditor.Custom_Controls
{
    partial class UserControl_HashCodesSelector
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
            this.ComboBox_HashCodeLabel = new System.Windows.Forms.ComboBox();
            this.TextBox_HashCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboBox_HashCodeLabel
            // 
            this.ComboBox_HashCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_HashCodeLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_HashCodeLabel.FormattingEnabled = true;
            this.ComboBox_HashCodeLabel.Location = new System.Drawing.Point(3, 3);
            this.ComboBox_HashCodeLabel.Name = "ComboBox_HashCodeLabel";
            this.ComboBox_HashCodeLabel.Size = new System.Drawing.Size(299, 21);
            this.ComboBox_HashCodeLabel.TabIndex = 0;
            this.ComboBox_HashCodeLabel.SelectedValueChanged += new System.EventHandler(this.ComboBox_HashCodeLabel_SelectedValueChanged);
            // 
            // TextBox_HashCode
            // 
            this.TextBox_HashCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_HashCode.Location = new System.Drawing.Point(308, 3);
            this.TextBox_HashCode.Name = "TextBox_HashCode";
            this.TextBox_HashCode.Size = new System.Drawing.Size(139, 20);
            this.TextBox_HashCode.TabIndex = 1;
            this.TextBox_HashCode.Validated += new System.EventHandler(this.TextBox_HashCode_Validated);
            // 
            // UserControl_HashCodesSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox_HashCode);
            this.Controls.Add(this.ComboBox_HashCodeLabel);
            this.Name = "UserControl_HashCodesSelector";
            this.Size = new System.Drawing.Size(450, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.ComboBox ComboBox_HashCodeLabel;
        protected internal System.Windows.Forms.TextBox TextBox_HashCode;
    }
}
