using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeControl : MonoBehaviour
{
    public Slider slider;
    public DynamicText dynamicText;

    // Start is called before the first frame update

    void Start()
    {

      //  slider.onValueChanged.AddListener(SetVolume);

    }

    // Update is called once per frame
    public void Update()
    {
        float volume = slider.value;
    }
   
}
