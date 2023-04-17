using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        Vector3 Direction = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(Direction.x * speed*Time.deltaTime, 0, 0);
    }
}
