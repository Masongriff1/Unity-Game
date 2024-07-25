using Unity.VisualScripting;
using UnityEngine;

public class TankPawn : Pawn
{
    // Start is called before the first frame update
    void Start()
    {
        // base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        // base.Start();
    }

    public override void MoveForward()
    {
        Debug.Log("Move Forward");
        mover.Move(transform.forward, moveSpeed);
    }
    public override void MoveBackward()
    {
        Debug.Log("Move Backward");
        mover.Move(transform.forward, -moveSpeed);
    }
    public override void RotateClockwise()
    {
        Debug.Log("Rotate Clockwise");
        mover.Rotate(turnSpeed);
    }
    public override void RotateCounterClockwise()
    {
        Debug.Log("Rotate Counter-Clockwise");
        mover.Rotate(-turnSpeed);
    }
    public override void Shoot()
    {
        Debug.Log("Shot Tank");
        mover.ShootTank(bullet: GetComponent("UATank"), force: float.NaN);
        //spawnBullet.Summon(ammo: GetComponent("UATank"));
    }


}
