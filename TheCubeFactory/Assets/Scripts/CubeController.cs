using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 targetPosition;
    private bool isMoving = false;

    private void Start()
    {
        SetNewTargetPosition();
    }

    private void Update()
    {
        if (!isMoving)
        {
            StartCoroutine(MoveToTargetPosition());
        }
    }

    private IEnumerator MoveToTargetPosition()
    {
        isMoving = true;
        while (Vector2.Distance(transform.position, targetPosition) > 0.1f)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }
        SetNewTargetPosition();
        isMoving = false;
    }

    private void SetNewTargetPosition()
    {
        float x = Random.Range(-5f, 5f);
        float y = Random.Range(-5f, 5f);
        targetPosition = new Vector2(x, y);
    }
}
