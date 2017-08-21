namespace PaintOVV.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnDefaultColor = new System.Windows.Forms.Button();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.btnFillShape = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.labelUndoHistory = new System.Windows.Forms.Label();
            this.labelRedoHistory = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOptions = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveLike = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.radioSolid = new System.Windows.Forms.RadioButton();
            this.radioDash = new System.Windows.Forms.RadioButton();
            this.radioDot = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRectSelection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listRedo = new System.Windows.Forms.ListBox();
            this.listUndo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.grpColor.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuOptions.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDefaultColor
            // 
            this.btnDefaultColor.BackColor = System.Drawing.Color.Black;
            this.btnDefaultColor.Location = new System.Drawing.Point(6, 21);
            this.btnDefaultColor.Name = "btnDefaultColor";
            this.btnDefaultColor.Size = new System.Drawing.Size(50, 30);
            this.btnDefaultColor.TabIndex = 9;
            this.btnDefaultColor.UseVisualStyleBackColor = false;
            this.btnDefaultColor.Click += new System.EventHandler(this.btnDefaultColor_Click);
            // 
            // numSize
            // 
            this.numSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSize.Location = new System.Drawing.Point(34, 19);
            this.numSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.ReadOnly = true;
            this.numSize.Size = new System.Drawing.Size(50, 23);
            this.numSize.TabIndex = 11;
            this.numSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.ValueChanged += new System.EventHandler(this.numSize_ValueChanged_1);
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.btnFillShape);
            this.grpColor.Controls.Add(this.btnDefaultColor);
            this.grpColor.Location = new System.Drawing.Point(532, 33);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(116, 80);
            this.grpColor.TabIndex = 13;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Цвет";
            // 
            // btnFillShape
            // 
            this.btnFillShape.BackColor = System.Drawing.Color.White;
            this.btnFillShape.Location = new System.Drawing.Point(62, 21);
            this.btnFillShape.Name = "btnFillShape";
            this.btnFillShape.Size = new System.Drawing.Size(50, 30);
            this.btnFillShape.TabIndex = 10;
            this.btnFillShape.UseVisualStyleBackColor = false;
            this.btnFillShape.Click += new System.EventHandler(this.btnFillShape_Click);
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numSize);
            this.groupBox3.Location = new System.Drawing.Point(264, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 80);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тип линии";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(4, 361);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(116, 54);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Move/Resize Mode";
            this.groupBox8.Visible = false;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(796, 41);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(102, 28);
            this.btnMove.TabIndex = 24;
            this.btnMove.Text = "OFF";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // labelUndoHistory
            // 
            this.labelUndoHistory.AutoSize = true;
            this.labelUndoHistory.Location = new System.Drawing.Point(9, 532);
            this.labelUndoHistory.Name = "labelUndoHistory";
            this.labelUndoHistory.Size = new System.Drawing.Size(66, 13);
            this.labelUndoHistory.TabIndex = 30;
            this.labelUndoHistory.Text = "Undo history";
            this.labelUndoHistory.Visible = false;
            // 
            // labelRedoHistory
            // 
            this.labelRedoHistory.AutoSize = true;
            this.labelRedoHistory.Location = new System.Drawing.Point(9, 662);
            this.labelRedoHistory.Name = "labelRedoHistory";
            this.labelRedoHistory.Size = new System.Drawing.Size(66, 13);
            this.labelRedoHistory.TabIndex = 31;
            this.labelRedoHistory.Text = "Redo history";
            this.labelRedoHistory.Visible = false;
            // 
            // btnRectangle
            // 
            this.btnRectangle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.Location = new System.Drawing.Point(66, 19);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(35, 35);
            this.btnRectangle.TabIndex = 3;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTriangle.FlatAppearance.BorderSize = 0;
            this.btnTriangle.Image = ((System.Drawing.Image)(resources.GetObject("btnTriangle.Image")));
            this.btnTriangle.Location = new System.Drawing.Point(107, 19);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(35, 35);
            this.btnTriangle.TabIndex = 11;
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(148, 19);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(35, 35);
            this.btnLine.TabIndex = 14;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEllipse.FlatAppearance.BorderSize = 0;
            this.btnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipse.Image")));
            this.btnEllipse.Location = new System.Drawing.Point(16, 19);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(35, 35);
            this.btnEllipse.TabIndex = 1;
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPolygon.FlatAppearance.BorderSize = 0;
            this.btnPolygon.Image = ((System.Drawing.Image)(resources.GetObject("btnPolygon.Image")));
            this.btnPolygon.Location = new System.Drawing.Point(190, 19);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(35, 35);
            this.btnPolygon.TabIndex = 15;
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPolygon);
            this.groupBox1.Controls.Add(this.btnEllipse);
            this.groupBox1.Controls.Add(this.btnLine);
            this.groupBox1.Controls.Add(this.btnTriangle);
            this.groupBox1.Controls.Add(this.btnRectangle);
            this.groupBox1.Location = new System.Drawing.Point(4, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 80);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фигуры";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 89);
            this.menuStrip1.TabIndex = 37;
            // 
            // menuOptions
            // 
            this.menuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.editToolStripMenuItem,
            this.menuClear});
            this.menuOptions.Location = new System.Drawing.Point(0, 0);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(1171, 24);
            this.menuOptions.TabIndex = 33;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSave,
            this.menuSaveLike});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(234, 22);
            this.menuNew.Text = "Новый файл";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(234, 22);
            this.menuOpen.Text = "Открыть";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(234, 22);
            this.menuSave.Text = "Сохранить";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveLike
            // 
            this.menuSaveLike.Name = "menuSaveLike";
            this.menuSaveLike.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuSaveLike.Size = new System.Drawing.Size(234, 22);
            this.menuSaveLike.Text = "Сохранить как...";
            this.menuSaveLike.Click += new System.EventHandler(this.menuSaveLike_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUndo,
            this.menuRedo,
            this.menuCopy,
            this.menuCut});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.editToolStripMenuItem.Text = "Редактирование";
            // 
            // menuUndo
            // 
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuUndo.Size = new System.Drawing.Size(181, 22);
            this.menuUndo.Text = "Вперед";
            this.menuUndo.Click += new System.EventHandler(this.menuUndo_Click_1);
            // 
            // menuRedo
            // 
            this.menuRedo.Name = "menuRedo";
            this.menuRedo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.menuRedo.Size = new System.Drawing.Size(181, 22);
            this.menuRedo.Text = "Назад";
            this.menuRedo.Click += new System.EventHandler(this.menuRedo_Click_1);
            // 
            // menuCopy
            // 
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCopy.Size = new System.Drawing.Size(181, 22);
            this.menuCopy.Text = "Копировать";
            this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
            // 
            // menuCut
            // 
            this.menuCut.Name = "menuCut";
            this.menuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuCut.Size = new System.Drawing.Size(181, 22);
            this.menuCut.Text = "Вырезать";
            this.menuCut.Click += new System.EventHandler(this.menuCut_Click);
            // 
            // menuClear
            // 
            this.menuClear.Name = "menuClear";
            this.menuClear.Size = new System.Drawing.Size(71, 20);
            this.menuClear.Text = "Очистить";
            this.menuClear.Click += new System.EventHandler(this.menuClear_Click);
            // 
            // radioSolid
            // 
            this.radioSolid.AutoSize = true;
            this.radioSolid.Checked = true;
            this.radioSolid.Location = new System.Drawing.Point(34, 19);
            this.radioSolid.Name = "radioSolid";
            this.radioSolid.Size = new System.Drawing.Size(48, 17);
            this.radioSolid.TabIndex = 0;
            this.radioSolid.TabStop = true;
            this.radioSolid.Text = "Solid";
            this.radioSolid.UseVisualStyleBackColor = true;
            this.radioSolid.CheckedChanged += new System.EventHandler(this.radioSolid_CheckedChanged);
            // 
            // radioDash
            // 
            this.radioDash.AutoSize = true;
            this.radioDash.Location = new System.Drawing.Point(34, 38);
            this.radioDash.Name = "radioDash";
            this.radioDash.Size = new System.Drawing.Size(50, 17);
            this.radioDash.TabIndex = 1;
            this.radioDash.Text = "Dash";
            this.radioDash.UseVisualStyleBackColor = true;
            // 
            // radioDot
            // 
            this.radioDot.AutoSize = true;
            this.radioDot.Location = new System.Drawing.Point(34, 58);
            this.radioDot.Name = "radioDot";
            this.radioDot.Size = new System.Drawing.Size(42, 17);
            this.radioDot.TabIndex = 2;
            this.radioDot.Text = "Dot";
            this.radioDot.UseVisualStyleBackColor = true;
            this.radioDot.CheckedChanged += new System.EventHandler(this.radioDot_CheckedChanged_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioDot);
            this.groupBox5.Controls.Add(this.radioDash);
            this.groupBox5.Controls.Add(this.radioSolid);
            this.groupBox5.Location = new System.Drawing.Point(396, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(116, 80);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Тип линии";
            // 
            // btnRectSelection
            // 
            this.btnRectSelection.Location = new System.Drawing.Point(654, 41);
            this.btnRectSelection.Name = "btnRectSelection";
            this.btnRectSelection.Size = new System.Drawing.Size(102, 28);
            this.btnRectSelection.TabIndex = 38;
            this.btnRectSelection.Text = "Выключить выделение";
            this.btnRectSelection.UseVisualStyleBackColor = true;
            this.btnRectSelection.Click += new System.EventHandler(this.btnRectSelection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1077, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Redo Список";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(953, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Undo Список";
            // 
            // listRedo
            // 
            this.listRedo.FormatString = "N0";
            this.listRedo.FormattingEnabled = true;
            this.listRedo.Location = new System.Drawing.Point(1064, 26);
            this.listRedo.Name = "listRedo";
            this.listRedo.Size = new System.Drawing.Size(107, 82);
            this.listRedo.TabIndex = 44;
            // 
            // listUndo
            // 
            this.listUndo.FormatString = "N0";
            this.listUndo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listUndo.Location = new System.Drawing.Point(934, 24);
            this.listUndo.Name = "listUndo";
            this.listUndo.Size = new System.Drawing.Size(106, 82);
            this.listUndo.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Выделение";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(750, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Перемещение/Масштабирование";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 733);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listRedo);
            this.Controls.Add(this.listUndo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnRectSelection);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuOptions);
            this.Controls.Add(this.labelRedoHistory);
            this.Controls.Add(this.labelUndoHistory);
            this.Controls.Add(this.groupBox8);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Графический редактор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPaint_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.grpColor.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuOptions.ResumeLayout(false);
            this.menuOptions.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDefaultColor;
        public System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnFillShape;
        private System.Windows.Forms.Label labelUndoHistory;
        private System.Windows.Forms.Label labelRedoHistory;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveLike;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUndo;
        private System.Windows.Forms.ToolStripMenuItem menuRedo;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuClear;
        public System.Windows.Forms.RadioButton radioSolid;
        public System.Windows.Forms.RadioButton radioDash;
        public System.Windows.Forms.RadioButton radioDot;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRectSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listRedo;
        private System.Windows.Forms.ListBox listUndo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

