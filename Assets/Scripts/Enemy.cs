using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool chase = false;
    Transform target = null;
    public float moveSpeed = 5f;
    public float rotationSpeed = 5f;
    public GameObject loseScreen = null;
    public bool canMove = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chase)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), rotationSpeed * Time.deltaTime);
            transform.position += transform.forward * moveSpeed * Time.deltaTime;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerController temp = other.gameObject.GetComponent<PlayerController>();
        if (temp != null)
        {
            Debug.Log("DIE");
            chase = true;
            target = other.transform;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayerController temp = collision.gameObject.GetComponent<PlayerController>();
        {
            if(temp != null)
            {
                loseScreen.SetActive(true);
                UIManager.Instance.canMove = false;
            }
        }
    }
}
