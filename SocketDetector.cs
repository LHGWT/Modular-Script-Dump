//Throw this script onto your sockets
//This script is used to run actions when the socket is filled before removing itself from the socket.
//Use this script to Call [FillSockets] for its respective step (eg. CPU for Step1)
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketDetector : MonoBehaviour
{
    public UnityEvent Trigger;
    private XRSocketInteractor socket;
    void Awake()
    {
        socket = GetComponent<XRSocketInteractor>();
    }
    void Update()
    {
        if (socket.hasSelection)
        {
            //Invoke Actions assigened to the event 
            Trigger.Invoke();
            SocketDetector myself = gameObject.GetComponent<SocketDetector>();
            Destroy(myself);
        }
    }
}
//Made by Eng Hong