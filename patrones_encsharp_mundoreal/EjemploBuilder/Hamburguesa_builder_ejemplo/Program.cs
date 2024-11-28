using Hamburguesa_builder_ejemplo;

BurguerDirector chef = new BurguerDirector();

ClassicBurgerBuilder classicBurgerBuilder = new ClassicBurgerBuilder();

chef.MakeBurger(classicBurgerBuilder);

//la devolvemos para imprimir por pantalla

Burger classicBurger = classicBurgerBuilder.GetBurger();

Console.WriteLine("Classic Burger : ");
classicBurger.DisplayBurgerInfo();

VeggieBurgerBuilder veggieBurgerBuilder = new VeggieBurgerBuilder();

chef.MakeBurger(veggieBurgerBuilder);
Burger veggieBurger = veggieBurgerBuilder.GetBurger();

Console.WriteLine("Veggie Burger : ");
veggieBurger.DisplayBurgerInfo();