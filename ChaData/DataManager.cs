using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ChaData
{
    class DataManager
    {
        private static DataManager instance;
        private Dictionary<int, ChaData> dicchadatas = new Dictionary<int, ChaData>();

        private DataManager() { }

        public static DataManager GetInstance() 
        {
            if (DataManager.instance == null)
            {
                DataManager.instance = new DataManager();
            }
            return DataManager.instance;
        }

        public void LoadDatas(int id)
        {
            string data = File.ReadAllText("./ChaList.json");
            ChaData[] chaDataps = JsonConvert.DeserializeObject<ChaData[]>(data);
            
            foreach(var cdata in chaDataps)
            {
                this.dicchadatas.Add(cdata.id, cdata);
            }
            Console.WriteLine(this.dicchadatas.Count);

            var mydata = this.dicchadatas[id];
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",
                mydata.id,mydata.name,mydata.gender,mydata.age,mydata.height,mydata.weight,mydata.specialty,mydata.explain);
        }

        public ChaData GetChaData(int id)
        {
            return this.dicchadatas[id];
        }
    }
}
