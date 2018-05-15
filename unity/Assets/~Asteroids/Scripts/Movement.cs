using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public float speed = 20f; // Units to travel per second
    public float rotationSpeed = 360f; // Amount of rotation per second

    private Rigidbody2D rigid; // Reference to attached RigidBody2D
    // Use this for initialization
    void Start()
    {
        // Grab referenceto rigidbody2D component 
        // NOTE: It gets this from the GameObject this script is attached to 
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
