using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print(collision.gameObject.tag);
        if(collision.gameObject.tag == "head")
        {
            SceneManager.LoadScene("gameover");
        }
    }

    
}
