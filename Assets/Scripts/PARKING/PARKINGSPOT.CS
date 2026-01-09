using UnityEngine;

public enum ParkingState
{
    Free,
    Reserved,
    Occupied
}

public class ParkingSpot : MonoBehaviour
{
    public int spotID;
    public ParkingState state = ParkingState.Free;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        UpdateColor();
    }

    public void SetState(ParkingState newState)
    {
        state = newState;
        UpdateColor();
    }

    void UpdateColor()
    {
        if (rend == null) return;

        switch (state)
        {
            case ParkingState.Free:
                rend.material.color = Color.green;
                break;
            case ParkingState.Reserved:
                rend.material.color = new Color(1f, 0.5f, 0f); // orange
                break;
            case ParkingState.Occupied:
                rend.material.color = Color.red;
                break;
        }
    }
}
