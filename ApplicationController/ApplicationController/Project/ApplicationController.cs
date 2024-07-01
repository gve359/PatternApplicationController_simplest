
using System;
using System.Windows.Forms;

using Project.ViewMain;
using Project.ViewStart;
using Project.ViewPage1;
using Project.ViewPage2;
using Project.ViewPage3;



namespace Project
{
	public class ApplicationController : ApplicationContext
	{
		private AFormStart viewStart;
		private AFormMain viewMain;
		private AControl1 control1;
		private AControl2 control2;
		private AControl3 control3;
		
		
		private void SetLinks(AFormStart viewStart, AFormMain viewMain, AControl1 control1, AControl2 control2, AControl3 control3)
		{
			this.viewStart = viewStart;
			this.viewMain = viewMain;
			this.control1 = control1;
			this.control2 = control2;
			this.control3 = control3;				
		}
		
		private void SetNavigation()
		{
			viewStart.FormClosed += (object sender, FormClosedEventArgs e) => {
				Application.Exit();
			};
			viewStart.PressedContinue += (object sender, EventArgs e) => {
				viewMain.SetContent(control1);
				viewStart.Hide();
				viewMain.Show();
			};
			
			viewMain.FormClosed += (object sender, FormClosedEventArgs e) => {
				Application.Exit();
			};
						
			control1.PressedForward += (object sender, EventArgs e) => {
				viewMain.SetContent(control2);
			};
			
			control2.PressedForward += (object sender, EventArgs e) => {
				viewMain.SetContent(control3);
			};
			control2.PressedBack += (object sender, EventArgs e) => {
				viewMain.SetContent(control1);
			};
			
			control3.PressedBack += (object sender, EventArgs e) => {
				viewMain.SetContent(control2);
			};			
		}
		
		public ApplicationController(AFormStart viewStart, AFormMain viewMain, AControl1 control1, AControl2 control2, AControl3 control3)
		{
			this.SetLinks(viewStart, viewMain, control1, control2, control3);
			this.SetNavigation();
			this.Run();
		}
		
		private void Run()
		{	
			this.viewStart.Show();			
		}			
	}
}
