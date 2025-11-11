using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour

{
    public int lifeAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if (player != null)
        {
            player.AddLife(lifeAmount);
            Destroy(gameObject);
        }
    }
}