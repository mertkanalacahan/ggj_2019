using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hellmade.Sound;
using SWS;

public class GameManager : MonoBehaviour

{
    //sound
    public AudioClip alien_15temmuz;
    public AudioClip arrival;
    public AudioClip doorOpen;
    public AudioClip subwayAmbience;
    public Transform metroTransform;
    public splineMove[] teyzes;
    public AudioClip teyzeVoice;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

        EazySoundManager.PlayMusic(arrival, 1.0f, true, false);
        EazySoundManager.PlaySound(alien_15temmuz, 1.0f, false, null);
    }

    public void ActivateTeyzes()
    {
        EazySoundManager.PlaySound(doorOpen, 1.0f, false, null);
        EazySoundManager.PlaySound(teyzeVoice, 1.0f, false, null);
        EazySoundManager.PlaySound(subwayAmbience, 0.5f, true, null);

        foreach (var movComp in teyzes)
        {
            movComp.StartMove();
        }
    }
}
