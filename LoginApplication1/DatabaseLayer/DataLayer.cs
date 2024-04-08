using LoginApplication1.Entity;
using LoginApplication1.Models;

namespace LoginApplication1.DatabaseLayer
{
    public class DataLayer
    {
        public List<Create> GetAllLogin()
        {

            CreateContext context = new CreateContext();

            List<Create> data = context.Logindetails.ToList();

            return data;

        }
    }
}
