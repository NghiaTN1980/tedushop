using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;

namespace TeduShop.Web.Models
{
    public class ProductViewModel
    {
        public int ID { set; get; }
       
        public string Name { set; get; }

        public string Alias { set; get; }
     
        public int CategoryID { set; get; }
       
        public string Image { set; get; }
        
        public string MoreImages { set; get; }

        public decimal Price { set; get; }

        public decimal? PromotionPrice { set; get; }

        public int? Warranty { set; get; }

        public string Description { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { get; set; }

        public int? ViewCount { set; get; }

        public string Tags { get; set; }

        public virtual ProductCategoryViewModel ProductCategory { get; set; }
    }
}