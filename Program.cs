using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<BLL>();
serviceCollection.AddTransient<IDAL, DAL>();

var serviceProvider = serviceCollection.BuildServiceProvider();
serviceProvider.GetRequiredService<BLL>().GetProducts().ForEach(x => {
    Console.WriteLine($"{x.Id}. {x.Name} - {x.Price} - {x.Stock}");
});
