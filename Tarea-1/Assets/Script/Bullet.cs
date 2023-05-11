using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public abstract class Bullet : MonoBehaviour, Damage, iObserver
{

    protected Rigidbody rb;
    [SerializeField] protected float speed;
    [SerializeField] protected int damage;
    [SerializeField] protected float scale;
    Vector3 max;
    private void Awake()
    {
        scale = 1;
        rb = GetComponent<Rigidbody>();
        max = new Vector3(4, 4, 4);
        transform.localScale = new Vector3(scale, scale, scale);
    }

    private void Start()
    {
        GameManager.GetInstance().Attach(this);
    }
    protected virtual void  Update()
    {
        //Destroy(gameObject, 4f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);
    }
    public int GetDamage()
    {
        return damage;
    }
    public void Execute(ISubject subject)
    {
        if (subject is GameManager)
        {
            scale += 0.01f;
            if (transform.localScale.magnitude < max.magnitude)
                transform.localScale = new Vector3(scale, scale, scale);
        }
    }
    private void OnDestroy()
    {
        GameManager.GetInstance().Remove(this);
    }

    public void debug()
    {
        Debug.LogError(gameObject.name);
    }
}
