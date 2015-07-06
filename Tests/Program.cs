using System.Linq;
using System.Threading;
using SelfOrdering.Domain.Restaurant;
using SelfOrdering.Infra.Data;

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

            var repo = new BaseRepository<Restaurant>();
            await repo.InsertAsync(rest);

            var x = await repo.GetAllAsync();
            var rest1 = x.FirstOrDefault();
            var t = rest1.Tables;
        }

        static Restaurant BuildRestaurant()
        {
            Address address = new Address
            {
                Country = "Brasil",
                Latitude = "-12.31",
                Longitude = "-33.31",
                State = "SP",
                StreetName = "Avenida das Flores",
                StreetNumber = "1282",
                Suburb = "Jardim Arpoador",
                ZipCode = "05565000"
            };

            var rest = new Restaurant("Reino do Churrasco", address)
            {
                Menu = new Menu {Name = "Cardápio do Reino do Churrasco"}
            };

            //ESPETOS
            var espetos = new MenuSection("Espetinhos");
            espetos.AddItem(new MenuItem("Espeto de Carne", "Espeto artesanal de carne.", 5.90m, true, false)
            {
                Description = "Delicioso espeto feito com a carne de primeira. Espeto artesanal."
            });
            espetos.AddItem(new MenuItem("Espeto de Frango", "Espeto artesanal de frango.", 5.50m, true, false)
            {
                Description = "Delicioso espeto feito de frango. Espeto artesanal."
            });
            espetos.AddItem(new MenuItem("Espeto de Medalhão de Frango", "Espeto artesanal de medalhões de frango com bacon.", 5.60m, true, false)
            {
                Description = "Delicioso espeto contendo 5 medalhões de frango envolvidos com fatias de bacon. Espeto artesanal."
            });


            //BEBIDAS
            var bebidas = new MenuSection("Bebidas");
            bebidas.AddItem(new MenuItem("Água Mineral", "Água Mineral Bonafont", 2.50m, true, false));

            ////CERVEJAS
            var cervejas = new MenuSection("Cervejas");
            cervejas.AddItem(new MenuItem("Skol 600ml", "Cerveja Brahma do tipo pilsen, 600 ml", 7.50m, true, true));
            cervejas.AddItem(new MenuItem("Brahma 600ml", "Cerveja Skol do tipo pilsen, 600 ml", 7.50m, true, true));
            cervejas.AddItem(new MenuItem("Antarctica 600ml", "Cerveja Antarctica do tipo pilsen, 600 ml", 5.50m, true, true));
            bebidas.AddSubSection(cervejas);

            ////SUCOS
            var sucos = new MenuSection("Sucos");
            sucos.AddItem(new MenuItem("Suco de Laranja", "Suco natural de laranja", 7.50m, true, false));
            sucos.AddItem(new MenuItem("Suco de Limão", "Suco natural de limão", 7.50m, true, false));
            sucos.AddItem(new MenuItem("Suco de Amora", "Suco de polpa de amora", 5.50m, true, false));
            sucos.AddItem(new MenuItem("Suco de Abacaxi", "Suco natural de abacaxi", 8.50m, true, false));
            bebidas.AddSubSection(sucos);

            //ADICIONA SECTIONS AO MENU
            rest.Menu.AddSection(espetos);
            rest.Menu.AddSection(bebidas);

            //MESAS
            rest.AddTable(new Table("1"));
            rest.AddTable(new Table("2"));
            rest.AddTable(new Table("3"));
            
            Table t4 = new Table("4");
            
            rest.AddTable(t4);
          

            return rest;
        }

    }
}
