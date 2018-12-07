using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectAction : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            Die();
        }
    }

    private void Die()
    {

        Application.LoadLevel(Application.loadedLevel);

    }
}
