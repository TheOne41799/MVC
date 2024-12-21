using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    [SerializeField] private TankSpawner tankSpawner;


    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.GREEN_TANK);
        this.gameObject.SetActive(false);
    }
    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.BLUE_TANK);
        this.gameObject.SetActive(false);
    }

    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.RED_TANK);
        this.gameObject.SetActive(false);
    }
}
