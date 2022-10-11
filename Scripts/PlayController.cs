using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    [SerializeField]
    protected float mouseSpeed;
    [SerializeField]
    protected float moveSpeed;
    [SerializeField]
    protected Transform cam;
    [SerializeField]
    protected CharacterController controller;

    // Update is called once per frame
    protected void Update() {
        
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float side = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");

        float turn = mouseX * Time.deltaTime * mouseSpeed;
        float tilt = mouseY * Time.deltaTime * mouseSpeed * -1;

        float x = side * moveSpeed * Time.deltaTime;
        float z = forward * moveSpeed * Time.deltaTime;

        cam.localEulerAngles += new Vector3(tilt, 0, 0);

        controller.Move(new Vector3(x, 0, z));

        controller.Rotate(new Vector3(0, turn, 0));

    }
}
