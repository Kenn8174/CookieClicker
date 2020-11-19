using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieClicker.Data
{
    public class CookieClickerData
    {
        public double points { get; set; } = 0;
        public bool isAuto = false;

        public double pointsPerSeconds { get; set; } = 0;

        public int upgrade { get; set; } = 1;
        public double upgradeCostFirst { get; set; } = 20;
        public double upgradeCostSecond { get; set; } = 50;
    }
}
