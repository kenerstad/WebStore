using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Data
{
    public class DbInitializer
    {

        public static void Seed(WebStoreDbContext context)
        {
            if (!context.Items.Any())
            {
                context.AddRange
                    (
                    );
            }
        }
    }
}
