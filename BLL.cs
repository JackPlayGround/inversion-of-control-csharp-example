using System;
class BLL
{
    private DAL _dal { get; set; }

    public BLL()
    {
        _dal = Factory.GetDal();
    }

    public List<Product> GetProducts()
    {
        return _dal.GetProducts();
    }
}