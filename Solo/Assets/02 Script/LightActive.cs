using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightActive : MonoBehaviour
{
    public Light2D light2D;
    public PolygonCollider2D polygon;

    private void Awake()
    {
        polygon = GetComponent<PolygonCollider2D>();
        light2D = GetComponent<Light2D>();
    }

    private void Update()
    {
        FlashInput();
    }

    private void FlashInput()
    {
        if (Input.GetMouseButton(0))
        {
            Flash(true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Flash(false);
        }
    }

    private void Flash(bool value)
    {
        polygon.enabled = value;
        light2D.enabled = value;
    }
}
