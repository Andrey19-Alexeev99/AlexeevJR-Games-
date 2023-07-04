using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Camera_Script : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Vector3 target;
    [SerializeField] private float speed = 1.5f ;

    
   



    void FixedUpdate()

    {
        target = new Vector3(Player.transform.position.x,Player.transform.position.y, -5f);
        transform.position = Vector3.Lerp(transform.position, target, speed * Time.fixedDeltaTime);
    }
}
