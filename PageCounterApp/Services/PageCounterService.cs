using System.Collections.Generic;

namespace PageCounterApp.Services
{
    public class PageCounterService : IPageCounterService
    {
        private readonly Dictionary<string, int> _pageCounts = new Dictionary<string, int>();

        public int IncrementPageCount(string pageName)
        {
            if (!_pageCounts.ContainsKey(pageName))
            {
                _pageCounts[pageName] = 0;
            }
            _pageCounts[pageName]++;
            return _pageCounts[pageName];
        }
    }
}
