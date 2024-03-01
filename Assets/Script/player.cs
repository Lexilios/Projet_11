using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class player : MonoBehaviour
{
    [SerializeField] private float gravite = 9.81f;
    [SerializeField] private string horizontalInput;
    [SerializeField] private string verticalInput;
    private float moveHorizontal;
    Rigidbody rb;

    [SerializeField] float movementSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        ControllPlayer();
    }
    /* transform.Rotate(transform.up, Input.GetAxis("VerticalPlayer1") * 0.5f);
     transform.position = transform.position + transform.forward * 5 * Input.GetAxis("HorizontalPlayer1") * Time.deltaTime;*/
    void ControllPlayer()
    {
        moveHorizontal = Input.GetAxis(horizontalInput);


        Vector3 movement = new Vector3(moveHorizontal, 0.0f);
        transform.Rotate(transform.up, Input.GetAxis(verticalInput) * 0.5f);


    }

    

    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * moveHorizontal * movementSpeed);
    }

}




