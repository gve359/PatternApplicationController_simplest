using System;
using System.Windows.Forms;

namespace Project.ViewPage2
{
	public abstract class AControl2 : UserControl, IViewPage2
	{
		public event EventHandler PressedForward = delegate{};
		public event EventHandler PressedBack = delegate{};
				
		protected void Invoke_PressedForward()
		{
			this.PressedForward(this, new EventArgs());
		}
		protected void Invoke_PressedBack()
		{
			this.PressedBack(this, new EventArgs());
		}
	}
}
