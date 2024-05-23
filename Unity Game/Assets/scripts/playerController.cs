using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode MoveForward;
    public KeyCode MoveBackward;
    public KeyCode TurnClockwise;
    public KeyCode TurnCounterClockwise;
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        processInputs();
        base.Update();
    }
    public override void processInputs()
    {
        if (Input.GetKey(MoveForward))
        {
            pawn.MoveForward;
        }

        if (Input.GetKey(MoveBackward))
        {
            pawn.MoveBackward;
        }

        if (Input.GetKey(TurnClockwise))
        {
            pawn.RotateClockwise;
        }
        if (Input.GetKey(TurnCounterClockwise))
        {
            pawn.RotateCounterClockwise;
        }
    }
}
