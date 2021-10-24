using amuNewCrono.Models.Interfaces;
using System;

namespace amuNewCrono.Models
{
    public class cronoModel : ICronoModel
    {
        public TimeSpan cronoValues { get; set; }                
    }
}
