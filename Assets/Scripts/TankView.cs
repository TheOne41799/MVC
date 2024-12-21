using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float movementInput;
    private float rotationInput;

    [SerializeField] private Rigidbody rb;


    private void Start()
    {
        SetCameraFollow();
    }

    private void SetCameraFollow()
    {
        Camera cam = Camera.main;
        cam.gameObject.transform.SetParent(transform);
        cam.transform.position = new Vector3(0, 3f, -5f);
        cam.transform.rotation = Quaternion.Euler(15f, 0, 0);
    }

    private void Update()
    {
        Input();

        if (movementInput != 0) tankController.Move(movementInput, tankController.GetTankModel().movementSpeed);
        if (movementInput != 0 && rotationInput != 0) tankController.Rotate(rotationInput, tankController.GetTankModel().rotationSpeed);
    }


    private void Input()
    {
        movementInput = UnityEngine.Input.GetAxis("Vertical");
        rotationInput = UnityEngine.Input.GetAxis("Horizontal");
    }


    public void SetTankController(TankController controller)
    {
        tankController = controller;
    }


    public Rigidbody GetRigidbody()
    {
        return rb; 
    }
}
