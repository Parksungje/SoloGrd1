using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;

public class TextFade : MonoBehaviour
{
    public Tween _tween;
    public void Fade(TMP_Text text, float value, float delay)
    {
        _tween = text.DOFade(value, delay);
    }
}
