using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    TextMeshProUGUI scoreJoueur;
    
    void Start()
    {
        scoreJoueur = GetComponent<TextMeshProUGUI>();
    }

    public void changedText(int scorePlayer)
    {
        scoreJoueur.text = scorePlayer.ToString();
    }
}
