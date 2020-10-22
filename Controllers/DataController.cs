using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class DataController : ApiController
    {
        //DataController(DataContext _dataContext) {
        //        //TODO: Ninject dataContext    
        //}

        public List<DataModel> get() {
            var dataContext = new DataContext();
            return dataContext.Datas.ToList().Select(x => new DataModel(x)).ToList();
        }
        public DataModel get(int id) {
            var dataContext = new DataContext();
            return new DataModel(dataContext.Datas.Find(id));
        }

        // POST api/values
        public void Post(DataModel dataModel)
        {
            var dataContext = new DataContext();
            dataContext.Datas.Add(new Data(dataModel));
            dataContext.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]DataModel dataModel)
        {
            var dataContext = new DataContext();
            var existingData = dataContext.Datas.Find(id);
            dataContext.Entry(existingData).CurrentValues.SetValues(dataModel);
            dataContext.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var dataContext = new DataContext();
            var data = dataContext.Datas.Find(id);
            dataContext.Datas.Remove(data);
            dataContext.SaveChanges();
        }
    }
}
