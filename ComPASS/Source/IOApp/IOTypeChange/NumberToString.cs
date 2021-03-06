using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.IOApp
{
	public static partial class IOTypeChange
	{


		//数字型を文字列に変換する
		public static string ChangeString<T>(T input)
		where T : struct{
			return input.ToString().Replace(',','.');
		}


		//数字型の配列を文字列に変換する
		public static string[] ChangeString<T>(T[] input)
		where T : struct{
			string[]  converted=new string[ input.GetLength(0)];
			for(int i=0;i<converted.GetLength(0);i++){
				converted[i]=input[i].ToString().Replace(',','.');
 			}
			return converted;
		}

		//数字型の配列を文字列に変換する
		public static string[,] ChangeString<T>(T[,] input)
		where T : struct{
			string[,]  converted=new string[input.GetLength(0),input.GetLength(1)];
			for(int i=0;i<converted.GetLength(0);i++){
				for(int j=0;j<converted.GetLength(1);j++){
					converted[i,j]=input[i,j].ToString().Replace(',','.');
				}
 			}
			return converted;
		}


		//数字型の配列を文字列に変換する
		public static string[][] ChangeString<T>(T[][] input)
		where T : struct{
			string[][]  converted=new string[ input.GetLength(0)][];
			for(int i=0;i<converted.GetLength(0);i++){
				converted[i]=new string[converted[i].GetLength(0)];
				for(int j=0;j<converted[i].GetLength(0);j++){
					converted[i][j]=input[i][j].ToString().Replace(',','.');
				}
 			}
			return converted;
		}


		//数字型のリストを文字列に変換する
		public static List<string> ChangeString<T>(List<T> input)
		where T : struct{
			List<string> converted= new List<string>();
			for(int i=0;i<converted.Count;i++){
				converted.Add(input.ToString().Replace(',','.'));
			}
			return converted;
		}



	}
}