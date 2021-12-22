using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed = 1f;
    void Start()
    {
        
    }
    void Move()
    {
        Vector3 pos = transform.position;
        pos.y += _speed;
        if (pos.y > 6f)
            Destroy(gameObject);

        transform.position = pos;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag   == "enemy")
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
