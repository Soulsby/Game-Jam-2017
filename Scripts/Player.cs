using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Player : MonoBehaviour
{
    //Singleton
    public static Player control;

    public int score = 0;


    //To be private
    public int[] stats = new int[3];
    //int[0] is number of coins
    //int[1] is scene number
    //int[2] is score

    public void addToScore(int toAdd)
    {
        score += toAdd;
    }
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
class PlayerData
{
    

    //TODO serializable
    //public string[] creatureNames;
    //public int[][] creatures;
}
