using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sphere : MonoBehaviour
{
    public UnityAction<Sphere> Destroyed;

    public Color Color { get; private set; }

    private void OnMouseDown()
    {
        Destroyed?.Invoke(this);
        Destroy(gameObject);
    }

    public void Init(Color color)
    {
        Color = color;
        GetComponent<MeshRenderer>().material.color = color;
    }
}
