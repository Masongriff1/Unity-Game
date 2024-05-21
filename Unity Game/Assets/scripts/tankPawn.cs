using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankPawn : pawn
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        base.Start();
    }

    public override void MoveForward()
    {
        Debug.Log("Move Forward");
    }
    public override void MoveBackward()
    {
        Debug.Log("Move Backward");
    }
    public override void RotateClockwise()
    {
        Debug.Log("Rotate Clockwise");
    }
    public override void RotateCounterClockwise()
    {
        Debug.Log("Rotate Counter-Clockwise");
    }


}
