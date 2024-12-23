using StripsBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Interfaces
{
    public interface IUitgeverijRepository
    {
        Uitgeverij GetUitgeverij(int id);
        List<Uitgeverij> GetAll();
        Uitgeverij Update(Uitgeverij uitgeverij);
        


    }
}
