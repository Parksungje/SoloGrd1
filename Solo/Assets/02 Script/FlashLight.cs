using System;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    private Vector2 _mousePos;

    private void Update()
    {
        LookAtMouse();
    }
    private void LookAtMouse()
    {
        _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition)
            - transform.position;

        float z = Mathf.Atan2(_mousePos.y, _mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, z);
    }
}
