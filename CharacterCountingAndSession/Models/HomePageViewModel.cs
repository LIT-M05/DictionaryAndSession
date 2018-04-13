using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterCountingAndSession.Models
{
    public class HomePageViewModel
    {
        public string Text { get; set; }
        public Dictionary<char, int> CharacterCount { get; set; }
    }
}