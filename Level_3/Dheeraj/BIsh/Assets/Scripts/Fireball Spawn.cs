using UnityEngine;

public class FireballSpawn : MonoBehaviour
{
    public GameObject Fireball;
    public Transform spawnposition;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(Fireball, spawnposition.position, spawnposition.rotation);
        }
    }
}
