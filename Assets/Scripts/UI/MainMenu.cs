using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public RectTransform ball_RectTransform;
    public RectTransform ball2_RectTransform;
    public RectTransform button_RectTransform;
    void Start()
    {
        ManagerHandler.Instance.ui_AnimationHandler.Animation_Scale(button_RectTransform, 0.7f, 1f);
        ManagerHandler.Instance.ui_AnimationHandler.Animation_Roation(ball_RectTransform, new Vector3(0,0,360f), 1.5f);
        ManagerHandler.Instance.ui_AnimationHandler.Animation_Roation(ball2_RectTransform, new Vector3(0, 0, 360f), 1.5f);
    }

    public void Play_Game()
    {
        ManagerHandler.Instance.music_Manager.PLaySFX(ManagerHandler.Instance.music_Manager.click_Sound);
        ManagerHandler.Instance.ui_Manager.Enable_GameScreen();
        ManagerHandler.Instance.game_Manager.player_state = GameState.Started;
        Time.timeScale = 1.0f;
    }
}
