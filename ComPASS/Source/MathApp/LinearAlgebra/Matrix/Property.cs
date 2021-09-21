using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{

	public partial class Matrix<T>
		where T : struct
	{

		/// <summary>
		/// 入出力のプロパティ
		/// </summary>
		/// <param name="i"></param>
		/// <param name="j"></param>
		/// <returns></returns>
		public T this[int i, int j]
		{
			set
			{
				if (i < 0 || j < 0 || rowCount <= i || columnCount <= j)
				{
					throw new FormatException("行数と列数の指定が不適切です");
				}
				matrix[i][j] = value;
			}
			get
			{
				if (i < 0 || j < 0 || rowCount <= i || columnCount <= j)
				{
					throw new FormatException("行数と列数の指定が不適切です");
				}
				return matrix[i][j];
			}
		}


		/// <summary>
		/// 行数
		/// </summary>
		public int RowCount
		{
			get { return rowCount; }
		}


		/// <summary>
		/// 列数
		/// </summary>
		public int ColumnCount
		{
			get { return columnCount; }
		}



	}
}