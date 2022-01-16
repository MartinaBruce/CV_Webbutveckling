using System.ComponentModel.DataAnnotations;

namespace MvcCV.Models
{
    public class Companies
    {


        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public string Company { get; set; }
    }


}
