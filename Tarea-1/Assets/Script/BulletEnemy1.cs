using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy1 : Bullet
{
   

    protected override void Update()
    {
        rb.velocity = Vector3.right * speed;
    }
}
