
using System;
using System.Windows.Forms;

namespace Project.ViewPage1
{
	public abstract class AControl1 : UserControl, IViewPage1
	{
		public event EventHandler PressedForward = delegate{};
		
		protected void Invoke_PressedForward()
		{
			this.PressedForward(this, new EventArgs());
		}
	}
}
