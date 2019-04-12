using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Media;
using Microsoft.Win32;
using System.IO;

namespace PLS.Curling {
	public static class TimerUtil {
		public const int traceDetailsDefault = 0;
		public const int demoModeDefault = 0;
		public const int startTimingDelayDefault = 8000;
		public const int refrehPeriod = 100;
		public static string FormatTime(TimeSpan ts)
		{
			if (ts.TotalMilliseconds < 1) {
				return "00:00";
			}
			return string.Format("{0:d2}:{1:d2}", (int) ts.TotalMinutes, (int) ts.Seconds);
		}
		public static void TraceAndDebugMessage(string stMess, int detailsInfo)
		{
			try {
				if (TraceDetails >= detailsInfo) {
					if (stMess.Length > 0) {
						Trace.TraceInformation("at: {0:d2}:{1:d2}:{2:d2}:{3:d3} -> {4}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, stMess);
					} else {
						Trace.TraceInformation(string.Empty);
					}
				}
			} catch { }
		}
		public static void PlaySound(Stream soundStream)
		{
			if (Curling.Properties.Settings.Default.Sound) {
				SoundPlayer play = new SoundPlayer();
				play.Stream = soundStream;
				play.Play();
			}
		}
		public static int TraceDetails
		{
			get
			{
				try {
					return (int)Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\PLS Inc.\Timer", "TraceDetails", traceDetailsDefault);
				} catch {
					return traceDetailsDefault;
				}
			}
		}
		public static bool DemoMode
		{
			get
			{
				try {
					return (int)Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\PLS Inc.\Timer", "DemoMode", TimerUtil.demoModeDefault) == 0 ? false : true;
				} catch {
					return false;
				}
			}
		}


	}
}
