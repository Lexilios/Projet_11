using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up, Input.GetAxis("VerticalPlayer1") * 0.5f);
        transform.position = transform.position + transform.forward * 5 * Input.GetAxis("HorizontalPlayer1") * Time.deltaTime;

    }

    private void FixedUpdate()
    {

    }

}
