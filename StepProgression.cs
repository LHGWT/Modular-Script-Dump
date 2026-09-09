//Invokes actions when (SocketNeedsFilling == 0)
//Used to auto start the next step
//This script is needed for each step
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StepProgression : MonoBehaviour
{
    public UnityEvent NextStep;
    //The amount of sockets that needs to be filled before automatically triggering the next step
    public int SocketsNeedingFilling;
    //FillSockets is a action that can be called to reduced SocketsNeedingFilling by 1
    public void FillSockets()
    {
        SocketsNeedingFilling -= 1;
        if (SocketsNeedingFilling == 0)
        {
            //Invoke events when all slots are filled
            NextStep.Invoke();
        }
    }
}
//Made by Eng Hong