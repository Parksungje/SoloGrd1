using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 moveDir = new Vector3(h, v, 0);
        transform.position += moveDir * speed * Time.deltaTime;
        animator.SetBool("Move",moveDir != Vector3.zero);

    }
}
