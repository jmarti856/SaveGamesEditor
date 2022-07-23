
namespace SaveGamesEditor
{
    partial class Frm_Main
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.MenuItem_File = new System.Windows.Forms.MenuItem();
            this.MenuItem_OpenFile = new System.Windows.Forms.MenuItem();
            this.MenuItem_SaveFile = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.MenuItem();
            this.MenuItem_Window = new System.Windows.Forms.MenuItem();
            this.MenuItem_ShowFormHeader = new System.Windows.Forms.MenuItem();
            this.MenuItem_ShowFormObjective = new System.Windows.Forms.MenuItem();
            this.MenuItem_ShowFormNotes = new System.Windows.Forms.MenuItem();
            this.MenuItem_Inventory = new System.Windows.Forms.MenuItem();
            this.MenuItem_Level = new System.Windows.Forms.MenuItem();
            this.MenuItem_ProgrammableItems = new System.Windows.Forms.MenuItem();
            this.MenuItem_Help = new System.Windows.Forms.MenuItem();
            this.MenuItem_About = new System.Windows.Forms.MenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.Location = new System.Drawing.Point(0, 0);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1008, 624);
            this.dockPanel.TabIndex = 0;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_File,
            this.MenuItem_Window,
            this.MenuItem_Help});
            // 
            // MenuItem_File
            // 
            this.MenuItem_File.Index = 0;
            this.MenuItem_File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_OpenFile,
            this.MenuItem_SaveFile,
            this.menuItem3,
            this.MenuItem_Exit});
            this.MenuItem_File.Text = "File";
            // 
            // MenuItem_OpenFile
            // 
            this.MenuItem_OpenFile.Index = 0;
            this.MenuItem_OpenFile.Text = "Open";
            this.MenuItem_OpenFile.Click += new System.EventHandler(this.MenuItem_OpenFile_Click);
            // 
            // MenuItem_SaveFile
            // 
            this.MenuItem_SaveFile.Index = 1;
            this.MenuItem_SaveFile.Text = "Save";
            this.MenuItem_SaveFile.Click += new System.EventHandler(this.MenuItem_SaveFile_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Index = 3;
            this.MenuItem_Exit.Text = "Exit";
            // 
            // MenuItem_Window
            // 
            this.MenuItem_Window.Index = 1;
            this.MenuItem_Window.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_ShowFormHeader,
            this.MenuItem_ShowFormObjective,
            this.MenuItem_ShowFormNotes,
            this.MenuItem_Inventory,
            this.MenuItem_Level,
            this.MenuItem_ProgrammableItems});
            this.MenuItem_Window.Text = "Window";
            this.MenuItem_Window.Popup += new System.EventHandler(this.MenuItem_Window_Popup);
            // 
            // MenuItem_ShowFormHeader
            // 
            this.MenuItem_ShowFormHeader.Checked = true;
            this.MenuItem_ShowFormHeader.Index = 0;
            this.MenuItem_ShowFormHeader.Text = "Header";
            this.MenuItem_ShowFormHeader.Click += new System.EventHandler(this.MenuItem_ShowFormHeader_Click);
            // 
            // MenuItem_ShowFormObjective
            // 
            this.MenuItem_ShowFormObjective.Checked = true;
            this.MenuItem_ShowFormObjective.Index = 1;
            this.MenuItem_ShowFormObjective.Text = "Objectives";
            this.MenuItem_ShowFormObjective.Click += new System.EventHandler(this.MenuItem_ShowFormObjective_Click);
            // 
            // MenuItem_ShowFormNotes
            // 
            this.MenuItem_ShowFormNotes.Checked = true;
            this.MenuItem_ShowFormNotes.Index = 2;
            this.MenuItem_ShowFormNotes.Text = "Notes";
            this.MenuItem_ShowFormNotes.Click += new System.EventHandler(this.MenuItem_ShowFormNotes_Click);
            // 
            // MenuItem_Inventory
            // 
            this.MenuItem_Inventory.Checked = true;
            this.MenuItem_Inventory.Index = 3;
            this.MenuItem_Inventory.Text = "Inventory";
            this.MenuItem_Inventory.Click += new System.EventHandler(this.MenuItem_Inventory_Click);
            // 
            // MenuItem_Level
            // 
            this.MenuItem_Level.Checked = true;
            this.MenuItem_Level.Index = 4;
            this.MenuItem_Level.Text = "Level";
            this.MenuItem_Level.Click += new System.EventHandler(this.MenuItem_Level_Click);
            // 
            // MenuItem_ProgrammableItems
            // 
            this.MenuItem_ProgrammableItems.Checked = true;
            this.MenuItem_ProgrammableItems.Index = 5;
            this.MenuItem_ProgrammableItems.Text = "Programmable Items";
            this.MenuItem_ProgrammableItems.Click += new System.EventHandler(this.MenuItem_ProgrammableItems_Click);
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.Index = 2;
            this.MenuItem_Help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_About});
            this.MenuItem_Help.Text = "Help";
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Index = 0;
            this.MenuItem_About.Text = "About";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 624);
            this.Controls.Add(this.dockPanel);
            this.Menu = this.mainMenu1;
            this.Name = "Frm_Main";
            this.Text = "Save Games Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Shown += new System.EventHandler(this.Frm_Main_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem MenuItem_File;
        private System.Windows.Forms.MenuItem MenuItem_OpenFile;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem MenuItem_Exit;
        private System.Windows.Forms.MenuItem MenuItem_Help;
        private System.Windows.Forms.MenuItem MenuItem_About;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuItem MenuItem_Window;
        private System.Windows.Forms.MenuItem MenuItem_ShowFormHeader;
        private System.Windows.Forms.MenuItem MenuItem_ShowFormObjective;
        private System.Windows.Forms.MenuItem MenuItem_ShowFormNotes;
        private System.Windows.Forms.MenuItem MenuItem_Inventory;
        private System.Windows.Forms.MenuItem MenuItem_SaveFile;
        private System.Windows.Forms.MenuItem MenuItem_Level;
        private System.Windows.Forms.MenuItem MenuItem_ProgrammableItems;
    }
}

