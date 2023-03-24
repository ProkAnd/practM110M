using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objects;

    void Start()
    {
        InvokeRepeating("CreateObjects", 1,1);
    }

    // Update is called once per frame
    void CreateObjects()
    {
        Instantiate(objects, new Vector3(13.35f, 6.18f, 0) , Quaternion.identity);
    }
}
