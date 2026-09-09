//Storage container for the controller infomation for easy acssess for the buttons
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.Transformers;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class CanvasMenu : MonoBehaviour
{
    public XRDirectInteractor LeftHand;
    public XRRayInteractor LeftLazer;
    public XRDirectInteractor RightHand;
    public XRRayInteractor RightLazer;
}
//Made by Eng Hong