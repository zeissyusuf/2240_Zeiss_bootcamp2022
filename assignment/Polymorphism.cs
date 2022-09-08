namespace ConsoleApp16
{
    class Engine
    {
        public void Start(){}
        public void Stop(){}
    }

    class TataCar
    {
        Engine _engine;
        TataCar(Engine eng){ _engine=eng;}
        //Dependency
        
        public void Ignite() {
           _engine.Start();
        }
        public void Halt() {
            _engine.Stop();
        }
    }
    class RevtronEngine:Engine
    {
        public void Start() { }
        public void Stop() { }
    }
    class VericoreEngine:Engine
    {
       public void Start() { Consone.WriteLine("VericoreEngine Start")}
        public void Stop() { Consone.WriteLine("VericoreEngine Stop")}
    }
    class KrytoechEngine:Engine
    {
     public void Start() { Consone.WriteLine("KrytoechEngine Start")}
        public void Stop() { Consone.WriteLine("KrytoechEngine Stop")}

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TataCar _nexon = new TataCar(RevtronEngine);

            TataCar _harrier = new TataCar(KrytoechEngine); //Kryotech engine

            TataCar _hexa = new TataCar(VericoreEngine);//vericore engine

            FamilyOccassion _family = new FamilyOccassion();
            Parent _parentInstance = new Parent();
            _family.Visit(_parentInstance);

            _parentInstance = new Child_One(); //Runtime Polymorphism
            _family.Visit(_parentInstance);

            _parentInstance = new Child_Two();
            _family.Visit(_parentInstance);

            _parentInstance = new Child_Three();
            _family.Visit(_parentInstance);

        }
    }


    public class FamilyOccassion
    {

        public void Visit(Parent  familyMember)
        {
            familyMember.Participate(); //Runtime Polymorphism
            
        }
        
    }

    public class Parent {
    
        public virtual void Participate()
        {
            Console.WriteLine("Parent ...Participate ");
        }
    }
    public class Child_One:Parent {

        public override void Participate()
        {
            Console.WriteLine("ChildOne...Participate");
        }
        public void Smoke()
        {

        }
    }
    public class Child_Two:Parent {

        public override void Participate()
        {
            Console.WriteLine("ChildTwo...Participate");
        }

    }
    public class Child_Three : Parent {
        public override void Participate()
        {
            Console.WriteLine("ChildThree...Participate");
        }

    }



}
