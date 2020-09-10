﻿using UnityEngine;

internal class MoveToSupply : IState
{
    private readonly Drone _drone;

    public MoveToSupply(Drone drone)
    {
        _drone = drone;
    }

    public void Tick()
    {
    }

    public void OnEnter()
    {
        Debug.Log("move to supply");
        var pos = _drone.supply.GetDroneAssignedTransform(_drone).position;
        _drone.GoToPos(new Vector3(pos.x, _drone.transform.position.y, pos.z));
    }

    public void OnExit()
    {
        _drone.Stop();
    }
}