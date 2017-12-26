using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Player : MonoBehaviour
{
    //Singleton
    public static Player control;

    //To be private
    public int[] stats = new int[9];

    //public GameObject[] items;

    void Awake()
    {
        //Enhanced Singleton
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
        //Initialize
    }

    //void OnGUI (){
    //	GUI.Label(new Rect(100,100,100,30), "Silver: " + silver);
    //}

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        //data.silver = stats[1];

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            //stats[1] = data.silver;
        }
    }
}
[Serializable]
class PlayerData{
	public int silver;

    //TODO serializable
    //public string[] creatureNames;
    //public int[][] creatures;
}
