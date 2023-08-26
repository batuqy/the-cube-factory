using UnityEngine;
using TMPro;

public class PieceAdder : MonoBehaviour
{
    public int piece = 1; // Initial value of the piece
    public float interval = 0.5f; // Time interval in seconds

    private float timer = 1.0f;
    public TextMeshProUGUI tmpText; // Reference to the TextMeshPro component

    private void Start()
    {
        // Get a reference to the TextMeshPro component
        //tmpText = GetComponent<TextMeshPro>();

        // Update the UI text initially
        UpdateUIText();
    }

    private void Update()
    {
         
        // Add to the timer
        timer += Time.deltaTime * Time.timeScale;

        // Check if the interval has passed
        if (timer >= interval)
        {
            // Reset the timer
            timer = 0.0f;

            // Add to the piece value
            piece++;

            // Update the UI text
            UpdateUIText();
        }
    }

    public void UpdateUIText()
    {
        // Update the UI text with the current piece value
        tmpText.text = "Piece: " + piece;
    }
}
