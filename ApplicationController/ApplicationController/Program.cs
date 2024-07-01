
using System;
using System.Windows.Forms;

using Project;
using Project.ViewMain;
using Project.ViewStart;
using Project.ViewPage1;
using Project.ViewPage2;
using Project.ViewPage3;


namespace Example_ApplicationController
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			AFormStart viewStart = new FormStart();
			AFormMain viewMain = new FormMain();
			AControl1 control1 = new Control1();
			AControl2 control2 = new Control2();
			AControl3 control3 = new Control3();
						
									
			ApplicationController appContext = new ApplicationController(viewStart, viewMain, control1, control2, control3);
			Application.Run(appContext);
		}
	}
}
