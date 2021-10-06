using System.Collections.Generic;
using TestApp.Models.ViewModels;

namespace TestApp.Models.DataModels
{
    public class IndexViewModel<T>
    {
        public IEnumerable<T> Set { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
