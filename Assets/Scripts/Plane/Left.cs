using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Left : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool _isLeft;

    private void Awake()
    {
        _isLeft = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _isLeft = true;
            Controller._isGround = true;
        }
    }


    private void OnCollisionExit(Collision other)
    {
        _isLeft = false;
        Controller._isGround = false;
    }


    
}
