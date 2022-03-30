using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolContrl : MonoBehaviour
{
    CharacterController character;
    Rigidbody2D rgb2d;

    private void Awake()
    {
        character = GetComponent<CharacterController>();
        rgb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UseTool();
        }
    }

    private void UseTool()
    {
       
    }

}

