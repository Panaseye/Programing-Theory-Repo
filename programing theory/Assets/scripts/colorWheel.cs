using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorWheel : MonoBehaviour
{
    public Image red;
    public Image blue;
    public Image yellow;
    public playerMovement playerScript;
    private Vector3 current;
    private Vector3 next;
    private Vector3 last;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("player").GetComponent<playerMovement>();
        current = red.transform.position;
        next = yellow.transform.position;
        last = blue.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.projectileIndex == 0)
        {// ABSTRACTION
            blue.transform.position = (current);
            red.transform.position = (next);
            yellow.transform.position = (last);
        }

        if (playerScript.projectileIndex == 1)
        {
            red.transform.position = (current);
            yellow.transform.position = (next);
            blue.transform.position = (last);
        }

        if (playerScript.projectileIndex == 2)
        {
            yellow.transform.position = (current);
            blue.transform.position = (next);
            red.transform.position = (last);
        }

    }
}
