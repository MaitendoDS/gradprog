using StripsBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Interfaces
{
    public interface IStripRepository
    {
        Strip GetStrip(int id);
        List<Strip> GetAll();
        Strip Update(Strip strip);
    }
}
