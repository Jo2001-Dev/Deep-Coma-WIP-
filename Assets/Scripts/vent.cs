using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vent : MonoBehaviour
{
    [SerializeField] private string Corridor1;

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(Corridor1);
        }
    }
}