using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _collision;
    [SerializeField] private TMP_Text _text;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TextFade fade = new TextFade();
            fade.Fade(_text, 0, 0.5f);
            Destroy(this.gameObject);
            _collision.enabled = false;
        }
    }
}
