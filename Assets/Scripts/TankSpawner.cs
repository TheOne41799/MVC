using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private TankView tankView;


    void Start()
    {
        CreateTank();    
    }


    private void CreateTank()
    {
        TankModel tankModel = new TankModel(10, 90);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
