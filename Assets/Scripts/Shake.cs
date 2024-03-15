using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Shake : MonoBehaviour
{
    public bool start = false;
    public AnimationCurve Curve;
    public float duration = 1f;

    private void Update()
    {
        if (start)
        {
            start = false;
            StartCoroutine(Shaking());
        }
        
    }

    IEnumerator Shaking()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = Curve.Evaluate(elapsedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere*strength;
            yield return null;

        }

        transform.position = startPosition;
    }
}
