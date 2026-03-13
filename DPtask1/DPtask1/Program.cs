namespace DPtask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = StudentFactory.CreateStudent("Engineering");
            s1.GetTypeOfStudent();

            Student s2 = StudentFactory.CreateStudent("Medical");
            s2.GetTypeOfStudent();
            //---------------------------------------------------------
            InstanceCounter counter = InstanceCounter.GetInstance();

            counter.Increment();
            counter.Increment();

            Console.WriteLine("Active Instances: " + counter.Count);
            //----------------------------------------------------------
            Document doc1 = new Document
            {
                Header = "Report",
                Footer = "Company",
                Pages = 5,
                Text = "Original Document"
            };

            Document doc2 = (Document)doc1.Clone();

            doc2.Text = "Cloned Document";

            doc1.Display();
            Console.WriteLine("-------------");
            doc2.Display();
            //-------------------------------------------------------------
            Console.WriteLine("-------------");
            PizzaDirector director = new PizzaDirector();
            IPizzaBuilder builder = new MargheritaPizzaBuilder();

            Pizza pizza = director.MakePizza(builder);

            pizza.ShowPizza();
        }
    }
}
