using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float xRangeMin = -8f;
    public float xRangeMax = 8f;
    public float yRangeMin = -4f;
    public float yRangeMax = 4f;

    private Rigidbody rb;
    private Vector3 randomDirection;
    private float changeDirectionInterval = 2f;
    private float timer = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        ChangeDirection();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= changeDirectionInterval)
        {
            ChangeDirection();
            timer = 0f;
        }

        Vector3 moveAmount = randomDirection * moveSpeed * Time.deltaTime;
        Vector3 newPosition = rb.position + moveAmount;

        // Constrain the position within specified boundaries
        newPosition.x = Mathf.Clamp(newPosition.x, xRangeMin, xRangeMax);
        newPosition.y = Mathf.Clamp(newPosition.y, yRangeMin, yRangeMax);

        rb.MovePosition(newPosition);
    }

    private void ChangeDirection()
    {
        randomDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized;
    }
}
