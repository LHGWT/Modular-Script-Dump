using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ReturnToX : MonoBehaviour
{
    public Vector2 InitialPos;
    private float Speed;
    public float TimeToReturn;
    public bool Returning;
    public UnityEvent CallEffect;
    public bool isPreset;
    // Start is called before the first frame update
    void Start()
    {
        if (!isPreset)
        {
            InitialPos = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Returning)
        {
            transform.position = Vector2.MoveTowards(transform.position,InitialPos,Speed*Time.deltaTime*(1/TimeToReturn));
            if (Vector2.Distance(InitialPos, transform.position) < 0.01f)
            {
                Returning = false;
                CallEffect.Invoke();
            }
        }
    }
    public void ReturnToOrigin()
    {
        Speed = Vector2.Distance(InitialPos,transform.position);
        Returning = true;
    }
}
