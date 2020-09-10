﻿using UnityEngine;

internal class DescendToTarget : IState
{
    private readonly Drone _drone;

    public DescendToTarget(Drone drone)
    {
        _drone = drone;
    }

    public void Tick()
    {
    }

    public void OnEnter()
    {
        _drone.GoToPos(_drone.target.TargetPosition);
    }

    public void OnExit()
    {
        _drone.Stop();
        _drone.target.Build();
        _drone.target = null;
    }
}