﻿using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Interfaces;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Infraestructure.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Infraestructure.Repositories
{
    public class AppSettingRepository:GenericRepository<Domain.Entities.AppSetting>, IAppSetting
    {
    }
}