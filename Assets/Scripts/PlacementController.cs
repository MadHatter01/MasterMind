using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
[RequireComponent(typeof(ARRaycastManager))]

public class PlacementController : MonoBehaviour
{
  [SerializeField]

  private GameObject cardPrefab;

    public GameObject CardPrefab
    {
        get{
        return cardPrefab;
        }

        set{
        cardPrefab = value;
        }
    }

    private ARRaycastManager arRayCastManager;

    void Awake(){
    
        arRayCastManager = GetComponent<ARRaycastManager>();
    }

    bool GetTouchPosition(out Vector2 touchPosition)
        {
            if(Input.touchCount > 0){
                touchPosition= Input.GetTouch(0).position;
            return true;
            }
            touchPosition = default;
            return false;
    
        }

    void Update()
    {
        if(!GetTouchPosition(out Vector2 touchPosition)){
            return;
        }
        if(arRayCastManager.Raycast(touchPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
            {
            var hitPose = hits[0].pose;
            Instantiate(cardPrefab, hitPose.position, hitPose.rotation);
        }
    }

    static List<ARRaycastHit> hits =  new List<ARRaycastHit>();
}
