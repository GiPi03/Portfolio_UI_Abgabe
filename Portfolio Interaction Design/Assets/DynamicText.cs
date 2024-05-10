using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DynamicText : MonoBehaviour
{
    public TextMeshProUGUI dynamicText;
    public Slider slider; // Reference to the slider component
    private float volume = 10f; // Example variable to display
    // Start is called before the first frame update
    void Start()
    {
        // Ensure the dynamicText variable is assigned
        if (dynamicText == null)
        {
            Debug.LogError("Please assign the Text component in the inspector.");
        }

        // Add an event handler to the slider's OnValueChanged event
      //  slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    // Update is called once per frame
    public void Update()
    {
        // Example: Update the text to display the volume
        dynamicText.text = volume.ToString();
    }

    // Example method to update score
    public void UpdateText(float volume)
    {
        //volume = GameManager.instance.volumeForText; // Get the volume value from the GameManager

        dynamicText.text = volume.ToString(); // Update the text with the new volume value
    }

    public void SetVolume(float amount)
    {
        volume = amount;
        UpdateText(volume);
       
    }

}
