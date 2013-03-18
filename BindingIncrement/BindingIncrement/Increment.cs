using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace BindingIncrement
{
	public class Increment
	{
		[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
		public static extern int AddFun(int a);
	}
}
