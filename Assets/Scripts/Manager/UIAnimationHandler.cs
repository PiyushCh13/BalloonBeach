using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAnimationHandler : MonoBehaviour
{
    public void Animation_Scale(RectTransform rect,float endValue,float duration) 
    {
        rect.DOScale(endValue, duration).SetLoops(-1,LoopType.Yoyo).SetUpdate(true);
    }

    public void Animation_Roation(RectTransform rect, Vector3 endValue, float duration)
    {
        rect.DORotate(endValue, duration,RotateMode.FastBeyond360).SetLoops(-1).SetUpdate(true);
    }
}
