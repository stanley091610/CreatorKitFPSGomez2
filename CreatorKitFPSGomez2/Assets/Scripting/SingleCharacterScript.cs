using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class SingleCharacterScript : MonoBehaviour
{
    public class Stuff 
    {
        public int bullets;
        public int grenades;
        public int rockets;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
    }


    public Stuff myStuff = new Stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletPrefab;
    public Transform FirePosition;
    public float bulletSpeed;


    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();
    }


    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vectical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }


    void Shoot()
    {
        if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, FirePosition.position, FirePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(FirePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }
}
