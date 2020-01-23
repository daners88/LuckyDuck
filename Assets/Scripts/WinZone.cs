using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject duckCount;
    public GameObject verdict;
    public GameObject player;
    public GameObject winScreen;
    public List<GameObject> butchers = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerController temp = other.gameObject.GetComponent<PlayerController>();
        if (temp != null)
        {
            foreach(var b in butchers)
            {
                b.GetComponent<Enemy>().chase = false;
            }
            UIManager.Instance.canMove = false;
            winScreen.SetActive(true);
            duckCount.GetComponent<UnityEngine.UI.Text>().text = temp.GetDucks().ToString();
            if (temp.GetDucks() > 3)
            {
                verdict.GetComponent<UnityEngine.UI.Text>().text = "You were a good Mama, and escaped with \n\n ducklings.";
            }
            else
            {
                verdict.GetComponent<UnityEngine.UI.Text>().text = "You were a crap Mama, and escaped with \n\n ducklings.";
            }
        }
    }
}
