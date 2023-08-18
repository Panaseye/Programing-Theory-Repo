using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitWall : MonoBehaviour
{
    public gameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // ENCAPSULATION

        Destroy(other.gameObject);
            Debug.Log(gameManager.lives);
            gameManager.lives--;
            Debug.Log(gameManager.lives);
        
    }
}
