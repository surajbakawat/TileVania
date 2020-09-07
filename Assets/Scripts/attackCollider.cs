using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackCollider : MonoBehaviour
{
    public Collider2D attackTrigger;


    void Awake()
    {
        attackTrigger = GetComponent<Collider2D>();
        attackTrigger.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (attackTrigger.IsTouchingLayers(LayerMask.GetMask("Enemy")))
        {
            Destroy(collider.gameObject);
            attackTrigger.enabled = false;
        }
    }


}
