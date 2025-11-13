using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject[] truck;
    Vector3 offset;
    string aa;
    // Start is called before the first frame update
    void Start()
    {
        aa = PlayerPrefs.GetString("gender");
        if (aa == "boy")
        {
            offset = transform.position - truck[0].transform.position;
        }
        else
        {
            offset = transform.position - truck[1].transform.position;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (aa == "boy")
        {
            transform.position = new Vector3(truck[0].transform.position.x + offset.x, truck[0].transform.position.y + offset.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(truck[1].transform.position.x + offset.x, truck[1].transform.position.y + offset.y, transform.position.z);
        }

        
    }
}
