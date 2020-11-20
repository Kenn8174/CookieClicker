using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieClicker.Data
{
    public class CookieUpgrades
    {
        public string UpgradeName { get; set; }
        public double UpgradeCost { get; set; }
        public double UpgradeMultiplier { get; set; }
        public int UpgradeCount { get; set; }
        public int OriginalCost { get; set; }
        //public bool IsDisabled { get; set; } = false;
    }
}
