using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]

public class ObjectPlacement : MonoBehaviour
{
    public GameObject cardObject;
    private GameObject spawner;
    public Camera c;

    private ARRaycastManager ar_RaycastManager;
    private Vector2 touchPosition;
    private bool touchDown;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();


   private void Awake()
    {
        ar_RaycastManager = GetComponent<ARRaycastManager>();

    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }
        touchPosition = default;
        return false;
    }

    void Start()
    {
        touchDown = false;
    }

    // Update is called once per frame
    void Update()
    {



        if(!TryGetTouchPosition(out Vector2 touchPosition))
        {
            return;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
                touchDown = false;
        }

        if (ar_RaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;

            if(spawner == null && !touchDown)
            {
                touchDown = true;
                spawner = Instantiate(cardObject, hitPose.position, hitPose.rotation);
                spawner.GetComponent<Concept>().setCamera(c);
            }
            else
            {
                spawner.transform.position = hitPose.position;
            }
        }
    }
}
