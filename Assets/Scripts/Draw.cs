using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
 public bool mouseTesting;
    private float pitch = 0;
    private float yaw = 0;
    public GameObject penPointer;
    public GameObject stroke;

    public static bool drawing = false;
    void update()
        {
            if(mouseTesting)
            {
                yaw += 2* Input.GetAxis("MouseX");
                pitch -= 2* Input.GetAxis("MouseY");
                transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            }
        }

    public void StartStroke()
        {
            GameObject currentStroke;
            drawing = true;
            currentStroke = Instantiate(stroke, penPointer.transform.position, penPointer.transform.rotation) as GameObject;
            
        }

    public void EndStroke()
        {
            drawing =  false;
        }

    public void EnablePen()
        {
            penPointer.SetActive(!penPointer.activeInHierarchy);
               
        }
}
