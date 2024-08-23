using LOGIN3.BR;
using LOGIN3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LOGIN3.SERVICE.Iservices
{
    public interface ISTATESERVICE
    {
        //Stateservice Stateservice(MainDBcontext _dbContext);
         IEnumerable<StatesDto> GetList();
         IEnumerable<StatesDto> GetDistrictsList();

         IEnumerable<StatesDto> ConvertTableToList(DataTable dt, bool states = false);


    }
}