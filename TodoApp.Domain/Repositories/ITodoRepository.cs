﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities;

namespace TodoApp.Domain.Repositories
{
    public interface ITodoRepository
    {
        void Create(Todo todo);
        void Update(Todo todo);
    }
}
