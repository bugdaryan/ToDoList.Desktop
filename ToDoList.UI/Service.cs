﻿using System.Collections.Generic;
using ToDoList.Data;
using ToDoList.Data.Models;

namespace ToDoList.UI
{
    public class Service
    {
        private readonly IToDoList _toDoListService;

        public Service(IToDoList toDoListService)
        {
            _toDoListService = toDoListService;
        }

        public IList<ToDoItem> GetAll()
        {
            return _toDoListService.GetAll();
        }

        public void PostItem(ToDoItem item)
        {
            _toDoListService.PostItem(item);
        }

        public void ModifyItem(ToDoItem item)
        {
            _toDoListService.ModifyItem(item);
        }

        public void RemoveItem(int id)
        {
            _toDoListService.RemoveItem(id);
        }

        public void RemoveCompletedItems()
        {
            _toDoListService.RemoveCompletedItems();
        }

        public void RemoveAllItems()
        {
            _toDoListService.RemoveAllItems();
        }

        public void ChangeItemCompletetion(int id, bool completed)
        {
            _toDoListService.ChangeItemCompletetion(id, completed);
        }
    }
}
