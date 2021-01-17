
namespace GuidesLeagueofLegends
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbGuides = new System.Windows.Forms.ListBox();
            this.cbList = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHero = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGuides
            // 
            this.lbGuides.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGuides.FormattingEnabled = true;
            this.lbGuides.ItemHeight = 16;
            this.lbGuides.Location = new System.Drawing.Point(12, 56);
            this.lbGuides.Name = "lbGuides";
            this.lbGuides.Size = new System.Drawing.Size(160, 372);
            this.lbGuides.TabIndex = 0;
            // 
            // cbList
            // 
            this.cbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbList.FormattingEnabled = true;
            this.cbList.Location = new System.Drawing.Point(12, 29);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(160, 24);
            this.cbList.TabIndex = 1;
            this.cbList.SelectedIndexChanged += new System.EventHandler(this.cbList_SelectedIndexChanged);
            this.cbList.SelectionChangeCommitted += new System.EventHandler(this.cbList_SelectionChangeCommitted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add});
            this.ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.ToolStripMenuItem.Text = "Редактирование";
            // 
            // Add
            // 
            this.Add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHero,
            this.tsGuide});
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(126, 22);
            this.Add.Text = "Добавить";
            // 
            // tsHero
            // 
            this.tsHero.Name = "tsHero";
            this.tsHero.Size = new System.Drawing.Size(112, 22);
            this.tsHero.Text = "Героев";
            this.tsHero.Click += new System.EventHandler(this.tsHero_Click);
            // 
            // tsGuide
            // 
            this.tsGuide.Name = "tsGuide";
            this.tsGuide.Size = new System.Drawing.Size(112, 22);
            this.tsGuide.Text = "Гайд";
            this.tsGuide.Click += new System.EventHandler(this.tsGuide_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(178, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 399);
            this.textBox1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 433);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbList);
            this.Controls.Add(this.lbGuides);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Guides";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGuides;
        private System.Windows.Forms.ComboBox cbList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsHero;
        private System.Windows.Forms.ToolStripMenuItem tsGuide;
    }
}

