using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeManager : MonoBehaviour
{
    public int day;
    public int month;

    private float elapsedTime;

    void Update()
    {
        elapsedTime += Time.deltaTime * Time.timeScale; // Zaman ölçeğine göre geçen zamanı hesapla

        if (elapsedTime >= 600f) // Her 10 dakikada bir kontrol et
        {
            elapsedTime = 0f; // Zamanlayıcıyı sıfırla

            day++; // Günü bir arttır

            if (day > 30) // Eğer gün 30'a ulaşırsa
            {
                day = 1; // Günü sıfırla
                month++; // Ayı bir arttır

                if (month > 12) // Eğer ay 12'ye ulaşırsa
                {
                    Debug.Log("Game Over"); // "Game Over" mesajını görüntüle
                    return;
                }
            }

            Debug.LogFormat("New Day: {0}/{1}", day, month); // Yeni gün mesajını görüntüle
        }
    }
}
