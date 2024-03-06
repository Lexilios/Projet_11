using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

public class goal : MonoBehaviour
{
    [SerializeField] private player _player;
    [SerializeField] private player _otherplayer;
    [SerializeField] private ball _ball;
    [SerializeField] private Score[] _scoreTableau;

    public UnityEvent ongoal;
    

    private void OnTriggerEnter(Collider other)
    {
        if ( other.GetComponent<ball>() != null)
        {
            _player.score++;
            ongoal.AddListener(_player.ResetPosition);
            ongoal.AddListener(_otherplayer.ResetPosition);
            ongoal.AddListener(_ball.ResetPosition);
            ongoal.Invoke();
            foreach (Score scr in _scoreTableau)
            {
                scr.changedText(_player.score);
                Debug.Log(_player.score);
            }
        }
    }
}
