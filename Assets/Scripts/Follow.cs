using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform target;

    private void Update() {
        if(Vector2.Distance(transform.position, target.position) > 1f){
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if(Vector2.Distance(transform.position, target.position) > 5f){
            speed = 5f;
        }
        else if (Vector2.Distance(transform.position, target.position) < 2f){
            speed = 2f;
        }   
    }
}
