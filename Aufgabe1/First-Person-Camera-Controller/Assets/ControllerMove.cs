using System.Collections;
using UnityEngine;

public class ControllerMove : MonoBehaviour
{

    public float speed = 2f;
    public float sensitivity = 2f;
    CharacterController player;

    public GameObject look;

    float moveFB;
    float moveRL;

    float rotX;
    float rotY;

    // Use this for initialization
    void Start()
    {

        player = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        moveFB = Input.GetAxis("Vertical") * speed;
        moveRL = Input.GetAxis("Horizontal") * speed;

        rotX = Input.GetAxis("Mouse X") * sensitivity;
        rotY = Input.GetAxis("Mouse Y") * sensitivity;

        Vector3 movement = new Vector3(moveRL, 0, moveFB);
        transform.Rotate(0, rotX, 0);
        look.transform.Rotate(-rotY, 0, 0);

        movement = transform.rotation * movement;
        player.Move(movement * Time.deltaTime);


    }
}
