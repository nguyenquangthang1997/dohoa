using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public GameObject small;
    public GameObject medium;
    public GameObject big;

    
    // Start is called before the first frame update
    void Start()
    {   
        for(int i =0; i < 12; i++)
        {
            for(int j = 0; j < 12; j++)
            {
                Vector3 position = new Vector3(i, 1, j);
                Quaternion rotation = new Quaternion(1, 1, 1, 1);
                GameObject obj = Instantiate(small, position, rotation) as GameObject;
            }
        }
        //Vector3 position = new Vector3(2, 1, 1);
        //Quaternion rotation = new Quaternion(1, 1, 1, 1);
        //GameObject obj = Instantiate(small, position, rotation) as GameObject;

        //position = new Vector3(3, 1, 1);
        //GameObject obj1 = Instantiate(big, position, rotation) as GameObject;

        //position = new Vector3(4, 1, 1);
        //GameObject obj2 = Instantiate(medium, position, rotation) as GameObject;

    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
