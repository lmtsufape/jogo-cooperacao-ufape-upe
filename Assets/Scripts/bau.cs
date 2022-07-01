using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bau : MonoBehaviour
{
    [SerializeField]
    GameObject item;

    [SerializeField]
    private float forceItem;

    [SerializeField]
    Transform itemPosition;

    private void OnTriggerEnter2D(Collider2D other) {
        gameObject.GetComponent<Collider2D>().enabled = false;
        var clone =  item;
        Instantiate(clone, itemPosition.position, Quaternion.identity);
    }
}
