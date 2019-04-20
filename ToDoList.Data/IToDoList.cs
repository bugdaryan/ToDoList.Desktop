﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Data.Models;

namespace ToDoList.Data
{
    public interface IToDoList
    {
        IEnumerable<ToDoItem> GetAll();
        void PostItem();
        void RemoveItem(int id);
        void ChangeItemCompletetion(int id, bool completed);
    }
}
