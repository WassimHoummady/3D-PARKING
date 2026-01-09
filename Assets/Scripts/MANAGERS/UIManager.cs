using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public GameObject panel;
    public Text messageText;

    CarController selectedCar;

    void Awake()
    {
        Instance = this;
    }

    public void SelectCar(CarController car)
    {
        selectedCar = car;
        panel.SetActive(true);
    }

    public void ChooseSpot(int id)
    {
        ParkingSpot spot = ParkingManager.Instance.GetSpotByID(id);
        selectedCar.GoToSpot(spot);
        panel.SetActive(false);
    }

    public void ShowMessage(string msg)
    {
        messageText.text = msg;
    }
}
