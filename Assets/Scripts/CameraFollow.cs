using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public GameObject camBase;
    private Vector3 offset;
    float distance;
    Vector3 playerPrevPos, playerMoveDir;
    
    void Start()
    {
        offset = transform.position - player.transform.position;
        distance = offset.magnitude;
        playerPrevPos = player.transform.position;
    }
    
    void Update()
    {
         playerMoveDir = player.transform.position - playerPrevPos;
        if (playerMoveDir != Vector3.zero)
        {
            playerMoveDir.Normalize();
            //transform.position = player.transform.position - playerMoveDir * distance;
            transform.position = camBase.transform.position;
            Vector3 pos = transform.position;

            pos.y += 5f;

            //transform.position = pos;

            transform.LookAt(player.transform.position);

            playerPrevPos = player.transform.position;
        }
    }
}
