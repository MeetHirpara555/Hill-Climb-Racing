using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGen : MonoBehaviour
{
    public GameObject RoadGenPoint;
    public GameObject[] Road;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < RoadGenPoint.transform.position.x)
        {
            int i = Random.Range(0, Road.Length);
            transform.position = new Vector2(transform.position.x+17f, transform.position.y);
            GameObject rd = Instantiate(Road[i], transform.position, Quaternion.identity);

        }
    }

}
