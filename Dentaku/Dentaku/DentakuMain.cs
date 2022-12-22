using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentaku
{
	enum EOperator
	{
		Add,
		Subtract,
		Multiply,
		Divide,
		Equal,
		Dot,
	}
	internal class DentakuMain
	{
		public static DentakuMain ins = new DentakuMain();

		private float frontNum;	// 表に出ている数字
		private float backNum;  // 裏で保持している数字
		private bool isFloat;	// 小数か？
		DentakuMain() { }
		
		public void PushNum(int num)
		{
			this.frontNum *= 10;
			this.frontNum += num;
		}

		public void PressOperator(EOperator op)
		{
			
		}

	}
}
