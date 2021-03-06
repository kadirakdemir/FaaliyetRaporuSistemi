﻿using FaaliyetRaporu.Core.Domain.Entites;
using FaaliyetRaporu.Service.ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaaliyetRaporu.Data.UnitOfWork;

namespace FaaliyetRaporu.Service.FaaliyetTuruService
{
    public class FaaliyetTuruService : ServiceBase<FaaliyetTuru>,IFaaliyetTuruService
    {
        public FaaliyetTuruService(UnitOfWork uow) : base(uow)
        {
        }
    }
}
