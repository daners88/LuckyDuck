using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyDucks : MonoBehaviour
{
    // Start is called before the first frame update
    bool found = false;
    Transform target = null;
    public float moveSpeed = 4f;
    public float rotationSpeed = 4f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(found)
        {
            if(Vector3.Distance(transform.position, target.position) > 1.5)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(target.position - transform.position), rotationSpeed * Time.deltaTime);
                transform.position += transform.forward * moveSpeed * Time.deltaTime;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!found)
        {
            PlayerController temp = other.gameObject.GetComponent<PlayerController>();
            if (temp != null)
            {
                Debug.Log("Found");
                found = true;
                target = other.transform;
                temp.AddDuck();
                this.gameObject.layer = 9;
            }
        }
    }
}
