using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ChaData
{
    class App
    {
        public App()
        {
            //Console.WriteLine("test");

            string data = File.ReadAllText("./ChaList.json");

            //Console.WriteLine(data);

            ChaData[] chaDatas = JsonConvert.DeserializeObject<ChaData[]>(data);

            Dictionary<int, ChaData> dicchadata = new Dictionary<int, ChaData>();

            foreach(ChaData chaData in chaDatas)
            {
                dicchadata.Add(chaData.id, chaData);
               // Console.WriteLine(chaData.height);
            }



           
            foreach (KeyValuePair<int,ChaData> kv in dicchadata)
            {
                
               Console.WriteLine(
                   "\nID:{0},\n이름:{1},\n성별:{2},\n나이:{3},\n키:{4},\n몸무게:{5}.\n특기:{6},\n설명:{7}"
                   ,kv.Key,kv.Value.name,kv.Value.gender,kv.Value.age,kv.Value.height,kv.Value.weight,kv.Value.specialty,kv.Value.explain);
               
               // Console.WriteLine(kv.Value.height);
            }
            
        }
    }
}
