using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    [HideInInspector]
    public bool val = false;
    
    private void Update()
    {
        if (Input.GetKeyDown("i"))
        {

            Debug.Log(gameObject.name +" - "+ val);
        }
    }
    
}
