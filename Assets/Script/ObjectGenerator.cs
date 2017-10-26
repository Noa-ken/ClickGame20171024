using UnityEngine;
using System.Collections;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject ObjectballPrefab;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Objectball = Instantiate(ObjectballPrefab) as GameObject;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            Objectball.GetComponent<ObjectController>().Shoot(worldDir.normalized * 2000);

        }

    }

}
