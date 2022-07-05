BLL bll = new BLL(new DAL());

bll.GetProducts().ForEach(x => {
    Console.WriteLine($"{x.Id}. {x.Name} - {x.Price} - {x.Stock}");
});
