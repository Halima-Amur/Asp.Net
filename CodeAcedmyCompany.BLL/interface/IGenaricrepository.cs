﻿using CodeAcedmyCompany.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcedmyCompany.BLL.Interface
{
    public interface IGenaricrepository<T>
{
        IEnumerable<T> GetAll();
        T Get(int id);
        // 
        int Create(T item);
        int Update(T item);
        int Delete(T item);

    }
}
