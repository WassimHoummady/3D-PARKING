using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 5f;
    private ParkingSpot targetSpot;
    private bool isMoving = false;

    public GameObject explosionPrefab;

    void Update()
    {
        if (isMoving && targetSpot != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetSpot.transform.position,
                speed * Time.deltaTime
            );

            if (Vector3.Distance(transform.position, targetSpot.transform.position) < 0.2f)
            {
                ArriveAtSpot();
            }
        }
    }

    void OnMouseDown()
    {
        // Test simple console selection
        Debug.Log("Voiture sélectionnée: " + gameObject.name);
        // Ici on choisit un spot aléatoire pour tester
        ParkingSpot spot = ParkingManager.Instance.spots[Random.Range(0, ParkingManager.Instance.spots.Length)];
        GoToSpot(spot);
    }

    public void GoToSpot(ParkingSpot spot)
    {
        if (spot.state == ParkingState.Occupied)
        {
            Debug.Log("❌ Place occupée");
            return;
        }

        targetSpot = spot;
        isMoving = true;
    }

    void ArriveAtSpot()
    {
        isMoving = false;

        if (targetSpot.state == ParkingState.Reserved)
        {
            Debug.Log("💥 BOOM! Spot réservé");
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            targetSpot.SetState(ParkingState.Occupied);
            Debug.Log("🚗 Arrivé au spot " + targetSpot.spotID);
        }
    }
}
