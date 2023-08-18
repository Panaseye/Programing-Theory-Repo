using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{// INHERITANCE

    [SerializeField] float dificulty = 3;
   
   

    private void Awake()
    {
        
    }


    void Update()
    {
        
    }

    public void Move(float speed)
    {
        transform.Translate((Vector3.forward * Time.deltaTime * speed)/dificulty);
        
    }
}
