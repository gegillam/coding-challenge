using System;

namespace WebApi
{
    public class DataModel
    {
        public DataModel(Data data) {
            id = data.id;
            json = data.json;
            title = data.title;
        }
        public DataModel() { }
        /// <summary>
        /// test23
        /// </summary>
        public int id { get; set; }
        public string json { get; set; }
        public string title { get; set; }
       // private DateTime updatedOn { get; set; }

    }
}