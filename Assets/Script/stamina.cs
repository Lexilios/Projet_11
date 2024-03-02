using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stamina : MonoBehaviour
{
    [SerializeField] private float maxStamina = 10, curentStamina;
    [SerializeField] private Image staminaImage;

    void Start()
    {
        curentStamina = maxStamina;

    }

    public void updateStamina(float delta)
    {
        curentStamina += delta;

        if (curentStamina < 0)
        {
            curentStamina = 0;
        }

        if (curentStamina > maxStamina)
        {
            curentStamina = maxStamina;
        }
        staminaImage.fillAmount = curentStamina / maxStamina;
    }
    public bool checkStamina(float cost)
    {

        if (curentStamina < cost)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    /*private void Update()
    {
        staminaImage.fillAmount = curentStamina / maxStamina; test barre stamina
    }*/

}
