using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playermovementnew : MonoBehaviour
{
    public float speedPlayer = 7f;
    public GameObject playerCenter;
    public ParticleSystem weaponParticle;  // Add the particle system reference
    public float fireRate = 0.5f;  // Time between shots
    private float nextFireTime = 0f;
    Rigidbody2D rdbody;
    Animator animatorContoller;
    SpriteRenderer spriteRd;

    public GameObject bulletGameObject;
    public Transform gunPoint;
    public float gunpower = 5f;

    public ParticleSystem partical;


    private void Start()
    {
        rdbody = GetComponent<Rigidbody2D>();
        animatorContoller = GetComponent<Animator>();
        spriteRd = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        // Player movement
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 mouseScreenPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 directionLook = (mouseScreenPos - (Vector2)transform.position).normalized;
        playerCenter.transform.right = directionLook;

        rdbody.velocity = new Vector2(moveX, moveY) * speedPlayer;

        Debug.Log(rdbody.velocity);

        if (Math.Abs(rdbody.velocity.x) > 0|| Math.Abs(rdbody.velocity.y) > 0)
        {
            animatorContoller.SetInteger("switchAni", 1);
        }
        else
        {
            animatorContoller.SetInteger("switchAni", 0);
        }

        if (rdbody.velocity.x < 0)
        {
            spriteRd.flipX = true;
        }
        if (rdbody.velocity.x > 0)
        {
            spriteRd.flipX = false;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }


    }

    void Shoot()
    {
        partical.Play();
        GameObject bulletSp = Instantiate(bulletGameObject, gunPoint.position, gunPoint.rotation);
        Rigidbody2D bulletrb = bulletSp.GetComponent<Rigidbody2D>();
        bulletrb.velocity = bulletSp.transform.right * gunpower;
    }

}



