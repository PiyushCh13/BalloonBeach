using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Save 
{
    public int high_score;
}
public static class SaveLoadManager
{
    public static readonly string SAVE_FOLDER_NONEDITOR = Application.persistentDataPath + "/Saves/";

    public static void InitialiseData()
    {
        bool directoryExists;
        directoryExists = Directory.Exists(SAVE_FOLDER_NONEDITOR);

        if (!directoryExists)
        {
            Directory.CreateDirectory(SAVE_FOLDER_NONEDITOR);

            Save saveData = new Save
            {
                high_score = 0,
            };

            string json = JsonUtility.ToJson(saveData);
            SaveData(json);
        }
    }

    public static void SaveData(string json)
    {
        File.WriteAllText(SAVE_FOLDER_NONEDITOR + "/Save.json", json);
    }

    public static string LoadData()
    {
        if (File.Exists(SAVE_FOLDER_NONEDITOR + "/Save.json"))
        {
            string savestring = File.ReadAllText(SAVE_FOLDER_NONEDITOR + "/Save.json");
            return savestring;
        }
        else
        {
            return null;
        }
    }
}
