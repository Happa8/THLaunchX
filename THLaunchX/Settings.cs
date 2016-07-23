using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace THLaunchX
{
    [Serializable()]
    class Settings
    {
        Settings appSettings = new Settings();
        //private string currentDir = System.Environment.CurrentDirectory;
        static string configFileName = System.Environment.CurrentDirectory + "\\settings.config";

        //バイナリファイルに書き込む
        BinaryFormatter bfConfig = new BinaryFormatter();
        System.IO.FileStream fsConfig = new System.IO.FileStream(configFileName, System.IO.FileMode.Create);
        

        
        
    }
}
