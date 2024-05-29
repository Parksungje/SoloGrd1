using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowManager : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 3f; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.transform;
        }
    }

    private void Update()
    {
        if (player != null)
        {
            Vector3 moveDirection = player.position - transform.position;
            moveDirection.Normalize();
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }
    }
}
