using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.volume = slider.value;
    }

    public void Mute()
    {
        AudioListener.pause = true;
    }

    public void UnMute()
    {
        AudioListener.pause = false;
    }
}
