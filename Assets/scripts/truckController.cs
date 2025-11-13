using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D front, back;
    float speed = 140f,vol;
    public int coin;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        front.AddTorque(-horizontal * Time.deltaTime * speed);
        back.AddTorque(-horizontal * Time.deltaTime * speed);

    }
    
}
