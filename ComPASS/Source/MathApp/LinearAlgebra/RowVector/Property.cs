using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
	public partial class RowVector<T>
		where T : struct
	{

		/// <summary>
		/// ベクトルの要素。
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public T this[int i]
		{
			set
			{
				if (i < 0 || dimensionCount <= i)
				{
					throw new FormatException("要素番号の指定が不適切です");
				}
				vector[i] = value;
			}
			get
			{
				if (i < 0 || dimensionCount <= i)
				{
					throw new FormatException("要素番号の指定が不適切です");
				}
				return vector[i];
			}
		}


		/// <summary>
		/// ベクトルの次元
		/// </summary>
		public int Dimension
		{
			get { return dimensionCount; }
		}



	}
}
