using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed = 1f;
    public float _attacktime = 0.5f;
    public float _nexttimeAt;
    public GameObject _bulletPre;
    public Transform _attackpoint;
    [SerializeField]
    private GameObject _explotionpre;
    void Start()
    {
        _nexttimeAt = Time.time + _attacktime;
    }
    void attack()
    {
        if (Time.time > _nexttimeAt)
        {
            Instantiate(_bulletPre, _attackpoint.position, Quaternion.identity);
            _nexttimeAt += _attacktime;
        }
    }
    void Move()
    {
        Vector3 pos = transform.position;

        if (Input.GetAxis("Vertical") > 0 )
        {
            pos.y += _speed;
            if(pos.y > 3.7f)
                pos.y = 3.7f;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            pos.y -= _speed;
            if (pos.y < -4f)
                pos.y = -4f;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            pos.x += _speed;
            if (pos.x > 2.42f)
                pos.x = 2.42f;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            pos.x -= _speed;
            if (pos.x < -2.3f)
                pos.x = -2.3f;
        }
  
       
        transform.position = pos;
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "enemy")
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
        attack();
    }
}
