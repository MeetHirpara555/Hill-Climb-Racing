using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FORcoin : MonoBehaviour
{
    AudioSource AudioSource;
    float vol;
    int coinc;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        coinc = 0;
        PlayerPrefs.SetInt("cc", coinc);
    }

    // Update is called once per frame
    void Update()
    {
        vol = PlayerPrefs.GetFloat("vol");
        AudioSource.volume = vol;
    }

    public void coinplaymusic()
    {
        AudioSource.Play();
        coinc++;
        PlayerPrefs.SetInt("cc", coinc);
    }
}
