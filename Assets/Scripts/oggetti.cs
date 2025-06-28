using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oggetti : MonoBehaviour
{
    [SerializeField] GameObject Roccia;
    [SerializeField] GameObject Scala;
    [SerializeField] GameObject Cacciavite;
    [SerializeField] GameObject Foglio1;
    [SerializeField] GameObject Foglio2;
    [SerializeField] GameObject Keycard;
    [SerializeField] GameObject Ferro;
    [SerializeField] GameObject Graffette;
    [SerializeField] GameObject Martello;
    [SerializeField] GameObject Adesivo;

    private int r;
    private void Awake()
    {
         PlayerPrefs.DeleteKey("roccia");
    }
    private void Start()
    {
           r = PlayerPrefs.GetInt("roccia", 0);
    }
    private void Update()
    {
     
        if(r == 1)
        {
            Roccia.gameObject.SetActive(true);
        }
    }


    public void roccia()
    {
        Roccia.gameObject.SetActive(true);
        Destroy(gameObject);
        PlayerPrefs.SetInt("roccia", 1);
    }

    public void scala()
    {
        Scala.gameObject.SetActive(true);
        Destroy(gameObject);
        PlayerPrefs.SetInt("scala", 1);
    }

    public void cacciavite()
    {
        Cacciavite.gameObject.SetActive(true);
        Destroy(gameObject);
        PlayerPrefs.SetInt("cacciavite", 1);
    }

    public void foglio1()
    {
        Foglio1.gameObject.SetActive(true);
        Destroy(gameObject);
        PlayerPrefs.SetInt("foglio1", 1);
    }

    public void foglio2()
    {
        Foglio2.gameObject.SetActive(true);
        Destroy(gameObject);
        PlayerPrefs.SetInt("foglio2", 1);
    }

    public void keycard()
    {
        Keycard.gameObject.SetActive(true);
        Destroy(gameObject);
        PlayerPrefs.SetInt("keycard", 1);
    }

    public void ferro()
    {
        Ferro.gameObject.SetActive(true);
        Destroy(gameObject);
        PlayerPrefs.SetInt("ferro", 1);
    }

    public void graffette()
    {
        Graffette.gameObject.SetActive(true);
        Destroy(gameObject);
        PlayerPrefs.SetInt("graffette", 1);
    }

    public void martello()
    {
        Martello.gameObject.SetActive(true);
        Destroy(gameObject);
        PlayerPrefs.SetInt("martello", 1);
    }

    public void adesivo()
    {
        Adesivo.gameObject.SetActive(true);
        Destroy(gameObject);
        PlayerPrefs.SetInt("adesivo", 1);
    }
    
}
