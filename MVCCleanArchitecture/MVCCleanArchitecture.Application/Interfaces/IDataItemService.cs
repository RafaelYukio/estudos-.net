﻿using MVCCleanArchitecture.Application.DTOs;

namespace MVCCleanArchitecture.Application.Interfaces
{
    public interface IDataItemService
    {
        Task<IEnumerable<DataItem>> GetDataItemsAsync();
    }
}