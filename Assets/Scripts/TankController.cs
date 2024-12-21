using UnityEngine;


public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    private Rigidbody rb;


    public TankController(TankModel model, TankView view)
    {
        tankModel = model;
        tankView = GameObject.Instantiate<TankView>(view);
        rb = tankView.GetRigidbody();

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        tankView.ChangeColor(tankModel.GetColor());
    }


    public void Move(float movement, float movementSpeed)
    {
        rb.velocity = tankView.transform.forward * movement * movementSpeed;
    }


    public void Rotate(float rotation, float rotationSpeed)
    {
        Vector3 rotationVector = new Vector3(0, rotation * rotationSpeed, 0);
        Quaternion deltaRotation = Quaternion.Euler(rotationVector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }


    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
