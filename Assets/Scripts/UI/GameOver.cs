using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public RectTransform button_RectTransform;
    public RectTransform adbutton_RectTransform;
    public TMP_Text highScore_Text;

    void Start()
    {
        ManagerHandler.Instance.ui_AnimationHandler.Animation_Scale(button_RectTransform, 0.7f, 1f);
        ManagerHandler.Instance.ui_AnimationHandler.Animation_Scale(adbutton_RectTransform, 0.7f, 1f);
        SetHighScoreText();

    }

    public void SetHighScoreText() 
    {
        highScore_Text.SetText(ManagerHandler.Instance.game_Manager.High_Score.ToString());
    }

    public void Restart_Game()
    {
        ManagerHandler.Instance.ui_Manager.RestartGame();
    }
}
