using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModerStore.Shared.Entities;

namespace ModerStore.Domain.Entities
{
    public class Product : Entity
    {
        public Product(string title, decimal prince, string image, int quantityOnHand) {

            Title = title;
            Prince = prince;
            Image = image;
            QuantityOnHand = quantityOnHand;

        }



        public string Title { get; private set; }
        public decimal Prince { get; private set; }
        public string Image{ get; private set; }

        public int QuantityOnHand { get; private set; }

    }
}

