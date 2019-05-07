using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int _rotation; 
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 poisition = new Vector3(0,0,0);
        if (_rotation == 1) poisition = new Vector3(0.5f, 0, 0);
        else if (_rotation == -1) poisition = new Vector3(-0.5f, 0, 0);
        else if (_rotation == 2) poisition = new Vector3(0, 0, 0.5f);
        else if (_rotation == -2) poisition = new Vector3(0, 0, -0.5f);
        this.transform.position += poisition;   
    }

    void OnTriggerEnter(Collider obj)
    {
        Destroy(this.gameObject);
    }
}
