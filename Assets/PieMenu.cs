using UnityEngine;

public class PieMenu : MonoBehaviour
{
    public Vector2 mousepos;
    public float angle;
    public int selection;

    private int previousselect;
    public GameObject[] Menu_Items;

    private MenuItems menuıtemscript;
    private MenuItems previousmenuıtemscript;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point,Color.green);
        }
        mousepos = hit.point;
        angle = Mathf.Atan2(mousepos.y, mousepos.x) * Mathf.Rad2Deg;
        angle = (angle + 360) % 360;
        selection = (int)angle / (45); //45 olmasının sebebi 8 alanımız var 360/8 = 45.


        if (selection != previousselect)
        {
            previousmenuıtemscript = Menu_Items[previousselect].GetComponent<MenuItems>();
            previousmenuıtemscript.Deselect();
            previousselect = selection;

            menuıtemscript = Menu_Items[selection].GetComponent<MenuItems>();
            menuıtemscript.Select();

        }
    }
}
