using System.Threading;
using SelfOrdering.Domain.Models;
using SelfOrdering.Infra.Data.Repositories;

namespace Tests
{
    class Program
    {

        static ManualResetEvent resetEvent = new ManualResetEvent(false);

        static void Main()
        {
            Insert();
            resetEvent.WaitOne(); // Blocks until "set"
        }
        

        static async void Insert()
        {
            var rest = BuildRestaurant();

            var repo = new RestaurantRepository();
            await repo.Insert(rest);

            var x = await repo.Get();

        }

        static Restaurant BuildRestaurant()
        {
            var rest = new Restaurant("Reino do Churrasco", 25);
            rest.Menu.Name = "Cardápio do Reino do Churrasco";

            var espetos = new MenuSection("Espetinhos");
            espetos.Items.Add(new MenuItem("Espeto de Carne", "Espeto artesanal de carne.", 5.90m)
            {
                
                Description = "Delicioso espeto feito com a carne de primeira. Espeto artesanal."
            });
            espetos.Items.Add(new MenuItem("Espeto de Frango", "Espeto artesanal de frango.", 5.50m)
            {
               
                Description = "Delicioso espeto feito de frango. Espeto artesanal."
            });
            espetos.Items.Add(new MenuItem("Espeto de Medalhão de Frango", "Espeto artesanal de medalhões de frango com bacon.", 5.60m)
            {
                
                Description = "Delicioso espeto contendo 5 medalhões de frango envolvidos com fatias de bacon. Espeto artesanal."
            });
            rest.Menu.MenuSections.Add(espetos);

            var bebidas = new MenuSection("Bebidas");
            bebidas.Items.Add(new MenuItem("Água Mineral", "Água Mineral Bonafont", 2.50m));

            var cervejas = new MenuSection("Cervejas");
            cervejas.Items.Add(new MenuItem("Skol 600ml", "Cerveja Brahma do tipo pilsen, 600 ml", 7.50m));
            cervejas.Items.Add(new MenuItem("Brahma 600ml", "Cerveja Skol do tipo pilsen, 600 ml", 7.50m));
            cervejas.Items.Add(new MenuItem("Antarctica 600ml", "Cerveja Antarctica do tipo pilsen, 600 ml", 5.50m));
            bebidas.SubSections.Add(cervejas);

            var sucos = new MenuSection("Sucos");
            sucos.Items.Add(new MenuItem("Suco de Laranja", "Suco natural de laranja", 7.50m));
            sucos.Items.Add(new MenuItem("Suco de Limão", "Suco natural de limão", 7.50m));
            sucos.Items.Add(new MenuItem("Suco de Amora", "Suco de polpa de amora", 5.50m));
            sucos.Items.Add(new MenuItem("Suco de Abacaxi", "Suco natural de abacaxi", 8.50m));
            bebidas.SubSections.Add(sucos);

            rest.Menu.MenuSections.Add(bebidas);

            return rest;

        }

    }
}
