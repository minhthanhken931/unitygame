using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed = 1f;
    [SerializeField]
    private GameObject  _explotionpre;
    void Start()
    {
        
    }
    void Move()
    {
        Vector3 pos = transform.position;

        pos.y -= _speed;
        if (pos.y < -7f)
            Destroy(gameObject);


        transform.position = pos;
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "ammo")
        {
            
            var explo = Instantiate(_explotionpre, transform.position, Quaternion.identity);
            Destroy(explo, 0.85f);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
