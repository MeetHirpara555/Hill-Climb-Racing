using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class setttings : MonoBehaviour
{
    public Slider Slider;
    float vol,last;
    public Text sound,carsec;
    // Start is called before the first frame update
    void Start()
    {
        vol = PlayerPrefs.GetFloat("vol",Slider.value);
        Slider.value = vol;
        if (vol > 0)
        {
            sound.text = "sound on";
        }
        else
        {
            sound.text = "sound off";
        }
        carsec.text = PlayerPrefs.GetString("gender");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void soundbtn()
    {
        string temp = sound.text;
        if(temp == "sound on")
        {
            last = Slider.value;
            sound.text = "sound off";
            PlayerPrefs.SetFloat("vol", 0f);
            vol = PlayerPrefs.GetFloat("vol");
            Slider.value = vol;
        }
        else
        {
            sound.text = "sound on";
            PlayerPrefs.SetFloat("vol",last);
            vol = PlayerPrefs.GetFloat("vol");
            Slider.value = vol;
        }
    }

    public void Backbtn()
    {
        SceneManager.LoadScene("home");
    }

    public void slidefun(float voll)
    {
        PlayerPrefs.SetFloat("vol",voll);
        if (voll > 0)
        {
            sound.text = "sound on";
        }
        else
        {
            sound.text = "sound off";
        }
    }
    public void carselection()
    {
        if(carsec.text =="boy")
        {
            carsec.text = "girl";
            PlayerPrefs.SetString("gender",carsec.text);
        }
        else
        {
            carsec.text = "boy";
            PlayerPrefs.SetString("gender", carsec.text);
        }
    }
}
