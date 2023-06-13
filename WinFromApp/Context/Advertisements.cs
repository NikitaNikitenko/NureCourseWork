namespace WinFromApp.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Advertisements
    {
        [Key]
        public int AdvertisementID { get; set; }

        public int? UserID { get; set; }

        public int? CategoryID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        public decimal? Price { get; set; }

        public DateTime? PostDate { get; set; }

        public virtual Categories Categories { get; set; }

        public virtual Users Users { get; set; }
    }
}
