using System;
using System.Collections.Generic;

namespace Assignment10.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Bowlers> Bowlers { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
        public string TeamCategory { get; set; }
    }
}
