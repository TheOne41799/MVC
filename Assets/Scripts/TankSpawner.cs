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


    public void CreateTank(TankTypes tankType)
    {
        TankModel tankModel;

        switch (tankType)
        {
            case TankTypes.GREEN_TANK:
                tankModel = new TankModel(tankTypes[0].movementSpeed, tankTypes[0].rotationSpeed, tankTypes[0].tankType, tankTypes[0].color);
                break;
            case TankTypes.BLUE_TANK:
                tankModel = new TankModel(tankTypes[1].movementSpeed, tankTypes[1].rotationSpeed, tankTypes[1].tankType, tankTypes[1].color);
                break;
            case TankTypes.RED_TANK:
                tankModel = new TankModel(tankTypes[2].movementSpeed, tankTypes[2].rotationSpeed, tankTypes[2].tankType, tankTypes[2].color);
                break;
            default:
                tankModel = new TankModel(tankTypes[0].movementSpeed, tankTypes[0].rotationSpeed, tankTypes[0].tankType, tankTypes[0].color);
                break;
        }
       
        TankController tankController = new TankController(tankModel, tankView);
    }
}
