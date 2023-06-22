using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    private float spawnRange = 5f;

    public Button slowButton;
    public Button normalButton;
    public Button fastButton;

    private void Start()
    {
        slowButton.onClick.AddListener(SpawnWorkerSlow);
        normalButton.onClick.AddListener(SpawnWorkerNormal);
        fastButton.onClick.AddListener(SpawnWorkerFast);
    }

    public void SpawnWorkerSlow()
    {
        SpawnWorker(2f);
    }

    public void SpawnWorkerNormal()
    {
        SpawnWorker(5f);
    }

    public void SpawnWorkerFast()
    {
        SpawnWorker(8f);
    }

    private void SpawnWorker(float moveSpeed)
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-spawnRange, spawnRange), Random.Range(-spawnRange, spawnRange));
        GameObject newWorker = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        newWorker.tag = "worker";
        newWorker.AddComponent<CubeController>().moveSpeed = moveSpeed;
    }
}
