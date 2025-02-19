﻿using SignalR.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccess.Abstract
{
    public interface IBasketDal : IGenerikDal<Basket>
    {
        List<Basket> GetBasketByMenuTableNumber(int id);
    }
}
