using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaData
{
    class MyHouse
    {
        public MyHouse() { }

        public ChaInfo CreateCha(int id)
        {
            ChaData data = DataManager.GetInstance().GetChaData(id);
            return new ChaInfo(data.id);
        }
    }
}
