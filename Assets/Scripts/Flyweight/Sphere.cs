using UnityEngine;

public class Sphere
{
    private GameObject sphereModel;  
    private Vector3 position;

    public Sphere(GameObject model, Vector3 pos)
    {
        sphereModel = model;
        position = pos;

        GameObject.Instantiate(sphereModel, position, Quaternion.identity);
    }
}

