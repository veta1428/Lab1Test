using System;
using System.Collections.Generic;

namespace Lab1Test.EF
{
    public partial class Roster
    {
        public string Playerid { get; set; } = null!;
        public int? Jersey { get; set; }
        public string? Fname { get; set; }
        public string? Sname { get; set; }
        public string? Position { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Weight { get; set; }
        public int? Height { get; set; }
        public string? Birthcity { get; set; }
        public string? Birthstate { get; set; }
    }
}
