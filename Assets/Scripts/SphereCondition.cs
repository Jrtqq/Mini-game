using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCondition : EndCondition
{
    private int _sphereCount;

    public SphereCondition(SphereFabric fablic) : base(fablic) { }

    protected override void AddSphere(Sphere sphere)
    {
        _sphereCount++;
        sphere.Destroyed += Check;
    }

    protected override void Check(Sphere sphere)
    {
        _sphereCount--;

        if (_sphereCount <= 0)
        {
            RestartGame();
        }
    }
}
