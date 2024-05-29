using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightActive : MonoBehaviour
{
    private bool state;
    public Light2D light2D;

    private void Start()
    {
        state = true;
    }

    private void Awake()
    {
        light2D = GetComponent<Light2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (state == true)
            {
                light2D.enabled = false;
                state = false;
            }
            else
            {
                light2D.enabled = true;
                state = true;
                
            }
        }
    }
}
