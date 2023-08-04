using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class sliderColor : MonoBehaviour
{

    public TextMeshProUGUI costText; // Reference to the TextMeshProUGUI component.
    private Color greenColor = Color.green;
    private Color yellowColor = Color.yellow;
    private Color redColor = Color.red;

    public Slider slider;
    public Image sliderFill;
    private void Awake()
    {
        // Attach the OnValueChanged listener to the slider
        slider.onValueChanged.AddListener(SetCostText);
    }
    public void SetCostText(float value)
    {
        
        costText.text = "Cost: %"+value.ToString();

        if (value >= 1 && value <= 32)
        {
            sliderFill.color = greenColor;
        }
        else if (value >= 33 && value <= 74)
        {
            sliderFill.color = yellowColor;
        }
        else if (value >= 75 && value <= 100)
        {
            sliderFill.color = redColor;
        }
        
    }



}


