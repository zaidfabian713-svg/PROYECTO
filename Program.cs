using System;
using System.Windows.Forms;

namespace PROYECTO_SANGRE_Y_DOGMA
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			// Inicia el programa mostrando primero la portada (PantallaInicioForm)
			Application.Run(new PantallaInicioForm());
		}
	}
}
