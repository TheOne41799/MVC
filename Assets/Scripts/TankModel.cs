using UnityEngine;


public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;
    public TankTypes tankType;
    private Material color;


    public TankModel(float _movement, float _rotation, TankTypes _tankType, Material _color)
    {
        movementSpeed = _movement;
        rotationSpeed = _rotation;
        tankType = _tankType;
        color = _color;
    }

    public void SetTankController(TankController controller)
    {
        tankController = controller;
    }


    public Material GetColor()
    {
        return color;
    }
}
