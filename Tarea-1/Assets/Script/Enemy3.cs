using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy3 : Enemy, IShoot, iObserver
{
    public GameObject player;
    public int life;
    public float maxDistance = 5f;
    public float moveSpeed = 20f;
    NavMeshAgent agent;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform pointShoot;
    [SerializeField] private float timertoShoot;
    private Vector2 randomPoint;
    float timer;
    Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timertoShoot)
        {
            timer = 0;
            Shoot();
        }
        Move();

        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void debug()
    {
        Debug.LogError(gameObject.name);
    }
    private void FixedUpdate()
    {
        if (player != null)
        {
            transform.LookAt(player.transform, transform.forward);
        }
        
    }

    public override void Move()
    {
        if (player != null)
        {

        }
    }

    public void Shoot()
    {
        Instantiate(bullet, pointShoot.position, pointShoot.rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Damage>() != null)
        {
            life -= collision.gameObject.GetComponent<Damage>().GetDamage();
        }
    }

    public void Execute(ISubject subject)
    {

    }
}
