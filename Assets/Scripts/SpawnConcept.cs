﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnConcept : MonoBehaviour
{
    public GameObject concept;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(concept, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
