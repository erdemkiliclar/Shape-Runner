using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    public static bool _isRight;

    private void Awake()
    {
        _isRight = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _isRight = true;
            Controller._isGround = true;
        }
    }


    private void OnCollisionExit(Collision other)
    {
        _isRight = false;
        Controller._isGround = false;
    }


    
}
