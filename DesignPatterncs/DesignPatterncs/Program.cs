using DesignPatterncs.Adapter;
using DesignPatterncs.Builder;
using DesignPatterncs.ChainOfResponsibility;
using DesignPatterncs.Command;
using DesignPatterncs.Composite;
using DesignPatterncs.Mediator.Example;
using DesignPatterncs.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Explination
            Console.WriteLine("--------------------------------Adapter----------------------------------");
            ITarget adapter = new MyAdapter();
            adapter.Request();
            Console.WriteLine("--------------------------------Adapter----------------------------------");
            Console.ReadLine();

            ///Explination

            Console.WriteLine("--------------------------------Builder----------------------------------");
            Director direct = new Director();
            Car c = direct.Build(new CarBuilder());
            Console.WriteLine("--------------------------------Builder----------------------------------");
            Console.ReadLine();

            ///Explination

            Console.WriteLine("--------------------------------Composite----------------------------------");
            CompositeItem Branch1 = new CompositeItem() { BranchID = 1 };
            CompositeItem Branch2 = new CompositeItem() { BranchID = 2 };

            for (int i = 0; i < 5; i++)
            {
                Branch1.AddChild(new Leaf() { LeafID = i, BranchID = Branch1.BranchID });
            }
            for (int i = 0; i < 3; i++)
            {
                Branch2.AddChild(new Leaf() { LeafID = 5 + i, BranchID = Branch2.BranchID });
            }

            Branch2.AddChild(Branch1);

            Branch2.CallMethod();
            Console.WriteLine("--------------------------------Composite----------------------------------");
            Console.ReadLine();

            ///Explination

            Console.WriteLine("--------------------------------Chain of Responsibility----------------------------------");


            Level1Response level1 = new Level1Response() { Level = 1 };
            Level2Response level2 = new Level2Response() { Level = 2 };
            Level3Response level3 = new Level3Response() { Level = 3 };

            level1.SetSuccessor(level2);
            level2.SetSuccessor(level3);

            level1.ProcessRequest(1);
            level1.ProcessRequest(2);
            level1.ProcessRequest(3);

            Console.WriteLine("--------------------------------Chain of Responsibility----------------------------------");
            Console.ReadLine();

            ///Explination


            Console.WriteLine("--------------------------------Command Pattern----------------------------------");

            Invoker invoke = new Invoker();
            invoke.CallCommand();

            Console.WriteLine("--------------------------------Command Pattern----------------------------------");
            Console.ReadLine();

            Console.WriteLine("--------------------------------Mediator Pattern----------------------------------");

            ChatRoom chat = new ChatRoom();
            Participant Amy = new Actor(chat, "Amy");
            Participant Dylan = new Actor(chat, "Dylan");
            Participant Micheal = new NonActor(chat, "Micheal");

            chat.Register(Amy);
            chat.Register(Dylan);
            chat.Register(Micheal);

            Amy.Send("Dylan", "Hey!");
            Dylan.Send("Micheal", "Hiya!");
            Micheal.Send("Amy", "I'm Micheal!");



            Console.WriteLine("--------------------------------Mediator Pattern----------------------------------");

            Console.ReadLine();

            Console.WriteLine("--------------------------------Visitor Pattern----------------------------------");


            Examples List = new Examples();
            List.Add(new Example("Rough", "Blue", "Example1"));
            List.Add(new Example("Smooth", "White", "Example2"));
            List.Add(new Example("Cracked", "Green", "Example3"));
            List.Add(new Example("Fuzzy", "Red", "Example4"));
            List.Add(new Example("Stretched", "Yellow", "Example5"));

            MaterialVisitor MV = new MaterialVisitor();
            ColourVisitor CV = new ColourVisitor();

            MV.Visit(List.getExample(0));
            CV.Visit(List.getExample(0));


            MV.Visit(List.getExample(2));
            CV.Visit(List.getExample(2));

            MV.Visit(List.getExample(1));
            CV.Visit(List.getExample(4));




            Console.WriteLine("--------------------------------Visitor Pattern----------------------------------");
            Console.ReadLine();

        }
    }
}
