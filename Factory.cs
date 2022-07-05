using System;

class Factory
{
    public static IDAL GetDal()
    {
        return new DAL();
    }
}
