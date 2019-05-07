using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Plane : MonoBehaviour
{
    public GameObject small;
    public GameObject medium;
    public GameObject big;
    static readonly string fileName = @"C:\Users\Dell\Documents\main1\Assets\map\map.txt";

    // Start is called before the first frame update
    void Start()
    {

        if (File.Exists(fileName))
        {
            // Read a text file line by line.
            int row = -6, column = -6;
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            //console.writeline(line);
            {
                //Debug.Log(line);
                string[] lineList = line.Split(' ');
                column = -6;
                foreach(string scale in lineList)
                {
                    //createGameObject(row, column, small);

                    if (scale == "1")
                    {
                        createGameObject(row, column, small);
                    }
                    else if (scale == "2")
                    {
                        createGameObject(row, column, medium);

                    }
                    else if (scale == "3")
                    {
                        createGameObject(row, column, big);
                    }
                    column = column + 2 ;
                }
                row = row+2;
            }
        }

        //for (int i =0; i < 12; i++)
        //{
        //    for(int j = 0; j < 12; j++)
        //    {
        //        vector3 position = new vector3(i, 1, j);
        //        quaternion rotation = new quaternion(1, 1, 1, 1);
        //        gameobject obj = instantiate(small, position, rotation) as gameobject;
        //    }
        //}

        //Vector3 position = new Vector3(2, 1, 1);
        //Quaternion rotation = new Quaternion(1, 1, 1, 1);
        //GameObject obj = Instantiate(small, position, rotation) as GameObject;

        //position = new Vector3(3, 1, 1);
        //GameObject obj1 = Instantiate(big, position, rotation) as GameObject;

        //position = new Vector3(4, 1, 1);
        //GameObject obj2 = Instantiate(medium, position, rotation) as GameObject;

    }

    void createGameObject(int i, int j, GameObject scale)
    {
        Vector3 position = new Vector3(i, 1, j);
        Quaternion rotation = new Quaternion(1, 1, 1, 1);
        GameObject obj = Instantiate(scale, position, rotation) as GameObject;
    }
    // Update is called once per frame
    void Update()
    {
       

    }
}
