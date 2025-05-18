using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject Start_Screen;
    public GameObject GameOver_Screen;
    public GameObject Game_Screen;

    void Start()
    {
        Enable_StartScreen();
    }

    void Update()
    {
        
    }

    public void RestartGame()
    {
        StartCoroutine(RestartGameCoroutine());
    }

    private IEnumerator RestartGameCoroutine() 
    {
        ManagerHandler.Instance.music_Manager.PLaySFX(ManagerHandler.Instance.music_Manager.click_Sound);
        yield return new WaitForSecondsRealtime(0.4f);
        SceneManager.LoadScene(0);
    }

    public void Enable_StartScreen() 
    {
        Start_Screen.SetActive(true);
        GameOver_Screen.SetActive(false);
        Game_Screen.SetActive(false);
    }

    public void Enable_GameOverScreen()
    {
        Start_Screen.SetActive(false);
        GameOver_Screen.SetActive(true);
        Game_Screen.SetActive(false);
    }

    public void Enable_GameScreen()
    {
        Start_Screen.SetActive(false);
        GameOver_Screen.SetActive(false);
        Game_Screen.SetActive(true);
    }
}
