using LoginApplication1.Entity;
using LoginApplication1.Models;

namespace LoginApplication1.DatabaseLayer
{
    public class DataLayer
    {
        public List<Signup> GetAllLogin()
        {

            CreateContext context = new CreateContext();

            List<Signup> data = context.Register.ToList();

            return data;

        }

        public void InsertData(Signup model)
        {
            CreateContext context = new CreateContext();

            context.Register.Add(model);
            context.SaveChanges();


        }
    }
}
