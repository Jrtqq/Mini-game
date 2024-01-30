using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class EndCondition
{
    private SphereFabric _fabric;

    public EndCondition(SphereFabric fablic)
    {
        _fabric = fablic;
        _fabric.Created += AddSphere;
    }

    protected abstract void Check(Sphere sphere);

    protected abstract void AddSphere(Sphere sphere);

    protected void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
