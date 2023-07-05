using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewModel
{
  
    public class ProvinceViewModel
    {
        public ProvinceViewModel()
        {
            this.ProvinceList = new List<SelectListItem>();
            ProvinceList.Add(new SelectListItem { Text = "Seçiniz", Value = "" });
        }

        public int Province { get; set; }
        public List<SelectListItem> ProvinceList { get; set; }
    }
}
