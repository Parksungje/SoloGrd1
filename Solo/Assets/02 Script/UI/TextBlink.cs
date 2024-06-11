using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SpaceKey_Start : MonoBehaviour
{
    Text flashingText;
    void Start()
    {
        flashingText = GetComponent<Text>();
        StartCoroutine(BlinkText());
    }
    public IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = "";
            yield return new WaitForSeconds(.6f);
            flashingText.text = "Click to Start";
            yield return new WaitForSeconds(.6f);
        }
    }
}
