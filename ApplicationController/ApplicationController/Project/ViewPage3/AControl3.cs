
using System;
using System.Windows.Forms;

namespace Project.ViewPage3
{
	public abstract class AControl3 : UserControl, IViewPage3
	{
		public event EventHandler PressedBack = delegate{};
		
		protected void Invoke_PressedBack()
		{
			this.PressedBack(this, new EventArgs());
		}
	}
}
