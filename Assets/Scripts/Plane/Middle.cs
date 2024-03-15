using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : MonoBehaviour
{
    public static bool _isMiddle;

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _isMiddle = true;
            Controller._isGround = true;
        }
    }


    private void OnCollisionExit(Collision other)
    {
        _isMiddle = false;
        Controller._isGround = false;
    }


    
    
}
