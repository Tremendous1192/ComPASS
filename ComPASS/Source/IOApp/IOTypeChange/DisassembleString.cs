using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.IOApp
{
	public static partial class IOTypeChange
	{

	

	//��������J���}(,)�ŕ�������
	public static string[] SplitStringIntoArrayByComma(string input){
			return input.Split(',');
	}


	//��������J���}(,)�ŕ�������
	public static string[][] SplitStringIntoArrayByComma(string[] input){
		string[][] splited=new string[input.GetLength(0)][];
		for(int i=0;i<input.GetLength(0);i++){
				splited[i] = input[i].Split(',');
		}
		return splited;
	}




	}
}