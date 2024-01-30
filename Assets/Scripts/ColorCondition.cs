using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorCondition : EndCondition
{
    private List<Color> _sphere = new();

    public ColorCondition(SphereFabric fablic) : base(fablic) { }

    protected override void AddSphere(Sphere sphere)
    {
        _sphere.Add(sphere.Color);
        sphere.Destroyed += Check;
    }

    protected override void Check(Sphere sphere)
    {
        _sphere.Remove(sphere.Color);

        if (_sphere.Contains(sphere.Color) == false)
        {
            RestartGame();
        }
    }
}
