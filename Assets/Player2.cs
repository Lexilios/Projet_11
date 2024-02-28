using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class player2 : MonoBehaviour
{
  
    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(transform.up, Input.GetAxis("VerticalPlayer2") * 0.5f);
        transform.position = transform.position + transform.forward * 5 * Input.GetAxis("HorizontalPlayer2") * Time.deltaTime;

    }

    private void FixedUpdate()
    {

    }

}
