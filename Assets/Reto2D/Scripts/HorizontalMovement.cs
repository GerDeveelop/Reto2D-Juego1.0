using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    private int previousWaypointIndex = 0; // Variable para guardar el índice del waypoint anterior

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        float distanceToWaypoint = Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position);

        if (distanceToWaypoint < .1f)
        {
            // Asigna el índice del waypoint actual al índice del waypoint anterior
            previousWaypointIndex = currentWaypointIndex;

            // Cambia al siguiente waypoint
            currentWaypointIndex++;

            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }

            // Gira el objeto 180 grados en el eje Z
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z += 180f;
            transform.eulerAngles = newRotation;
        }

        // Determina la dirección del movimiento
        Vector2 movementDirection = (waypoints[currentWaypointIndex].transform.position - waypoints[previousWaypointIndex].transform.position).normalized;

        // Mueve el objeto hacia el waypoint en la dirección correspondiente
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed * (distanceToWaypoint < .1f ? 1f : -1f));
    }
}
