using System;
using System.Collections.Generic;
using System.Text;
using ICSharpCode.TextEditor.Document;
using System.Reflection;
using System.IO;
using System.Xml;

namespace Sql2Xlsx
{
    public class AppSyntaxModeProvider : ISyntaxModeFileProvider
	{
		List<SyntaxMode> syntaxModes = null;

		public ICollection<SyntaxMode> SyntaxModes
		{
			get
			{
				return syntaxModes;
			}
		}

		public AppSyntaxModeProvider()
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			Stream syntaxModeStream = assembly.GetManifestResourceStream("Sql2Xlsx.Resources.SyntaxModes.xml");
            if (syntaxModeStream != null)
            {
                syntaxModes = SyntaxMode.GetSyntaxModes(syntaxModeStream);
            }
            else
            {
                syntaxModes = new List<SyntaxMode>();
            }
        }

		public XmlTextReader GetSyntaxModeFile(SyntaxMode syntaxMode)
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			Stream stream = assembly.GetManifestResourceStream("Sql2Xlsx.Resources." + syntaxMode.FileName);
			return new XmlTextReader(stream);
		}

		public void UpdateSyntaxModeList()
		{
			// resources don't change during runtime
		}
	}
}
