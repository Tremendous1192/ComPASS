using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
	public partial class RowVector<T>
		where T : struct
	{

		/// <summary>
		/// コンストラクター。ゼロベクトルを生成する。
		/// </summary>
		/// <param name="dimension"></param>
		public RowVector(int dimension)
		{
			if (dimension < 1)
			{
				throw new FormatException("次元の指定が不適切です");
			}

			vector = new T[dimension];
			dimensionCount = dimension;
		}


		/// <summary>
		/// コンストラクター。1次元配列をベクトルの初期値とする。
		/// </summary>
		/// <param name="initialValue"></param>
		public RowVector(T[] initialValue)
		{
			vector = new T[initialValue.Length];
			for (int i = 0; i < initialValue.Length; i++)
			{
				vector[i] = initialValue[i];
			}
			dimensionCount = initialValue.Length;
		}

		/// <summary>
		/// コンストラクター。リストをベクトルの初期値とする。
		/// </summary>
		/// <param name="initialValue"></param>
		public RowVector(List<T> initialValue)
		{
			vector = new T[initialValue.Count];
			for (int i = 0; i < initialValue.Count; i++)
			{
				vector[i] = initialValue[i];
			}
			dimensionCount = initialValue.Count;

		}


	}
}
