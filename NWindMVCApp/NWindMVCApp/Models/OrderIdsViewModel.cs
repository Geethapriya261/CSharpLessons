﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Diagnostics;


namespace NWindMVCApp.Models
{
    public class OrderIdsViewModel
    {
        public int Id { get; set; }
        public readonly List<SelectListItem> OrderIdSelectedList;
        public OrderIdsViewModel(List<int> orderIds)
        {
            OrderIdSelectedList = new List<SelectListItem>();
            foreach (var no in orderIds) 
            {
                OrderIdSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
            }
        }
    }
}
