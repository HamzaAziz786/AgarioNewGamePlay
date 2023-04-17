using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private void Update()
    {
        Vector2 direction = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, direction, speed * Time.deltaTime);
    }
}
