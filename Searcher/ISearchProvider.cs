using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRename.Searcher
{
    /// <summary>
    /// This interface defines the contract that are shared by all search provider implementors 
    /// </summary>
    interface ISearchProvider
    {
        IList<string> Search(string queryFilePath);
    }
}
