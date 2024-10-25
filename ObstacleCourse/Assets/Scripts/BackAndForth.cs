using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] float movementDistance = 5f; // How far the object moves from the center
    [SerializeField] float speed = 1f; // Speed of oscillation
    private Vector3 startingPosition;

    void Start()
    {
        // Store the original position of the object
        startingPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position using a sine wave
        float offset = Mathf.Sin(Time.time * speed) * movementDistance;
        transform.position = startingPosition + new Vector3(offset, 0, 0);
    }
}