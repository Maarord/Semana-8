using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary; 
public class Manager2 : MonoBehaviour
{
   
    public int persona = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveGame(){
        var filePath = Application.persistentDataPath + "/game1.dat";

        FileStream file;

        if (File.Exists(filePath))
            file = File.OpenWrite(filePath);
        else
            file = File.Create(filePath);

        GameData data = new GameData();
        data.Personaje = persona;
        //data.Moneda = m2;
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
    }
}