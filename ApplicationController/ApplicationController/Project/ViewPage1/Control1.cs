
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;



namespace Project.ViewPage1
{
	public partial class Control1 : AControl1
	{
		public Control1()
		{
			InitializeComponent();			
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Invoke_PressedForward();
		}
	}
}
