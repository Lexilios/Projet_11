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

    private void Awake()
    {
        startPosition = transform.position;
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
        StartCoroutine(BallStopMoving());

    }

    IEnumerator BallStopMoving()
    {
        yield return null;
        rb.isKinematic = true;
        yield return new WaitForSeconds(1f);
        rb.isKinematic = false;
    }
}
