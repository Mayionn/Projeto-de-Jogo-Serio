using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    public Animator animator;
    public GameObject reflection;
    [SerializeField]
    private float speed;
    public GameObject doorPlayer;
    public Sprite winDoor;
    public Sprite normalDoor;

    private void Start()
    {

    }

    private void Update()
    {
        Vector3 inputp = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.position = transform.position + inputp * speed* Time.deltaTime;

        Vector3 inputr = new Vector2(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical"));

        reflection.transform.position = reflection.transform.position + inputr * speed * Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            Die();
        }

        if (collision.gameObject.CompareTag("DoorPlayer"))
        {
            doorPlayer.GetComponent<SpriteRenderer>().sprite = winDoor;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DoorPlayer"))
        {
            doorPlayer.GetComponent<SpriteRenderer>().sprite = normalDoor;
        }
    }


    private void Die ()
    {

        Application.LoadLevel(Application.loadedLevel);

    }


}
