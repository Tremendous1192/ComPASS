using System;
using System.Collections.Generic;
using System.Text;

using System.Globalization;

namespace Tremendous1192.SelfEmployed.CoMPASS.IOApp
{
	public static partial class IOTypeChange
	{
        	//•¶š—ñ‚ğ”’lŒ^‚É•ÏŠ·‚·‚é
		public static void TryStringToNumber<T>(String input,ref T converted)
		where T : struct{
            		try{
				converted=(T)Convert.ChangeType(input, typeof(T),CultureInfo.InvariantCulture);
			}
			catch{
				converted= new T();
			}
		}


		//•¶š—ñ‚ğ”’lŒ^‚É•ÏŠ·‚·‚é
		public static void TryStringToNumber<T>(String[] input,ref T[] converted)
		where T : struct{
			converted=new T[input.GetLength(0)];
			for(int i=0;i<input.GetLength(0);i++){
				try{
					converted[i]=(T)Convert.ChangeType(input[i], typeof(T),CultureInfo.InvariantCulture);
				}
				catch{
					converted[i]= new T();
				}
			}
		}


        	//•¶š—ñ‚ğ”’lŒ^‚É•ÏŠ·‚·‚é
		public static void TryStringToNumber<T>(String[,] input,ref T[,] converted)
		where T : struct{
			converted=new T[input.GetLength(0),input.GetLength(1)];
			for(int i=0;i<input.GetLength(0);i++){
				for(int j=0;j<input.GetLength(1);j++){
					try{
						converted[i,j]=(T)Convert.ChangeType(input[i,j], typeof(T),CultureInfo.InvariantCulture);
					}
					catch{
						converted[i,j]= new T();
					}
				}
			}
		}


		//•¶š—ñ‚ğ”’lŒ^‚É•ÏŠ·‚·‚é
		public static void TryStringToNumber<T>(String[][] input,ref T[][] converted)
		where T : struct{
			converted=new T[input.GetLength(0)][];
			for(int i=0;i<input.GetLength(0);i++){
				converted[i]=new T[input[i].GetLength(0)];
				for(int j=0;j<input[i].GetLength(0);j++){
					try{
						converted[i][j]=(T)Convert.ChangeType(input[i][j], typeof(T),CultureInfo.InvariantCulture);
					}
					catch{
						converted[i][j]= new T();
					}
				}
			}
		}


        	//•¶š—ñ‚ğ”’lŒ^‚É•ÏŠ·‚·‚é
		public static void TryStringToNumber<T>(List<string> input,ref List<T> converted)
		where T : struct{
			converted=new List<T>();
			for(int i=0;i<input.Count;i++){
				try{
					converted.Add((T)Convert.ChangeType(input[i], typeof(T),CultureInfo.InvariantCulture));
				}
				catch{
					converted.Add(new T());
				}
			}
		}


	}
}