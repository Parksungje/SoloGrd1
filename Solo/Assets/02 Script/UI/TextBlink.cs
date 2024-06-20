using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class SpaceKey_Start : MonoBehaviour
{
    private TMP_Text flashingText;
    private Coroutine _corou;
    void Awake()
    {
        flashingText = GetComponent<TMP_Text>();
    }
    private void OnEnable()
    {
        _corou = StartCoroutine(BlinkText());
    }

    private void OnDisable()
    {
        if (_corou != null)
            StopCoroutine(_corou);
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
