﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medium : MonoBehaviour
{
    public GameObject big;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Plane.click++;

        Vector3 position = transform.position;
        Destroy(this.gameObject);

        //Vector3 position = new Vector3(1, 1, 1);
        Quaternion rotation = new Quaternion(1, 1, 1, 1);
        GameObject obj = Instantiate(big, position, rotation) as GameObject;


    }
    void OnTriggerEnter(Collider obj)
    {
        if (obj.name == "bullet(Clone)")
        {
            Destroy(obj);
            Vector3 position = transform.position;
            Destroy(this.gameObject);
            Quaternion rotation = new Quaternion(1, 1, 1, 1);
            GameObject obj1 = Instantiate(big, position, rotation) as GameObject;
        }
    }
}
