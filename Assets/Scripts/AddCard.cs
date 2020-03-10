using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCard : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject card;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCardAtPosition()
    {
        Instantiate(card, gameObject.transform.position, gameObject.transform.rotation);
    }
}
