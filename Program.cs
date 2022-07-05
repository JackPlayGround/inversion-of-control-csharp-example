BLL bll = new BLL();

bll.GetProducts().ForEach(x => {
    Console.WriteLine($"{x.Id}. {x.Name} - {x.Price} - {x.Stock}");
});
