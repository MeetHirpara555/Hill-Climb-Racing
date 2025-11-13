using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanger : MonoBehaviour
{
    private static GameObject instance;
    AudioSource audioSource;
    float vol;
    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        
        if(instance != null)
        {
            Destroy(instance);
        }
        instance = gameObject;
        DontDestroyOnLoad(this);                    
    }

    // Update is called once per frame
    void Update()
    {
        vol = PlayerPrefs.GetFloat("vol");
        audioSource.volume = vol;
    }
}
