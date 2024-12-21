using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }

    public List<Tank> tankTypes;

    [SerializeField] private TankView tankView;


    void Start()
    {
        CreateTank();    
    }


    private void CreateTank()
    {
        TankModel tankModel = new TankModel(tankTypes[0].movementSpeed, tankTypes[0].rotationSpeed, tankTypes[0].tankType, tankTypes[0].color);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
