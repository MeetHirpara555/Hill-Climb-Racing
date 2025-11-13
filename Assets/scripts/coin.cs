using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class coin : MonoBehaviour
{
    Animator animator;
    FORcoin fc;
    float vol;
    
    
    // Start is called before the first frame update
    void Start()
    {
        fc = FindObjectOfType<FORcoin>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            fc.coinplaymusic();
            Destroy(collision.gameObject);
        }
    }
    

}
