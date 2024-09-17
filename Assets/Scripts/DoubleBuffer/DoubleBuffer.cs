using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBuffer : MonoBehaviour
{
    private Texture2D bufferA;
    private Texture2D bufferB;
    private bool isUsingBufferA = true;

    void Start()
    {
        bufferA = new Texture2D(256, 256);
        bufferB = new Texture2D(256, 256);
    }

    void Update()
    {
        if (isUsingBufferA)
        {
            UpdateTexture(bufferA);
            ApplyTexture(bufferA);
        }
        else
        {
            UpdateTexture(bufferB);
            ApplyTexture(bufferB);
        }

        // swap buffers
        isUsingBufferA = !isUsingBufferA;
    }

    void UpdateTexture(Texture2D texture)
    {
        // Simula la actualización de la textura
        Color color = new Color(Random.value, Random.value, Random.value);
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();
    }

    void ApplyTexture(Texture2D texture)
    {
        // Se aplica la textura en un objeto de la escena
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = texture;
    }
}
