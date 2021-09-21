using System;
using System.Collections.Generic;
using System.Text;

namespace Tremendous1192.SelfEmployed.CoMPASS.MathApp
{

	public partial class Matrix<T>
		where T : struct
	{

		/// <summary>
		/// �R���X�g���N�^�[�B��s��𐶐�����B
		/// </summary>
		/// <param name="row"></param>
		/// <param name="column"></param>
		public Matrix(int row, int column)
		{

			if (row < 0 || column < 0)
			{
				throw new FormatException("�s���Ɨ񐔂̎w�肪�s�K�؂ł�");
			}

			matrix = new T[row][];
			for (int i = 0; i < row; i++)
			{
				matrix[i] = new T[column];
			}
			rowCount = row;
			columnCount = column;
		}

		/// <summary>
		/// �R���X�g���N�^�[�B1�����z���2�����z��ɕϊ����āA�s��𐶐�����B
		/// </summary>
		/// <param name="row"></param>
		/// <param name="column"></param>
		/// <param name="initialValue"></param>
		public Matrix(int row, int column, T[] initialValue)
		{
			if (row < 0 || column < 0 || row * column != initialValue.Length)
			{
				throw new FormatException("�s���Ɨ񐔂̎w�肪�s�K�؂ł�");
			}

			matrix = new T[row][];
			for (int i = 0; i < row; i++)
			{
				matrix[i] = new T[column];
				for (int j = 0; j < column; j++)
				{
					matrix[i][j] = initialValue[i * column + j];
				}
			}
			rowCount = row;
			columnCount = column;
		}

		/// <summary>
		/// �R���X�g���N�^�[�B�񎟌��z��������l�Ƃ��čs��𐶐�����B
		/// </summary>
		/// <param name="initialValue"></param>
		public Matrix(T[,] initialValue)
		{
			matrix = new T[initialValue.GetLength(0)][];
			for (int i = 0; i < initialValue.GetLength(0); i++)
			{
				matrix[i] = new T[initialValue.GetLength(1)];
				for (int j = 0; j < initialValue.GetLength(1); j++)
				{
					matrix[i][j] = initialValue[i, j];
				}
			}
			rowCount = initialValue.GetLength(0);
			columnCount = initialValue.GetLength(1);
		}

		/// <summary>
		/// �R���X�g���N�^�[�B�W���O�z��������l�Ƃ��āA�s��𐶐�����B
		/// �s��̗񐔂́A�e�z��̗v�f���̒����̍ő�l�Ƃ���B
		/// </summary>
		/// <param name="initialValue"></param>
		public Matrix(T[][] initialValue)
		{
			int maxColumn = 1;
			for (int i = 0; i < initialValue.GetLength(0); i++)
			{
				maxColumn = Math.Max(maxColumn, initialValue[i].GetLength(0));
			}

			matrix = new T[initialValue.GetLength(0)][];
			for (int i = 0; i < initialValue.GetLength(0); i++)
			{
				matrix[i] = new T[maxColumn];
				for (int j = 0; j < initialValue[i].GetLength(0); j++)
				{
					matrix[i][j] = initialValue[i][j];
				}
			}
			rowCount = initialValue.GetLength(0);
			columnCount = maxColumn;
		}






	}




}