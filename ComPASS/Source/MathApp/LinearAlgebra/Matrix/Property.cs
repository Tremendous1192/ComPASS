using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{

	public partial class Matrix<T>
		where T : struct
	{

		/// <summary>
		/// ���o�͂̃v���p�e�B
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
					throw new FormatException("�s���Ɨ񐔂̎w�肪�s�K�؂ł�");
				}
				matrix[i][j] = value;
			}
			get
			{
				if (i < 0 || j < 0 || rowCount <= i || columnCount <= j)
				{
					throw new FormatException("�s���Ɨ񐔂̎w�肪�s�K�؂ł�");
				}
				return matrix[i][j];
			}
		}


		/// <summary>
		/// �s��
		/// </summary>
		public int RowCount
		{
			get { return rowCount; }
		}


		/// <summary>
		/// ��
		/// </summary>
		public int ColumnCount
		{
			get { return columnCount; }
		}



	}
}