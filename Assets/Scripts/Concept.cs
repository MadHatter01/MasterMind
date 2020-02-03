using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Concept : MonoBehaviour
{
    public GameObject button1, button2, button3, self;
    // Start is called before the first frame update
    void Start()
    {
        GameObject topButton = Instantiate(button1, self.transform.position + self.transform.up * .8f, self.transform.rotation) as GameObject;
        AdditionButton top = topButton.GetComponent<AdditionButton>();
        top.setPosition(1);
        topButton.transform.Rotate(90, 0, 0);

        GameObject leftButton = Instantiate(button1, self.transform.position + self.transform.right * .8f, self.transform.rotation) as GameObject;
        AdditionButton left = leftButton.GetComponent<AdditionButton>();
        left.setPosition(3);
        leftButton.transform.Rotate(90, 0, 0);

        GameObject rightButton = Instantiate(button1, self.transform.position + self.transform.right * -.8f, self.transform.rotation) as GameObject;
        AdditionButton right = rightButton.GetComponent<AdditionButton>();
        right.setPosition(2);
        rightButton.transform.Rotate(90, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
