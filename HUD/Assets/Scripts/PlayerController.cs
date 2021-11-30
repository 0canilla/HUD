using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float Speed = 1.20f;
    float cameraX;
    float cameraY;
    float Sprint = 25f;
    public bool sprint = false;
    private GameObject hud;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprint = true;
        }
        else
        {
            sprint = false;
        }
        MyInput();
    }
    
    private void MyInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Move(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Move(Vector3.left);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Move(Vector3.back);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.right);
        }
    }
    private void Move(Vector3 direction)
    {
        
        if (sprint == true)
        {
            transform.Translate(Sprint * Time.deltaTime * direction);
        }
        else
        {
            transform.Translate(Speed * Time.deltaTime * direction);
        }
        
    }

    private void Rotate()
    {
        cameraX += Input.GetAxis("Mouse X");
        cameraY += Input.GetAxis("Mouse Y");
        Quaternion Angulo = Quaternion.Euler(-cameraY, cameraX, 0);
        transform.localRotation = Angulo;
    }
}
