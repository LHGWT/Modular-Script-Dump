using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    public Transform BulletSpawnPoint;
    public float AttackSpeed;
    public float AttackCD;
    public AudioSource audioplayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AttackCD -= Time.deltaTime;
        if (Input.GetMouseButton(0) && AttackCD <= 0) 
        {
            Instantiate(Bullet,BulletSpawnPoint);
            AttackCD = AttackSpeed;
            audioplayer.Play();
        }
    }
}
