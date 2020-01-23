using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool canMove = false;
    int ducklingCount = 0;


    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    void Start()
    {

    }


    void Update()
    {
        if (UIManager.Instance.canMove)
        {
            canMove = true;
        }
        else
        {
            canMove = false;
        }
        if (canMove)
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
            transform.Translate(0, 0, Input.GetAxis("Vertical") == 0 ? 0.001f * Time.deltaTime * movementSpeed : Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
        }
    }

    public void AddDuck()
    {
        ducklingCount++;
    }
    public int GetDucks()
    {
        return ducklingCount;
    }
}
