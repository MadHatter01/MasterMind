using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class Stroke : MonoBehaviour
{
    private GameObject penPointer;
    
   
    void Start()
    {
        penPointer = GameObject.Find("PenPoint");
    }

    void Update()
    {
        //GetComponent<Renderer>().material.color = Color.black;
        
        if(Draw.drawing)
        {
            this.transform.position = penPointer.transform.position;
            this.transform.rotation = penPointer.transform.rotation;
        }
        else
        {
            this.enabled = false;
        }
        
       
    }
}
