﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class AdditionButton : MonoBehaviour
{
    public GameObject self, concept, lineH, lineV;
    public int position;
    private ARRaycastManager ar_RaycastManager;
    private GameObject spawner;
    //Camera cam;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public GameObject cardObject;

    // Start is called before the first frame update
    void Start()
    {
        ar_RaycastManager = GetComponent<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPosition))
        {
            return;
        }
        if (ar_RaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;

            if (3 == position)
            {
                Debug.Log("Pressed right");
                Instantiate(concept, self.transform.position + new Vector3(1, 0, 0), Quaternion.identity);
                Instantiate(lineH, self.transform.position + new Vector3(.3f, 0, 0), Quaternion.identity);
            }
            else if (position == 2)
            {
                Debug.Log("Pressed left");
                Instantiate(concept, self.transform.position + new Vector3(-1, 0, 0), Quaternion.identity);
                Instantiate(lineH, self.transform.position + new Vector3(-.3f, 0, 0), Quaternion.identity);
            }
            else
            {
                Debug.Log("Pressed top");
                Instantiate(concept, self.transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                Instantiate(lineV, self.transform.position + new Vector3(0, .3f, 0), Quaternion.identity);
            }

            /*if (spawner == null)
            {
                spawner = Instantiate(cardObject, hitPose.position, hitPose.rotation);
            }
            else
            {
                spawner.transform.position = hitPose.position;
            }*/
        }
    }

    public void setPosition(int p)
    {
        position = p;
    }

    public void setCamera(Camera c)
    {
        //cam = c;
    }

    void OnMouseDown()
    {
        if (3 == position)
        {
            Debug.Log("Pressed right");
            Instantiate(concept, self.transform.position + new Vector3(2, 0, 0), Quaternion.identity);
            Instantiate(lineH, self.transform.position + new Vector3(.6f, 0, 0), Quaternion.identity);
        }
        else if (position == 2)
        {
            Debug.Log("Pressed left");
            Instantiate(concept, self.transform.position + new Vector3(-2, 0, 0), Quaternion.identity);
            Instantiate(lineH, self.transform.position + new Vector3(-.6f, 0, 0), Quaternion.identity);
        }
        else
        {
            Debug.Log("Pressed top");
            Instantiate(concept, self.transform.position + new Vector3(0, 2, 0), Quaternion.identity);
            Instantiate(lineV, self.transform.position + new Vector3(0, .6f, 0), Quaternion.identity);
        }
    }
    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }
        touchPosition = default;
        return false;
    }
}
