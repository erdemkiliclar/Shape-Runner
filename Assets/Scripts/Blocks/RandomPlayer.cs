using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomPlayer : MonoBehaviour
{
    private GameObject _player;
    [SerializeField] private GameObject[] players;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");

        players[0] = _player.transform.GetChild(0).gameObject;
        players[1] = _player.transform.GetChild(1).gameObject;
        players[2] = _player.transform.GetChild(2).gameObject;
    }

    private void OnCollisionEnter(Collision collision)
    {
        int x;
        x = Random.Range(0, 3);
        players[x].SetActive(true);
        
        for (int i = 0; i < players.Length; i++)
        {
            if (x!=i)
            {
                players[i].SetActive(false);
            }
        }
        Destroy(this.gameObject);
    }
}
