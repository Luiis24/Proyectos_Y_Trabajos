using System.IO;
using WMPLib;
namespace AprendiendoIngles
{
	public static class Sonidos
	{
		public static void voz (string nombresonido)
		{
			WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
			wplayer.URL = Path.Combine(System.Windows.Forms.Application.StartupPath, nombresonido+".mp3");
			wplayer.controls.play();
		}
	}
}
