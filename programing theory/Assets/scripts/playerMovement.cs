using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private float timer = 0.0f;
    public float changeInterval = 1.5f;
    [SerializeField] float horizontalInput;
    [SerializeField] float speed = 20.0f;
    [SerializeField] float xRange = 20;
    [SerializeField] GameObject[] projectilePrefab;
    [SerializeField] int projectileIndex;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeInterval)
        {
            if (projectileIndex == 2)
            {
                projectileIndex = 0;
            } 

            else
            if(projectileIndex<2)
            {
                projectileIndex++;
            }

                timer = 0;
        }

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab[projectileIndex], transform.position, projectilePrefab[projectileIndex].transform.rotation);

        }

        if (transform.position.x < -xRange)
        {
             Border();
        }

        if (transform.position.x > xRange)
        {
            BorderRight();
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * Time.deltaTime * speed * horizontalInput);
    }

    void Border()
    {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }

    void BorderRight()
    {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }
}
