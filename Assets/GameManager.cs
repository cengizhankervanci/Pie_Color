using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PieMenu;

    void Start()
    {
        PieMenu.SetActive(false);
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            PieMenu.SetActive(true);  
        }


        if (Input.GetMouseButtonUp(0))
        {
            PieMenu.SetActive(false);
        }
    }

}
