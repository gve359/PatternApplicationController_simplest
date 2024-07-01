
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Project.ViewStart
{
	public partial class FormStart : AFormStart 
	{
		public FormStart()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{	
			this.Invoke_PressedContinue();
		}						
	}
}
