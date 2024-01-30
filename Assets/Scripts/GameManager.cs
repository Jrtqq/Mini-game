using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SphereFabric _fabric;
    [SerializeField] bool _conditionSelect;

    private EndCondition _condition;

    private void Awake()
    {
        if (_conditionSelect)
            _condition = new ColorCondition(_fabric);
        else
            _condition = new SphereCondition(_fabric);
    }
}
