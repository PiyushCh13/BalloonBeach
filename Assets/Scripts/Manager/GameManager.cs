using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.VFX;


public enum GameState
{
   Menu,
   Started,
   GameOver
}

public class GameManager : MonoBehaviour
{
    public Transform player;

    private int player_score;
    public int Player_Score {  get { return player_score; } set { player_score = value; } }

    private int high_score;
    public int High_Score { get { return high_score; } set { high_score = value; } }

    public GameState player_state;

    public UnityEvent OnCollectPoint;

    void Awake()
    {
        Application.targetFrameRate = 60;
        SaveLoadManager.InitialiseData();
    }

    private void Start()
    {
        player_state = GameState.Menu;
        Time.timeScale = 0.0f;
        LoadGame();
    }

    public void OnGameOver() 
    {
        UpdateHighScore();
        ManagerHandler.Instance.music_Manager.PLaySFX(ManagerHandler.Instance.music_Manager.damage_Sound);
        player_state = GameState.GameOver;
        player.gameObject.SetActive(false);
        Time.timeScale = 0.0f;
        ManagerHandler.Instance.ui_Manager.Enable_GameOverScreen();
        SaveGame();
    }

    public void UpdateHighScore()
    {
        if(Player_Score > High_Score) 
        {
            High_Score = Player_Score;
        }
    }

    public void SaveGame()
    {
        Save saveData = new Save
        {
            high_score = High_Score,
        };

        string json = JsonUtility.ToJson(saveData);
        SaveLoadManager.SaveData(json);
    }

    public void LoadGame()
    {
        string saveString = SaveLoadManager.LoadData();

        if (saveString != null)
        {
            Save savedata = JsonUtility.FromJson<Save>(saveString);

            High_Score = savedata.high_score;
        }
    }


}
