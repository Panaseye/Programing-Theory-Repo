using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    [SerializeField] float speed = 20;
    [SerializeField] float zRange = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
       
    }
    public void Move()
    {
        transform.Translate((-Vector3.forward * Time.deltaTime*  speed));
        if (transform.position.z < zRange)
        {
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == gameObject.tag)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
