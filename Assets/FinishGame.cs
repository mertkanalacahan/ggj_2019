using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hellmade.Sound;

public class FinishGame : MonoBehaviour
{
    public AudioClip tam_aktarma;
    bool didPlay = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "isntMe" && !didPlay)
        {
            EazySoundManager.PlaySound(tam_aktarma, 1.0f, false, null);
            didPlay = true;
        }
    }
}
