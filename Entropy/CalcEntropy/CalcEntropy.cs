using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
[assembly: System.CLSCompliant(true)]
namespace IWS.Crypotography {
/// <summary>
/// General purpose tester class
/// </summary>
	public static class CalcEntropy {
		/// <summary>
		/// Calculates the presence of each of the byte values in a stream.
		/// </summary>
		/// <param name="inStream">The stream to calculate the probability from.</param>
		/// <returns> 
		/// 	A long array that contains the number of byte for example index 0 contains the
		/// 	number of byte that are value 0 in the stream.
		/// </returns>
		private static long[] CalcProb(Stream inStream)
		{
			long[] retVal = new long[0x100];
			for (int i = 0; i < 0x100; i++) {
				retVal[i] = 0;
			}
			long nbRead = 0;
			byte[] toTest = new byte[50000];
			do {
				nbRead = inStream.Read(toTest, 0, 50000);
				for (long i = 0; i < nbRead; i++) {
					retVal[toTest[i]]++;
				}
			} while (nbRead == 50000);
			return retVal;
		}
		private static long[] CalcProb(byte[] toTest)
		{
			long[] retVal = new long[0x100];
			for (int i = 0; i < 0x100; i++) {
				retVal[i] = 0;
			}
			for (long i = 0; i < toTest.Length; i++) {
				retVal[toTest[i]]++;
			}
			return retVal;
		}
		/// <summary>
		/// Calculates the entropy of a stream.
		/// </summary>
		/// <param name="inBuf">The stream to calculate the entropy from.</param>
		/// <returns>The entropy value</returns>
		public static double Entropy(Stream inBuf)
		{
			long[] prob = CalcProb(inBuf);
			double retVal = 0.0;
			for (int i = 0; i < prob.Length; i++) {
				if (prob[i] != 0) {
					double proba = (double)prob[i] / (double)inBuf.Length;
					retVal += proba * Math.Log(1.0 / proba, 2.0);
				}
			}
			return retVal;
		}
		/// <summary>
		/// Calculates the entropy of a stream.
		/// </summary>
		/// <param name="inBuf">The buffer to calculate the entropy from.</param>
		/// <returns>The entropy value</returns>
		public static double Entropy(byte[] inBuf)
		{
			long[] prob = CalcProb(inBuf);
			double retVal = 0.0;
			for (int i = 0; i < prob.Length; i++) {
				if (prob[i] != 0) {
					double proba = (double)prob[i] / (double)inBuf.Length;
					retVal += proba * Math.Log(1.0 / proba, 2.0);
				}
			}
			return retVal;
		}
	}
}
