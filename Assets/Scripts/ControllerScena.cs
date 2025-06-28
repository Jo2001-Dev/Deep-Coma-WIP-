using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerScena : MonoBehaviour
{
    [SerializeField] private string newLevel;
    [SerializeField] private string starts;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }
    public void start()
    {
        SceneManager.LoadScene(starts);
    }
}
