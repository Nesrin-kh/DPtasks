namespace DPtask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITeacher teacher = new Teacher("Ahmed");

            teacher = new SalaryDecorator(teacher, 5000);
            teacher = new NationalityDecorator(teacher, "Egyptian");
            teacher = new StreetDecorator(teacher, "Alexandria");

            teacher.Show();
            //---------------------
            Console.WriteLine("---------------------");

            StoreFacade store = new StoreFacade();
            store.PlaceOrder();

            //-------------------------
            Console.WriteLine("---------------------");
            TaskContext task = new TaskContext(new InProgressState());

            task.Request();
            task.Request();
            task.Request();

        }
    }
}
