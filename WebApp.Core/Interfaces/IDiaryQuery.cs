﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApp.Core.Models;

namespace WebApp.Core.Interfaces
{
    public interface IDiaryQuery
    {
        Task<List<Diary>> GetDariesAsync(Diary diary);
        Task<Diary> GetDiaryAsync(Diary diary);
    }
}
