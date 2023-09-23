using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs
{

    private static Playeractions _actions;

    private static Movement _owner;

    // Start is called before the first frame update
    public static void BindNewPlayer(Movement player)
    {
        _owner = player;
    }


    public static void Init(Movement Player){
        _actions = new Playeractions();
        _actions.Player.Look.performed += ctx => _owner.setlook(ctx.ReadValue<Vector2>());
        _actions.Player.Move.performed += ctx => _owner.MoveTo(ctx.ReadValue<Vector2>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
