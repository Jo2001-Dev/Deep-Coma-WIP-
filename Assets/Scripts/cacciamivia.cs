using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cacciamivia : MonoBehaviour
{   
    public bool passa = false;
    public void apertura()
    {
            Destroy(gameObject);
            passa = true;
    }
}

