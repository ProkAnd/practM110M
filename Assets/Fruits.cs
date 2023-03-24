using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    public GameObject Fruit;
    public Transform generationPoint;
    public float distanceBetween;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("update", 10f, 10f);
    }

    // Update is called once per frame
     private void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x+distanceBetween, transform.position.y, transform.position.z);
            Instantiate(Fruit, transform.position, transform.rotation);
        }
    }
}
