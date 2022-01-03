using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    interface IAnother<T>
where T : ISmth
    {
    }

    class First<T> : IAnother<T>
        where T : ISmth
    {
    }

    interface IFoo<T>
        where T : IService
    {
    }

    class Second<T> : IFoo<T>
        where T : IService
    {
        
    }

    public interface IHuman
    {
    }

    public class HumanImpl : IHuman
    {
    }
}

public interface ISmth
{
}

class ISmthImpl : ISmth
{
}

public interface IService
{
}




    public class FirstIServiceImpl : IService
    {
        public ISmth Smth { get; set; }

        public FirstIServiceImpl()
        {
        }

        public FirstIServiceImpl(ISmth smth)
        {
            Smth = smth;
        }
    }

    class SecondIServiceImpl : IService
    {
    }



    interface IData
    {
    }

    class IDataImpl : IData
    {
        public IClient Cl { get; set; }

        public IDataImpl(IClient cl)
        {
            Cl = cl;
        }
    }



    interface IClient
    {
    }

    class FirstIClientImpl : IClient
    {
        public IData Data { get; set; }

        public FirstIClientImpl(IData data)
        {
            Data = data;
        }
    }


    class SecondIClientImpl : IClient
    {
        public readonly IEnumerable<IService> Serv;

        public SecondIClientImpl(IEnumerable<IService> serv)
        {
            Serv = serv;
        }
    }


public interface FirstInterface { }
public class FirstClass : FirstInterface
{
    public SecondInterface second { get; set; }
    public FirstClass(SecondInterface iSecond)
    {
        this.second = iSecond;
    }
}


public interface SecondInterface { }
public class SecondClass : SecondInterface
{
    public ThirdInterface third { get; set; }
    public FirstInterface first { get; set; }
    public SecondClass(ThirdInterface iThird, FirstInterface iFirst)
    {
       this.third = iThird;
       this.first = iFirst;
    }
}


public interface ThirdInterface { }
public class ThirdClass : ThirdInterface
{
    public FirstInterface first { get; set; }

    public SecondInterface second { get; set; }
    public ThirdClass(FirstInterface iFirst, SecondInterface iSecond)
    {
        this.first = iFirst;
        this.second = iSecond;
    }
}