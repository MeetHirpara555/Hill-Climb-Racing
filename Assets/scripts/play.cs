using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class play : MonoBehaviour
{
    public GameObject panel,male,female;
    public Text coincount;
    public Slider Slider;
    float vol, last;
    public Text sound;
    // Start is called before the first frame update
    void Start()
    {
        vol = PlayerPrefs.GetFloat("vol", Slider.value);
        Slider.value = vol;
        if (vol > 0)
        {
            sound.text = "sound on";
        }
        else
        {
            sound.text = "sound off";
        }
        string aa = PlayerPrefs.GetString("gender");
        if(aa == "boy")
        {
            male.SetActive(true);
        }
        else
        {
            female.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        int aa = PlayerPrefs.GetInt("cc");
        coincount.text = "" + aa;
    }

    public void soundbtn()
    {
        string temp = sound.text;
        if (temp == "sound on")
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
            PlayerPrefs.SetFloat("vol", last);
            vol = PlayerPrefs.GetFloat("vol");
            Slider.value = vol;
        }
    }

    public void Backbtn()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void slidefun(float voll)
    {
        PlayerPrefs.SetFloat("vol", voll);
        if (voll > 0)
        {
            sound.text = "sound on";
        }
        else
        {
            sound.text = "sound off";
        }
    }

    public void settingbtn()
    {
        Time.timeScale = 0f;
        panel.SetActive(true);
    }
}
