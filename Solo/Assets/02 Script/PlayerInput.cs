using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIn : MonoBehaviour
{
    private Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Prisoner"))
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
