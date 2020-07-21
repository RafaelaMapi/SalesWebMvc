using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class SelerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
