using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.PlayerLoop;

public class Controller : MonoBehaviour
{
    public float jumpPower;
    public int jumpCount;
    public float duration;
    public float speed;
    private Rigidbody _rb;
    public static bool _isGround;

    private void Awake()
    {
        _isGround = true;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (Left._isLeft==false && _isGround==true)
            {
                
                transform.DOJump(new Vector3(transform.position.x-3.5f,transform.position.y,transform.position.z), jumpPower, jumpCount, duration);
            }

            

        }

        if (Input.GetKeyDown(KeyCode.D)&& _isGround==true)
        {
            if (Right._isRight==false)
            {
                
                transform.DOJump(new Vector3(transform.position.x+3.5f,transform.position.y,transform.position.z), jumpPower, jumpCount, duration);
            }

            

        }
    }

    private void FixedUpdate()
    {
        Vector3 addedPos = transform.forward * speed*Time.deltaTime;
        transform.position += addedPos;
    }
}
