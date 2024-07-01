
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Project.ViewPage2
{
	public partial class Control2 : AControl2
	{
		public Control2()
		{
			InitializeComponent();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Invoke_PressedBack();
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Invoke_PressedForward();			
		}
	}
}
