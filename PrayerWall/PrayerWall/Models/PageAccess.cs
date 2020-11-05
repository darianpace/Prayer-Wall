using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrayerWall.Models
{
    public class PageAccess
    {
        public long PageAccessId { get; set; }

        [Required]
        public string ActionName { get; set; }

        [Required]
        public string ControllerName { get; set; }

        public DateTime Date { get; private set; } = DateTime.Now;
    }
}
