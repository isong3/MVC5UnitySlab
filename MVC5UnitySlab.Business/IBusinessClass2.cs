﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5UnitySlab.Business
{
    public interface IBusinessClass2 : IDisposable
    {
        string Hello();

        string SayHello(string hello);
    }
}
