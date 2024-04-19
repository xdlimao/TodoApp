﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Entities;
    public class Todo : Entity
    {
        public Todo(string title, string user, DateTime date)
        {
            Title = title;
            Done = false;
            Date = date;
            User = user;
        }
        public string Title { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; }
        public void MarkAsDone()
        {
            Done = true;
        }
        public void MarkAsUndone()
        {
            Done = false;
        }
        public void UpdateTitle(string title)
        {
            Title = title;
        }
    }

