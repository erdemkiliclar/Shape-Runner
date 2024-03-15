using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject _spherePart, _triangularPart,_cubePart,_scoreText;


    private void Awake()
    {
        _scoreText = GameObject.FindGameObjectWithTag("ScoreText");
        _spherePart = GameObject.FindGameObjectWithTag("SpherePart");
        _triangularPart = GameObject.FindGameObjectWithTag("TriangularPart");
        _cubePart = GameObject.FindGameObjectWithTag("CubePart");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
                
                
                CinemachineShake.Instance.ShakeCamera(5f,.2f);
                Score._score++;
                _scoreText.GetComponent<Animator>().Play("ScoreText");
                _cubePart.transform.position = gameObject.transform.position;
                _cubePart.GetComponent<ParticleSystem>().Play();
                gameObject.GetComponent<MeshCollider>().enabled=false;
        }
        else
        {
            Destroy(other.gameObject);
            if (other.gameObject.CompareTag("Sphere"))
            {
                _spherePart.transform.position = gameObject.transform.position;
                _spherePart.GetComponent<ParticleSystem>().Play();
            }
            else if (other.gameObject.CompareTag("Triangular"))
            {
                _triangularPart.transform.position = gameObject.transform.position;
                _triangularPart.GetComponent<ParticleSystem>().Play();
            }
            StartCoroutine(Reload());
        }

        
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(0);
    }
}
