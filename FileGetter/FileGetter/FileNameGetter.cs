using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FileUtil;
//C:\Users\fujit\Downloads\news.txt
namespace FileNameGetter
{
	class FileNameGetter
	{
		[STAThread]
		static void Main()
		{
			var str = Clipboard.GetText();
			var strList = str.Split('\n');
			var newStrList = new List<String>();

			//---StringListをパースしてファイル名だけのリストをnewStrListに格納する
			for(int i = 0; i < strList.Length; i++)
			{
				var fileName = strList[i].GetFileName();
				fileName.WriteConsole();
				
				if(i != strList.Length-1)
					newStrList.Add(fileName+",");
				//---最後の要素には","を入れない
				else
					newStrList.Add(fileName);
			
			}
			
			//---newStrListを一つのstringに格納
			string setText="";
			foreach(var item in newStrList)
			{
				setText += item;
			}
			Clipboard.SetText(setText);
			Console.Read();
		}
	}
}

