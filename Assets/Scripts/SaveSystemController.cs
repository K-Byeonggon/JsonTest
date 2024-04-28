using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveSystemController : MonoBehaviour
{

    void Start()
    {

        
        WaveInfo loadWave = SaveSystem.Load("jsonWave02");
        foreach(SpawnInfo spawn in loadWave.wave)
        {
            
            Debug.Log("time: " + spawn.time);
            Debug.Log("point: " + spawn.point);
            Debug.Log("name: " + spawn.name);
            

        }

        /*
        string path = "Assets/jsonSpawn.json";

        if (!File.Exists(path)) { Debug.LogError("파일 못 읽음!"); }
        else
        {
            string jsonString = File.ReadAllText(path);
            Debug.Log(jsonString);
            SpawnInfo spawn = JsonUtility.FromJson<SpawnInfo>(jsonString);
            Debug.Log("time: " + spawn.time);
            Debug.Log("point: " + spawn.point);
            Debug.Log("name: " + spawn.name);
        }*/

    }


}
