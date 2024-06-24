    using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActiveChanger : MonoBehaviour
{
    [SerializeField] private bool active;
    [SerializeField] private bool useText;
    public void ActiveSwitch()
    {
        active = !active;
        if(useText)
        {
            TMP_Text text = GetComponent<TMP_Text>();
            text.color = !active ? new Color(1, 1, 1, 0) : Color.white;
        }
        else
        {
            gameObject.SetActive(active);
        }
    }
}
