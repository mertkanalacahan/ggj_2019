using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SWS;

public class DestPointRandomizer : MonoBehaviour
{
    public navMove myNavComp;

    void Awake()
    {
        myNavComp = GetComponent<navMove>();
        myNavComp.startPoint = Random.Range(0, myNavComp.pathContainer.transform.childCount);
    }
}
