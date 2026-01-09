using UnityEngine;

public class ParkingManager : MonoBehaviour
{
    public static ParkingManager Instance;
    public ParkingSpot[] spots;

    void Awake()
    {
        Instance = this;
    }

    public ParkingSpot GetSpotByID(int id)
    {
        foreach (var s in spots)
            if (s.spotID == id)
                return s;
        return null;
    }

    // Retourne le premier spot libre
    public ParkingSpot GetFirstFreeSpot()
    {
        foreach (var s in spots)
            if (s.state == ParkingState.Free)
                return s;
        return null;
    }
}
