using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgGen : MonoBehaviour
{
    public GameObject bg,bggenpoint;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <  bggenpoint.transform.position.x)
        {
            transform.position = new Vector2(transform.position.x+41f,transform.position.y);
            GameObject b = Instantiate(bg , transform.position,Quaternion.identity);
            
        }
    }
}
