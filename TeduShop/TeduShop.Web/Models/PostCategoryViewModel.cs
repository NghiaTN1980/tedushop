using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class PostCategoryViewModel
    {
        public int ID { get; set; }

       
        public string Name { get; set; }

      
        public string Alias { get; set; }

        
        public string Description { set; get; }

        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }

    
        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<PostViewModel> Posts { get; set; }

        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { get; set; }
    }
}