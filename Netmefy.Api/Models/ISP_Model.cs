﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netmefy.Api.Models
{
    public class ISP_TecnicosModel
    {
        public int sk { get; set; }
        public string id { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public Nullable<decimal> calificacion { get; set; }
        public int otAsignadas { get; set; }
        public int otCerradas { get; set; }
    }

    public class ISP_VelocidadesContratadas
    {
        public string zona { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<int> cant_reclamos { get; set; }
    }

    public class ISP_OTs_x_Dia
    {
        public string zona { get; set; }
        public DateTime startDate { get; set; }
        public List<int> otsPorDia { get; set; }
    }


}