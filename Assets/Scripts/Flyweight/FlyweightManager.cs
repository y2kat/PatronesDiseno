using UnityEngine;
using System.Collections.Generic;

public class FlyweightManager : MonoBehaviour
{
    public GameObject spherePrefab; 
    public int numberOfSpheres = 50; 

    private List<Sphere> spheres = new List<Sphere>();

    void Start()
    {
        CreateBubbles();
    }

    void CreateBubbles()
    {
        for (int i = 0; i < numberOfSpheres; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-50, 50), 0, Random.Range(-50, 50));

            // Se crea una nueva sphere, compartiendo el mismo modelo
            Sphere newSphere = new Sphere(spherePrefab, randomPosition);
            spheres.Add(newSphere);
        }
    }
}

