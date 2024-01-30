using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SphereFabric : MonoBehaviour
{
    public UnityAction<Sphere> Created;

    [SerializeField] private Sphere _spherePrefab;
    private Color[] _possibleColors = { Color.red, Color.blue, Color.green};

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            CreateSphere();
        }
    }

    public void CreateSphere()
    {
        Vector3 position = new(Random.Range(-5, 5), 0.5f, Random.Range(-5, 5));
        Color color = _possibleColors[Random.Range(0, _possibleColors.Length)];

        Sphere sphere = Instantiate(_spherePrefab, position, Quaternion.identity);
        sphere.Init(color);

        Created?.Invoke(sphere);
    }
}
