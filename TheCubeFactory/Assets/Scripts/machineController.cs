using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class machineController : MonoBehaviour
{
    public TextMeshPro workerValueText;
    private int workerValue = 0;

    public void AddWorker()
    {
        if (workerValue < 5)
        {
            workerValue++;
            UpdateWorkerValueText();
        }
    }

    public void SubtractWorker()
    {
        if (workerValue > 0)
        {
            workerValue--;
            UpdateWorkerValueText();
        }
    }

    private void UpdateWorkerValueText()
    {
        workerValueText.text = workerValue + "/5";

        if (workerValue == 5)
        {
            workerValueText.gameObject.SetActive(false);
        }
        else
        {
            workerValueText.gameObject.SetActive(true);
        }
    }
}
