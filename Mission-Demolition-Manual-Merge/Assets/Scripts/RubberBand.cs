using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RubberBand : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public GameObject launchPoint; 
    public GameObject projectile; 

    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2; 
        lineRenderer.startWidth = 0.05f; 
        lineRenderer.endWidth = 0.05f; 
        lineRenderer.material = new Material(Shader.Find("Sprites/Default")); 
        lineRenderer.startColor = Color.green; 
        lineRenderer.endColor = Color.green; 
    }

    void Update()
    {
        if (projectile != null && launchPoint != null)
        {

            lineRenderer.SetPosition(0, launchPoint.transform.position); 
            lineRenderer.SetPosition(1, projectile.transform.position); 
        }
        else
        {
            lineRenderer.enabled = false;
        }
    }

    public void SetProjectile(GameObject proj)
    {
        projectile = proj;
        lineRenderer.enabled = true; 
    }

    public void ReleaseProjectile()
    {
        projectile = null; 
        lineRenderer.enabled = false;
    }
}