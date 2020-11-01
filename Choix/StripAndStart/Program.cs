using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StripAndStart
{
	class Program
	{
		static void Main(string[] args)
		{
			RemoveSamples(args[0]);
			Process.Start(@"C:\Program Files\Newsbin\newsbinpro64.exe", $"\"{args[0]}\"");
		}
		static private void RemoveSamples(string filename)
		{
			MemoryStream memStream = new MemoryStream(100);
			using (StreamReader sr = File.OpenText(filename))
			{
				String s = "";
				while ((s = sr.ReadLine()) != null)
				{
					if (!s.StartsWith("<!DOCTYPE "))
					{
						byte[] bLine = Encoding.UTF8.GetBytes(s);
						memStream.Write(bLine, 0, bLine.Length);
					}
				}
			}
			memStream.Seek(0, SeekOrigin.Begin);
			XmlDocument doc = new XmlDocument();
			doc.Load(memStream);
			XmlNode files = doc.ChildNodes[1];
			List<XmlNode> nodesToRemove = new List<XmlNode>();
			foreach (XmlNode file in files)
			{
				string s = file.OuterXml;
				if (file.NodeType == XmlNodeType.Element && file.Name.Equals("file") && (file.Attributes[2].Value.Contains("sample") || file.Attributes[2].Value.Contains("Sample")))
				{
					nodesToRemove.Add(file);
				}

			}
			foreach (XmlNode nodeToRemove in nodesToRemove)
			{
				files.RemoveChild(nodeToRemove);
			}
			doc.Save(filename);
		}
	}
}
