using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public string playerName;
    public int playerHealth;
    public int playerExperience;
}
public class SaveManager : MonoBehaviour
{
    private string savePath;

    private void Awake()
    {
        // Set the save path
        savePath = Application.persistentDataPath + "/saveData.json";
    }

    public void SaveGame(string playerName, int health, int experience)
    {
        
        SaveData saveData = new SaveData();
        saveData.playerName = playerName;
        saveData.playerHealth = health;
        saveData.playerExperience = experience;

        // Convert the saveData object to JSON string
        string jsonData = JsonUtility.ToJson(saveData);

        // Write the JSON string to a file
        File.WriteAllText(savePath, jsonData);

        Debug.Log("Game saved successfully.");
    }

    public void LoadGame()
    {
        if (File.Exists(savePath))
        {
            // Read the JSON string from the file
            string jsonData = File.ReadAllText(savePath);

            // Convert the JSON string back to SaveData object
            SaveData saveData = JsonUtility.FromJson<SaveData>(jsonData);

            // Use the saveData object to restore the game state
            string playerName = saveData.playerName;
            int health = saveData.playerHealth;
            int experience = saveData.playerExperience;

            // Perform necessary actions with the loaded data
            Debug.Log("Game loaded successfully.");
        }
        else
        {
            Debug.Log("No save data found.");
        }
    }
}
