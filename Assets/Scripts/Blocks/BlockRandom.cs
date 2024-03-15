using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlockRandom : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    public Transform[] positions;
    private int[] prefabIndices;
    private int currentIndex = 0;

    void Start()
    {
        prefabIndices = new int[] { 0, 1, 2 };
        // shuffle the order of the indices
        for (int i = 0; i < prefabIndices.Length; i++)
        {
            int temp = prefabIndices[i];
            int randomIndex = Random.Range(i, prefabIndices.Length);
            prefabIndices[i] = prefabIndices[randomIndex];
            prefabIndices[randomIndex] = temp;
        }
    }
    void Update()
    {
        if(currentIndex < 3)
        {
            if (prefabIndices[currentIndex] == 0)
            {
                Instantiate(prefab1, positions[currentIndex].position, positions[currentIndex].rotation);
            }
            else if (prefabIndices[currentIndex] == 1)
            {
                Instantiate(prefab2, positions[currentIndex].position, positions[currentIndex].rotation);
            }
            else
            {
                Instantiate(prefab3, positions[currentIndex].position, positions[currentIndex].rotation);
            }
            currentIndex++;
        }
    }
}
