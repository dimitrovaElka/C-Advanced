﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public interface IDatabase
    {
        void Add(int element);
        int Remove();
    }
}
