using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sphere : MonoBehaviour
{
    private GameObject _cubePart, _triangularPart;
    private GameObject _spherePart,_scoreText,_GOPanel;

    private void Awake()
    {
        _GOPanel = GameObject.FindGameObjectWithTag("GOPanel");
        _scoreText = GameObject.FindGameObjectWithTag("ScoreText");
        _cubePart = GameObject.FindGameObjectWithTag("CubePart");
        _triangularPart = GameObject.FindGameObjectWithTag("TriangularPart");
        _spherePart = GameObject.FindGameObjectWithTag("SpherePart");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            
            
            CinemachineShake.Instance.ShakeCamera(5f,.2f);
            Score._score++;
            _scoreText.GetComponent<Animator>().Play("ScoreText");
            _spherePart.transform.position = gameObject.transform.position;
            _spherePart.GetComponent<ParticleSystem>().Play();
            
            gameObject.GetComponent<MeshCollider>().enabled=false;
        }
        else
        {
            Destroy(other.gameObject);
            if (other.gameObject.CompareTag("Cube"))
            {
                _cubePart.transform.position = gameObject.transform.position;
                _cubePart.GetComponent<ParticleSystem>().Play();
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
        _GOPanel.SetActive(true);
    }
}
