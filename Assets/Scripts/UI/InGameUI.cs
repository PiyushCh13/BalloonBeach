using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InGameUI : MonoBehaviour
{
    public TMP_Text score_Text;

    public void UpdateScore()
    {
        ManagerHandler.Instance.game_Manager.Player_Score++;
        ManagerHandler.Instance.music_Manager.PLaySFX(ManagerHandler.Instance.music_Manager.point_Sound);
        score_Text.SetText(ManagerHandler.Instance.game_Manager.Player_Score.ToString());
    }
}
