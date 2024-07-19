using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class CallCustomEvent : MonoBehaviour
{
    public GameObject goBeat;
    public void Callcustom()
    {
        CustomEvent.Trigger(goBeat, "BeatSignal");
    }
}
