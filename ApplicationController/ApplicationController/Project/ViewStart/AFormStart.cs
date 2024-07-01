
using System;
using System.Windows.Forms;

namespace Project.ViewStart
{
	public abstract class AFormStart : Form, IViewStart
	{
		public event EventHandler PressedContinue = delegate{};
		
		protected void Invoke_PressedContinue()
		{
			this.PressedContinue(this, new EventArgs());
		}
	}
}
