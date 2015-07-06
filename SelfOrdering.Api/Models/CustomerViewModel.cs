using System;

namespace SelfOrdering.Api.Models
{
    public class CustomerViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserImageUrl { get; set; }
        public string Cpf { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get { return DateTime.Now.Year - DateOfBirth.Year; }
        }
        public int LoginType { get; set; }
    }
}
