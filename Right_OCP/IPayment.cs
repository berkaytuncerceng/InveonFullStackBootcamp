﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_OCP
{
	public interface IPayment
	{
		void ProcessPayment(decimal amount);
	}

}
