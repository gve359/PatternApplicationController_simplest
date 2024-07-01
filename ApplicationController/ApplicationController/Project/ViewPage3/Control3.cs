
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Project.ViewPage3
{
	public partial class Control3 : AControl3
	{
		public Control3()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Invoke_PressedBack();
		}
	}
}
