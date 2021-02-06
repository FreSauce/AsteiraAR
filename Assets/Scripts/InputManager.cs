using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject logic_kit;
    [SerializeField] private Camera arCam;
    [SerializeField] private ARRaycastManager _raycastManager;
    private Touch touch;

    List<ARRaycastHit> hits = new List<ARRaycastHit>(); 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        touch = Input.GetTouch(0);

        if (Input.touchCount < 0 || touch.phase != TouchPhase.Began)
            return;

        if (isPointerOverUI(touch)) return;
        
            Ray ray = arCam.ScreenPointToRay(touch.position);
        if(_raycastManager.Raycast(ray, hits))
        {
            Pose pose = hits[0].pose;
            Instantiate(logic_kit, pose.position, pose.rotation);
        }
          
    }
    bool isPointerOverUI(Touch touch)
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = new Vector2(touch.position.x, touch.position.y);
        List<RaycastResult> result = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData,result);
        return result.Count > 0;
    }
}
