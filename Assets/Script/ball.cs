using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] private float ballForce;
    public Vector3 startPosition;
    Rigidbody rb;


    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Awake()
    {
        startPosition = transform.position;
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
    }

}
