using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



/// <summary>
/// 序列化参数：包括温度拟合系数，PID控制参数
/// 对这些参数进行存储
/// 温度系数存放在 tempPID.dat 文件中         
/// PID系数存放在 tempTParameters.dat 文件中
/// </summary>
namespace SerieslizeControlModule
{


    [Serializable]
    class TParameters
    {
        public double a1;
        public double b1;

        public double a2;
        public double b2;

        public double a3;
        public double b3;

        public double a4;
        public double b4;
    }
   

    class CoreSerialize
    {

        
        private string Path_TParam;
       
        public CoreSerialize()
        {
           
                    
                Path_TParam = @"tempTParameters.dat";
           
        }

        public void TParammSerializeNow(TParameters data)
        {
            FileStream fileStream = new FileStream(Path_TParam, FileMode.OpenOrCreate);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(fileStream, data);
            fileStream.Close();
        }

        public TParameters TParamDeSerializeNow()
        {
            TParameters data = new TParameters();
            FileStream fileStream = new FileStream(Path_TParam, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter b = new BinaryFormatter();
            data = b.Deserialize(fileStream) as TParameters;
            fileStream.Close();

            return data;
        }

       

    }
}
