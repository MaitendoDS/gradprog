using StripsBL.Interfaces;
using StripsBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Services
{
    public class AuteurService
    {


        IAuteurRepository _auteurRepository;

        public AuteurService(IAuteurRepository auteurRepository)
        {

            _auteurRepository = auteurRepository;
        }


        public Auteur GetAuteur(int id)
        {
            try
            {
                return _auteurRepository.GetAuteur(id);
            }
            catch (Exception x)
            {

                throw new Exception("AuteurService-GetAuteur", x);
            }
        }


        public Auteur Update(Auteur auteur)
        {
            try
            {
                if (auteur == null)
                {
                    throw new Exception("Auteur is null");
                }

                return _auteurRepository.Update(auteur);


            }
            catch (Exception x)
            {

                throw new Exception("AuteurService-Update", x);
            }
        }

    }
}
