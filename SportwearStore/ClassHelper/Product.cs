using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportwearStore.EF
{
    public partial class Clothes
    {
        public string GetCountry { get => $"Страна производитель: {ManufactureCountry.NameCountry}"; }
        public string GetCost { get => $"{Price} ₽"; }
    }
}
