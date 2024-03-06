using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class goal : MonoBehaviour
{
    [SerializeField]
    private player _player;
   

    private void OnTriggerEnter(Collider other)
    {
        if ( other.GetComponent<ball>() != null)
        {
            _player.score++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
