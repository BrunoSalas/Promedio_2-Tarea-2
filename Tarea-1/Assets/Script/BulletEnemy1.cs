using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy1 : Bullet,iObserver
{
    private void Awake()
    {
        GameManager.GetInstance().Attach(this);
    }
    public void Execute(ISubject subject)
    {
        if (subject is GameManager)
        {
            scale = ((GameManager)subject).Progession;
        }
    }

    protected override void Update()
    {
        rb.velocity = Vector3.right * speed;
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + scale, gameObject.transform.localScale.y + scale, gameObject.transform.localScale.z + scale);
    }
    private void OnDestroy()
    {

        GameManager.GetInstance().Remove(this);
    }
}
