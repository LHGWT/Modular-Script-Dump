//Needs <CanvasMask> component in the parent object
//Used to change InteractionLayerMask to [MaskOfChoice] (can be set in inspector)
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
public class ChangeLayerMaskTo : MonoBehaviour
{
    private CanvasMenu Canvas; 
    private XRDirectInteractor LeftHand;
    private XRRayInteractor LeftLazer;
    private XRDirectInteractor RightHand;
    private XRRayInteractor RightLazer;
    //Mask Of Choice must include Raycasts Layer on top of the object you are trying to grab 
    public InteractionLayerMask MaskOfChoice;

    void Start()
    {
        Canvas = gameObject.GetComponentInParent<CanvasMenu>();
        LeftHand = Canvas.LeftHand;
        RightHand = Canvas.RightHand;
        LeftLazer = Canvas.LeftLazer;
        RightLazer = Canvas.RightLazer;
    }
    // Start is called before the first frame update
    public void Apply()
    {
        LeftHand.interactionLayers = MaskOfChoice;
        RightHand.interactionLayers = MaskOfChoice;
        LeftLazer.interactionLayers = MaskOfChoice;
        RightLazer.interactionLayers = MaskOfChoice;
    }
}
//Made by Eng Hong