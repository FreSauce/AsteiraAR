using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour
{
    [SerializeField] public Material highlightmat;
    [SerializeField] public Material defaultmat;
    private Transform _selection;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultmat;
            _selection = null;
        }
        
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                    defaultmat = selectionRenderer.material;
                    selectionRenderer.material = highlightmat;
            }
            _selection = selection;
        }
    }
}
