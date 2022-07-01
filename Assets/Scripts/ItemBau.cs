using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBau : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 5, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
    }
}
