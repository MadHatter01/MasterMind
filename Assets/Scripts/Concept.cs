using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Concept : MonoBehaviour
{
    public GameObject button1, button2, button3, self;
    public Camera c;
    // Start is called before the first frame update
    void Start()
    {
        GameObject topButton = Instantiate(button1, self.transform.position + self.transform.up * .4f, self.transform.rotation) as GameObject;
        AdditionButton top = topButton.GetComponent<AdditionButton>();
        top.setPosition(1);
        top.setCamera(c);
        topButton.transform.Rotate(90, 0, 0);

        GameObject leftButton = Instantiate(button1, self.transform.position + self.transform.right * .4f, self.transform.rotation) as GameObject;
        AdditionButton left = leftButton.GetComponent<AdditionButton>();
        left.setPosition(3);
        left.setCamera(c);
        leftButton.transform.Rotate(90, 0, 0);

        GameObject rightButton = Instantiate(button1, self.transform.position + self.transform.right * -.4f, self.transform.rotation) as GameObject;
        AdditionButton right = rightButton.GetComponent<AdditionButton>();
        right.setPosition(2);
        right.setCamera(c);
        rightButton.transform.Rotate(90, 0, 0);
    }

    public void setCamera(Camera c)
    {
        this.c = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
