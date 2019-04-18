using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big : MonoBehaviour
{
    public GameObject bullet;
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
        Debug.Log("kill");
        _count++;

        Quaternion rotation = new Quaternion(1, 1, 1, 1);
        Bullet b = bullet.GetComponent<Bullet>();
        b._rotation = 1;
        GameObject obj = Instantiate(bullet, position, rotation) as GameObject;
        b._rotation = -1;
        GameObject obj1 = Instantiate(bullet, position, rotation) as GameObject;
        b._rotation = 2;
        GameObject obj2 = Instantiate(bullet, position, rotation) as GameObject;
        b._rotation = -2;
        GameObject obj3 = Instantiate(bullet, position, rotation) as GameObject;
    }
    void OnTriggerEnter(Collider obj)
    {
        if (obj.name == "bullet")
        {
            Destroy(obj);
            Vector3 position = transform.position;
            Destroy(this.gameObject);
            //Vector3 position = new Vector3(1, 1, 1);
            Destroy(this.gameObject);
            Debug.Log("kill");
            Quaternion rotation = new Quaternion(1, 1, 1, 1);
            Bullet b = bullet.GetComponent<Bullet>();
            b._rotation = 1;
            GameObject obj4 = Instantiate(bullet, position, rotation) as GameObject;
            b._rotation = -1;
            GameObject obj1 = Instantiate(bullet, position, rotation) as GameObject;
            b._rotation = 2;
            GameObject obj2 = Instantiate(bullet, position, rotation) as GameObject;
            b._rotation = -2;
            GameObject obj3 = Instantiate(bullet, position, rotation) as GameObject;
        }
    }
}
