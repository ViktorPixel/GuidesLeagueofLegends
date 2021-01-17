
namespace GuidesLeagueofLegends
{
    partial class AddGuideForm
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
            this.cbListHero = new System.Windows.Forms.ComboBox();
            this.tbNameGuide = new System.Windows.Forms.TextBox();
            this.tbDecription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbListHero
            // 
            this.cbListHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbListHero.FormattingEnabled = true;
            this.cbListHero.Location = new System.Drawing.Point(12, 23);
            this.cbListHero.Name = "cbListHero";
            this.cbListHero.Size = new System.Drawing.Size(132, 24);
            this.cbListHero.TabIndex = 0;
            // 
            // tbNameGuide
            // 
            this.tbNameGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameGuide.Location = new System.Drawing.Point(12, 88);
            this.tbNameGuide.Multiline = true;
            this.tbNameGuide.Name = "tbNameGuide";
            this.tbNameGuide.Size = new System.Drawing.Size(213, 38);
            this.tbNameGuide.TabIndex = 1;
            // 
            // tbDecription
            // 
            this.tbDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDecription.Location = new System.Drawing.Point(12, 163);
            this.tbDecription.Multiline = true;
            this.tbDecription.Name = "tbDecription";
            this.tbDecription.Size = new System.Drawing.Size(213, 80);
            this.tbDecription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название гайда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Описание";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(143, 272);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(82, 29);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // AddGuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 316);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDecription);
            this.Controls.Add(this.tbNameGuide);
            this.Controls.Add(this.cbListHero);
            this.Name = "AddGuideForm";
            this.Text = "AddGuideForm";
            this.Load += new System.EventHandler(this.AddGuideForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbListHero;
        private System.Windows.Forms.TextBox tbNameGuide;
        private System.Windows.Forms.TextBox tbDecription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSave;
    }
}