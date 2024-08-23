using LOGIN3.BR;
using LOGIN3.Models;
using LOGIN3.SERVICE.Iservices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace LOGIN3.SERVICE
{
    public class Stateservice:ISTATESERVICE

    {
        private readonly MainDBcontext _dbContext;

        private readonly string statescachekey = "stateslist";
        private readonly string districtcachekey = "districtlist";

        public Stateservice(MainDBcontext dbContext)
        {
            dbContext = new MainDBcontext();
            _dbContext = dbContext;

        }

        public IEnumerable<StatesDto> GetList() 
        {
         var items = HttpRuntime.Cache[statescachekey] as IEnumerable<StatesDto>;
            if (items == null)
            {
                REGISTRATION reg =new REGISTRATION();
                DataTable dt= reg.GetStates();
                items=this.ConvertTableToList(dt,true);
                HttpRuntime.Cache.Insert(statescachekey, items, null, DateTime.Now.AddMinutes(30), TimeSpan.Zero);
            }
            return items;

        }

        public IEnumerable<StatesDto> GetDistrictsList()
        {
            var items = HttpRuntime.Cache[districtcachekey] as IEnumerable<StatesDto>;
            if (items == null)
            {
                REGISTRATION reg = new REGISTRATION();
                DataTable dt = reg.GetDistricts();
                items = this.ConvertTableToList(dt);
                HttpRuntime.Cache.Insert(districtcachekey, items, null, DateTime.Now.AddMinutes(30), TimeSpan.Zero);
            }
            return items;

        }

        public IEnumerable<StatesDto> ConvertTableToList(DataTable dt,bool states =false) 
        {
            List<EducationDetails> list = null;
            if (states)
            {
                return dt.AsEnumerable().Select(x => new StatesDto()
                {

                    StateID = x.Field<int>("StateID").ToString(),
                    StateName = x.Field<string>("StateName"),

                }).ToList();

            }
            else 
            {
                return dt.AsEnumerable().Select(x => new StatesDto()
                {

                    DistrictID = x.Field<int>("DistrictID").ToString(),
                    DistrictName= x.Field<string>("DistrictName"),
                    DistrictStateID=x.Field<int>("StateID").ToString()

                }).ToList();
            }
        }
    }
}