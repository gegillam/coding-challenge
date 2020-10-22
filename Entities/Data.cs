using System;

namespace WebApi
{
    public class Data
    {
        public Data(DataModel dataModel) {
            id = dataModel.id;
            json = dataModel.json;
            title = dataModel.title;
            updatedOn = DateTime.Now;
            updatedBy = "gegillam";
        }
        public Data() { }
        public int id { get; set; }
        public string json { get; set; }
        public string title { get; set; }

        public DateTime updatedOn { get; set; }
        public string updatedBy { get; set; }

    }
}