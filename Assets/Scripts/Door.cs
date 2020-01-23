using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool canOpen = false;
    bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canOpen)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(gameObject);
            }
        }
    }

    public bool Open()
    {
        return open;
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerController temp = other.gameObject.GetComponent<PlayerController>();
        if(temp != null)
        {
            Debug.Log("CanOpen");
            canOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerController temp = other.gameObject.GetComponent<PlayerController>();
        if (temp != null)
        {
            canOpen = false;
        }
    }
}
