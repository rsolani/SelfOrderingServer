using System;

namespace SelfOrdering.ApplicationServices.Customer
{
    public class CustomerDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Cpf { get; set; }
        public string UserImageUrl { get; set; }
        public DateTime BirthDate { get; set; }

        public int Age
        {
            get { return DateTime.Now.Year - BirthDate.Year; }
        }
        public int LoginProvider { get; set; }
        //public IList<OrderDTO> Orders { get; set; }

        public CustomerDTO()
        {
            //Orders = new List<OrderDTO>();
        }
    }
}
