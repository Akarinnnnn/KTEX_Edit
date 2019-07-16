using System;
using System.Windows;
using System.Text;

namespace KTEX.KTEXConvert
{
	public static class Bootstrap
	{
		[STAThread]
		static int Main(string[] args)
		{
			MainWindow main = new MainWindow();
			App app = new App();
			return app.Run();
		}
	}
}
