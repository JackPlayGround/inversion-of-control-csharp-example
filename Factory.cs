using System;

class Factory
{
    public static DAL GetDal()
    {
        return new DAL();
    }
}
