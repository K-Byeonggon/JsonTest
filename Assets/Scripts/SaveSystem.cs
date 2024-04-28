using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public static class SaveSystem
{
    public static WaveInfo Load(string jsonFileName)
    {
        string filePath = "Assets/" + jsonFileName + ".json";

        if (!File.Exists(filePath))
        {
            Debug.LogError("���� ���ų� ��ã��");
            return null;
        }
        else { Debug.Log("���� �дµ� �����ؽ�~"); }

        string saveFile = File.ReadAllText(filePath);
        Debug.Log(saveFile);
        WaveInfo waveInfo = JsonUtility.FromJson<WaveInfo>(saveFile);

        return waveInfo;
    }

}
