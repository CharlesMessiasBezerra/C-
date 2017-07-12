using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using FluentValidator;
using ModerStore.Shared.Entities;

namespace ModerStore.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(
            string firstName,
            string lastName,
            string email,
            User user)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = null;
            Email = email;
            User = user;

            //validações
            new ValidationContract<Customer>(this)
                .IsRequired(x => x.FirstName, "Nome é obrigatorio")
                .HasMaxLenght(x => x.FirstName, 60)
                .HasMinLenght(x => x.FirstName, 3)
                .IsRequired(x => x.LastName, "Sobre Nome é obrigatorio")
                .HasMaxLenght(x => x.LastName, 60)
                .HasMinLenght(x => x.LastName, 3)
                .IsEmail(x => x.Email, "Email invalido");


        }


        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime? BirthDate { get; private set; }


        public string Username { get; private set; }

        public string Password { get; private set; }

        public string Email { get; private set; }

        public User User { get; private set; }

        public bool Isvalid() => Notifications.Count > 0;

        public void Update(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}