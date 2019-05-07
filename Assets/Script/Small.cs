using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Small : MonoBehaviour
{
    public GameObject medium;
    public int _count;

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
        Vector3 position = transform.position;
        Destroy(this.gameObject);
        _count++;
        //Vector3 position = new Vector3(1, 1, 1);
        Quaternion rotation = new Quaternion(1, 1, 1, 1);
        GameObject obj = Instantiate(medium, position, rotation) as GameObject;
    }
    void OnTriggerEnter(Collider obj)
    {
        if (obj.name == "bullet(Clone)")
        {
            Destroy(obj);
            Vector3 position = transform.position;
            Destroy(this.gameObject);
            Quaternion rotation = new Quaternion(1, 1, 1, 1);
            GameObject obj1 = Instantiate(medium, position, rotation) as GameObject;
        }
    }
}
