using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerHandler : Singleton<ManagerHandler>
{
    public MusicManager music_Manager;
    public GameManager game_Manager;
    public LevelManager level_Manager;
    public UIManager ui_Manager;
    public UIAnimationHandler ui_AnimationHandler;
}
