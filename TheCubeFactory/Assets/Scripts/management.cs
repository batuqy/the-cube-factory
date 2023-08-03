using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class management : MonoBehaviour
{

    public TextMeshProUGUI costText; // Reference to the TextMeshProUGUI component.

   
   
    public void SetCostText(float value)
    {
        Debug.Log("cost: " + value);
        costText.text = value.ToString();
     
    }
    
}


