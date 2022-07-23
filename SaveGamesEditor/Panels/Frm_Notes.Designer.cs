
namespace SaveGamesEditor
{
    partial class Frm_Notes
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
            this.TabControl_Notes = new System.Windows.Forms.TabControl();
            this.TabPage_MummyNotes = new System.Windows.Forms.TabPage();
            this.TabPage_SphinxNotes = new System.Windows.Forms.TabPage();
            this.ListView_SphinxNotes = new SaveGamesEditor.UserControl_NotesEditor();
            this.ListView_MummyNotes = new SaveGamesEditor.UserControl_NotesEditor();
            this.TabControl_Notes.SuspendLayout();
            this.TabPage_MummyNotes.SuspendLayout();
            this.TabPage_SphinxNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Notes
            // 
            this.TabControl_Notes.Controls.Add(this.TabPage_MummyNotes);
            this.TabControl_Notes.Controls.Add(this.TabPage_SphinxNotes);
            this.TabControl_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Notes.Location = new System.Drawing.Point(0, 0);
            this.TabControl_Notes.Name = "TabControl_Notes";
            this.TabControl_Notes.SelectedIndex = 0;
            this.TabControl_Notes.Size = new System.Drawing.Size(493, 350);
            this.TabControl_Notes.TabIndex = 0;
            // 
            // TabPage_MummyNotes
            // 
            this.TabPage_MummyNotes.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_MummyNotes.Controls.Add(this.ListView_SphinxNotes);
            this.TabPage_MummyNotes.Location = new System.Drawing.Point(4, 22);
            this.TabPage_MummyNotes.Name = "TabPage_MummyNotes";
            this.TabPage_MummyNotes.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_MummyNotes.Size = new System.Drawing.Size(485, 324);
            this.TabPage_MummyNotes.TabIndex = 0;
            this.TabPage_MummyNotes.Text = "Sphinx";
            // 
            // TabPage_SphinxNotes
            // 
            this.TabPage_SphinxNotes.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_SphinxNotes.Controls.Add(this.ListView_MummyNotes);
            this.TabPage_SphinxNotes.Location = new System.Drawing.Point(4, 22);
            this.TabPage_SphinxNotes.Name = "TabPage_SphinxNotes";
            this.TabPage_SphinxNotes.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_SphinxNotes.Size = new System.Drawing.Size(485, 324);
            this.TabPage_SphinxNotes.TabIndex = 1;
            this.TabPage_SphinxNotes.Text = "Mummy";
            // 
            // ListView_SphinxNotes
            // 
            this.ListView_SphinxNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_SphinxNotes.Location = new System.Drawing.Point(3, 3);
            this.ListView_SphinxNotes.Name = "ListView_SphinxNotes";
            this.ListView_SphinxNotes.Size = new System.Drawing.Size(479, 318);
            this.ListView_SphinxNotes.TabIndex = 0;
            // 
            // ListView_MummyNotes
            // 
            this.ListView_MummyNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_MummyNotes.Location = new System.Drawing.Point(3, 3);
            this.ListView_MummyNotes.Name = "ListView_MummyNotes";
            this.ListView_MummyNotes.Size = new System.Drawing.Size(479, 318);
            this.ListView_MummyNotes.TabIndex = 1;
            // 
            // Frm_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 350);
            this.Controls.Add(this.TabControl_Notes);
            this.HideOnClose = true;
            this.Name = "Frm_Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "Notes";
            this.Text = "Notes";
            this.TabControl_Notes.ResumeLayout(false);
            this.TabPage_MummyNotes.ResumeLayout(false);
            this.TabPage_SphinxNotes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Notes;
        private System.Windows.Forms.TabPage TabPage_MummyNotes;
        private System.Windows.Forms.TabPage TabPage_SphinxNotes;
        private UserControl_NotesEditor ListView_SphinxNotes;
        private UserControl_NotesEditor ListView_MummyNotes;
    }
}