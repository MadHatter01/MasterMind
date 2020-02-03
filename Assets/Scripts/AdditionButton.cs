using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionButton : MonoBehaviour
{
    public GameObject self, concept, lineH, lineV;
    public int position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setPosition(int p)
    {
        position = p;
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
}
