using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
   public IEnumerator ResetScene()
    {
        yield return new WaitForSeconds(1f);
    }
}
