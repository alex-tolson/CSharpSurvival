using UnityEngine;

public class UserClick : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Cube"))
                {
                    ICommand click = new ClickCommand(hit.collider.gameObject, 
                        new Color(Random.value, Random.value, Random.value));

                    click.Execute();
                    CommandManager.Instance.AddClick(click);
                }
            }
        }    
    }


}
