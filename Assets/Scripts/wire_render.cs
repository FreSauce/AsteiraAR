using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wire_render : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pin1;
    public GameObject pin2;
    [HideInInspector]public bool val;
    private void Update()
    {
        gameObject.GetComponent<LineRenderer>().SetPosition(0, pin1.transform.position);
        gameObject.GetComponent<LineRenderer>().SetPosition(1, pin2.transform.position);
        if (Input.GetKeyDown("w"))
        {
            Debug.Log(val);
        }
    }
}
