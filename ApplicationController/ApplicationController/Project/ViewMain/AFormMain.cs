
using System;
using System.Windows.Forms;

namespace Project.ViewMain
{
	public abstract class AFormMain : Form // AFormMain не наследует, потомучто как от "страницы", от этой формы ничего не требуется
	{
		public void SetContent(UserControl content)
		{
			this.Controls.Clear();						
			this.Controls.Add(content);			
		}
	}
}
