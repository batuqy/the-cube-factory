using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public Button button0;
    public Button button1;
    public Button button2;
    public Button button3;

    void Start()
    {
        // Butonlara tıklama olayları atanır
        button0.onClick.AddListener(() => SetTimeScale(0f));
        button1.onClick.AddListener(() => SetTimeScale(1f));
        button2.onClick.AddListener(() => SetTimeScale(2f));
        button3.onClick.AddListener(() => SetTimeScale(3f));
    }

    void Update()
    {
        // Klavyeden 1, 2 ve 3 tuşlarına basıldığında aynı işlevi yerine getiren methodlar çağrılır
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetTimeScale(1f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetTimeScale(2f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetTimeScale(3f);
        }

        // Klavyeden space tuşuna basıldığında zaman durdurulur
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0f;
        }
    }

    void SetTimeScale(float scale)
    {
        Time.timeScale = scale;
    }
}
