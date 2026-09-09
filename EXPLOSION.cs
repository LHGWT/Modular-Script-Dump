using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXPLOSION : MonoBehaviour
{
    public float explosionSize;
    // Update is called once per frame
    void Update()
    {
        explosionSize += 40*Time.deltaTime;
        transform.localScale = new Vector3(explosionSize,explosionSize,explosionSize);
        GetComponent<Light>().intensity = explosionSize;
    }
}
