using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed = 1f;
    void Start()
    {
        
    }

    void Move()
    {
        Vector2 offset = new Vector2(0f, Time.time * _speed);
        GetComponent<MeshRenderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
