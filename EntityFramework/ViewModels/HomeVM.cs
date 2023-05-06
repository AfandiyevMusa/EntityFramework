using System;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.ViewModels
{
	public class HomeVM
	{
        public List<Slider> sliders { get; set; }
        public List<Features> features { get; set; }
        public List<Services> services { get; set; }
    }
}

