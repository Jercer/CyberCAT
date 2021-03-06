﻿namespace CyberCAT.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.compressionTabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.metaInformationFilePathTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recompressFilePathTextbox = new System.Windows.Forms.TextBox();
            this.recompressButton = new System.Windows.Forms.Button();
            this.decompressFilePathTextbox = new System.Windows.Forms.TextBox();
            this.uncompressButton = new System.Windows.Forms.Button();
            this.editorTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.saveButton = new System.Windows.Forms.Button();
            this.LoadSave = new System.Windows.Forms.Button();
            this.EditorTree = new System.Windows.Forms.TreeView();
            this.editorTreeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experimentalTabPage = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.loadAppearanceSectionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.appearanceUncompressedSaveFilePathTextbox = new System.Windows.Forms.TextBox();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.compressionTabPage.SuspendLayout();
            this.editorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.editorTreeContextMenu.SuspendLayout();
            this.experimentalTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.compressionTabPage);
            this.tabControl1.Controls.Add(this.editorTabPage);
            this.tabControl1.Controls.Add(this.experimentalTabPage);
            this.tabControl1.Controls.Add(this.settingsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // compressionTabPage
            // 
            this.compressionTabPage.Controls.Add(this.label3);
            this.compressionTabPage.Controls.Add(this.metaInformationFilePathTextbox);
            this.compressionTabPage.Controls.Add(this.label2);
            this.compressionTabPage.Controls.Add(this.label1);
            this.compressionTabPage.Controls.Add(this.recompressFilePathTextbox);
            this.compressionTabPage.Controls.Add(this.recompressButton);
            this.compressionTabPage.Controls.Add(this.decompressFilePathTextbox);
            this.compressionTabPage.Controls.Add(this.uncompressButton);
            this.compressionTabPage.Location = new System.Drawing.Point(4, 22);
            this.compressionTabPage.Name = "compressionTabPage";
            this.compressionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.compressionTabPage.Size = new System.Drawing.Size(749, 429);
            this.compressionTabPage.TabIndex = 0;
            this.compressionTabPage.Text = "Compression";
            this.compressionTabPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Metainfo File Path:";
            // 
            // metaInformationFilePathTextbox
            // 
            this.metaInformationFilePathTextbox.AllowDrop = true;
            this.metaInformationFilePathTextbox.Location = new System.Drawing.Point(6, 129);
            this.metaInformationFilePathTextbox.Name = "metaInformationFilePathTextbox";
            this.metaInformationFilePathTextbox.Size = new System.Drawing.Size(407, 20);
            this.metaInformationFilePathTextbox.TabIndex = 7;
            this.metaInformationFilePathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.metaInformationFilePathTextbox_DragDrop);
            this.metaInformationFilePathTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.metaInformationFilePathTextbox_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Decompressed File Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Save File Path:";
            // 
            // recompressFilePathTextbox
            // 
            this.recompressFilePathTextbox.AllowDrop = true;
            this.recompressFilePathTextbox.Location = new System.Drawing.Point(6, 90);
            this.recompressFilePathTextbox.Name = "recompressFilePathTextbox";
            this.recompressFilePathTextbox.Size = new System.Drawing.Size(407, 20);
            this.recompressFilePathTextbox.TabIndex = 4;
            this.recompressFilePathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.recompressFilePathTextbox_DragDrop);
            this.recompressFilePathTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.recompressFilePathTextbox_DragEnter);
            // 
            // recompressButton
            // 
            this.recompressButton.Location = new System.Drawing.Point(419, 129);
            this.recompressButton.Name = "recompressButton";
            this.recompressButton.Size = new System.Drawing.Size(75, 23);
            this.recompressButton.TabIndex = 3;
            this.recompressButton.Text = "Recompress";
            this.recompressButton.UseVisualStyleBackColor = true;
            this.recompressButton.Click += new System.EventHandler(this.recompressButton_Click);
            // 
            // decompressFilePathTextbox
            // 
            this.decompressFilePathTextbox.AllowDrop = true;
            this.decompressFilePathTextbox.Location = new System.Drawing.Point(6, 27);
            this.decompressFilePathTextbox.Name = "decompressFilePathTextbox";
            this.decompressFilePathTextbox.Size = new System.Drawing.Size(407, 20);
            this.decompressFilePathTextbox.TabIndex = 2;
            this.decompressFilePathTextbox.TextChanged += new System.EventHandler(this.decompressFilePathTextbox_TextChanged);
            this.decompressFilePathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.decompressFilePathTextbox_DragDrop);
            this.decompressFilePathTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.decompressFilePathTextbox_DragEnter);
            // 
            // uncompressButton
            // 
            this.uncompressButton.Location = new System.Drawing.Point(419, 25);
            this.uncompressButton.Name = "uncompressButton";
            this.uncompressButton.Size = new System.Drawing.Size(75, 23);
            this.uncompressButton.TabIndex = 0;
            this.uncompressButton.Text = "Decompress";
            this.uncompressButton.UseVisualStyleBackColor = true;
            this.uncompressButton.Click += new System.EventHandler(this.uncompressButton_Click);
            // 
            // editorTabPage
            // 
            this.editorTabPage.Controls.Add(this.splitContainer1);
            this.editorTabPage.Location = new System.Drawing.Point(4, 22);
            this.editorTabPage.Name = "editorTabPage";
            this.editorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.editorTabPage.Size = new System.Drawing.Size(749, 429);
            this.editorTabPage.TabIndex = 2;
            this.editorTabPage.Text = "Editor";
            this.editorTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(743, 423);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.saveButton);
            this.splitContainer2.Panel1.Controls.Add(this.LoadSave);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.EditorTree);
            this.splitContainer2.Size = new System.Drawing.Size(247, 423);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(84, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // LoadSave
            // 
            this.LoadSave.Location = new System.Drawing.Point(3, 3);
            this.LoadSave.Name = "LoadSave";
            this.LoadSave.Size = new System.Drawing.Size(75, 23);
            this.LoadSave.TabIndex = 0;
            this.LoadSave.Text = "Load";
            this.LoadSave.UseVisualStyleBackColor = true;
            this.LoadSave.Click += new System.EventHandler(this.EditorLoad_Click);
            // 
            // EditorTree
            // 
            this.EditorTree.ContextMenuStrip = this.editorTreeContextMenu;
            this.EditorTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorTree.Location = new System.Drawing.Point(0, 0);
            this.EditorTree.Name = "EditorTree";
            this.EditorTree.Size = new System.Drawing.Size(247, 394);
            this.EditorTree.TabIndex = 0;
            this.EditorTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.EditorTree_AfterSelect);
            // 
            // editorTreeContextMenu
            // 
            this.editorTreeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.editorTreeContextMenu.Name = "editorTreeContextMenu";
            this.editorTreeContextMenu.Size = new System.Drawing.Size(109, 26);
            this.editorTreeContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.editorTreeContextMenu_Opening);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // experimentalTabPage
            // 
            this.experimentalTabPage.Controls.Add(this.treeView1);
            this.experimentalTabPage.Controls.Add(this.label5);
            this.experimentalTabPage.Controls.Add(this.loadAppearanceSectionButton);
            this.experimentalTabPage.Controls.Add(this.label4);
            this.experimentalTabPage.Controls.Add(this.appearanceUncompressedSaveFilePathTextbox);
            this.experimentalTabPage.Location = new System.Drawing.Point(4, 22);
            this.experimentalTabPage.Name = "experimentalTabPage";
            this.experimentalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.experimentalTabPage.Size = new System.Drawing.Size(749, 429);
            this.experimentalTabPage.TabIndex = 1;
            this.experimentalTabPage.Text = "Experimental";
            this.experimentalTabPage.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(9, 85);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(432, 309);
            this.treeView1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Experimental Section to Convert Save to JSON";
            // 
            // loadAppearanceSectionButton
            // 
            this.loadAppearanceSectionButton.Location = new System.Drawing.Point(447, 58);
            this.loadAppearanceSectionButton.Name = "loadAppearanceSectionButton";
            this.loadAppearanceSectionButton.Size = new System.Drawing.Size(75, 23);
            this.loadAppearanceSectionButton.TabIndex = 2;
            this.loadAppearanceSectionButton.Text = "Load";
            this.loadAppearanceSectionButton.UseVisualStyleBackColor = true;
            this.loadAppearanceSectionButton.Click += new System.EventHandler(this.loadAppearanceSectionButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Compressed SaveFilePath";
            // 
            // appearanceUncompressedSaveFilePathTextbox
            // 
            this.appearanceUncompressedSaveFilePathTextbox.AllowDrop = true;
            this.appearanceUncompressedSaveFilePathTextbox.Location = new System.Drawing.Point(6, 58);
            this.appearanceUncompressedSaveFilePathTextbox.Name = "appearanceUncompressedSaveFilePathTextbox";
            this.appearanceUncompressedSaveFilePathTextbox.Size = new System.Drawing.Size(435, 20);
            this.appearanceUncompressedSaveFilePathTextbox.TabIndex = 0;
            this.appearanceUncompressedSaveFilePathTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.appearanceUncompressedSaveFilePathTextbox_DragDrop);
            this.appearanceUncompressedSaveFilePathTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.appearanceUncompressedSaveFilePathTextbox_DragEnter);
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.dataGridView1);
            this.settingsTabPage.Controls.Add(this.label6);
            this.settingsTabPage.Controls.Add(this.saveSettingsButton);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(749, 429);
            this.settingsTabPage.TabIndex = 3;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Enabled Parsers:";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(666, 398);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButton.TabIndex = 1;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(252, 395);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 455);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CyberCAT";
            this.tabControl1.ResumeLayout(false);
            this.compressionTabPage.ResumeLayout(false);
            this.compressionTabPage.PerformLayout();
            this.editorTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.editorTreeContextMenu.ResumeLayout(false);
            this.experimentalTabPage.ResumeLayout(false);
            this.experimentalTabPage.PerformLayout();
            this.settingsTabPage.ResumeLayout(false);
            this.settingsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage compressionTabPage;
        private System.Windows.Forms.TabPage experimentalTabPage;
        private System.Windows.Forms.Button uncompressButton;
        private System.Windows.Forms.TextBox decompressFilePathTextbox;
        private System.Windows.Forms.Button recompressButton;
        private System.Windows.Forms.TextBox recompressFilePathTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox metaInformationFilePathTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox appearanceUncompressedSaveFilePathTextbox;
        private System.Windows.Forms.Button loadAppearanceSectionButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage editorTabPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button LoadSave;
        private System.Windows.Forms.TreeView EditorTree;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ContextMenuStrip editorTreeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

