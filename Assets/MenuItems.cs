using UnityEngine;
using UnityEngine.UI;

public class MenuItems : MonoBehaviour
{
    public Color hovercolor;
    public Color basecolor;
    public Image backgorund;

    GameObject Cube;
    void Start()
    {
        Cube = GameObject.Find("Cube");
        backgorund.color = basecolor;
    }

    public void Select()
    {
        backgorund.color = hovercolor;
        backgorund.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        Cube.GetComponent<MeshRenderer>().material.color = basecolor;
    }

    public void Deselect()
    {
        backgorund.color = basecolor;
        backgorund.transform.localScale = new Vector3(1, 1, 1);
    }
}
