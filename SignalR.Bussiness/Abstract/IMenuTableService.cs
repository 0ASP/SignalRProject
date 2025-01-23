﻿using SignalR.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Bussiness.Abstract
{
	public interface IMenuTableService:IGenericService<MenuTable>
	{
		int TMenuTableCount();
	}
}
