using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform character;

    float xRot = 0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        cursorLock();
    }

    // Update is called once per frame


    private void cursorLock ()
    {
        Cursor.lockState = CursorLockMode.Locked;


    }

    void Update()
    {
       cameraRotation();
        

    }



    private void cameraRotation()
    {
        float movX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float movY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRot -= movY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        character.Rotate(Vector3.up * movX);


    }


}
