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

        transform.Rotate(transform.up, Input.GetAxis("Vertical") * 10);
        transform.position = transform.position + transform.right * 30 * Input.GetAxis("Horizontal") * Time.deltaTime;

        Debug.Log(Input.GetAxis("Horizontal"));
    }

    private void FixedUpdate()
    {
        
    }
}
