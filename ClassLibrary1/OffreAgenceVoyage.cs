﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeBoVoyage.Donne
{
    public class OffreAgenceVoyage
    { 
        public int NombreVoyageurMax { get; set; }
        public string DescriptionDuVoyage { get; set; }
        public double PrixPersonne { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateRetour { get; set; }
        public string NumeroSequentiel{ get; set; }
        public List<OffreDeVoyage> offreDeVoyages { get; set; }
      
    }
    

}