using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class player : MonoBehaviour
{
    [SerializeField] private float gravite = 9.81f;
    [SerializeField] private string horizontalInput;
    [SerializeField] private string verticalInput;
    [SerializeField] private string runInput;
    [SerializeField] public int score;
    [SerializeField] private float staminaRegenRate = 0.05f;
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float springtSpeed = 15f;
    private float moveHorizontal;
    public Vector3 startPosition;
    Rigidbody rb;
    stamina staminascript;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        staminascript = GetComponent<stamina>();
    }


    void Update()
    {

        ControllPlayer();
    }

    void ControllPlayer()
    {
        moveHorizontal = Input.GetAxis(horizontalInput);


        Vector3 movement = new Vector3(moveHorizontal, 0.0f);
        transform.Rotate(transform.up, Input.GetAxis(verticalInput) * 0.7f);
    }

    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * moveHorizontal * movementSpeed);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeed = springtSpeed;

        }
    }
    private void Awake()
    {
        startPosition = transform.position;
    }
    public void ResetPosition()
    {
        transform.position = startPosition;
    }
}




