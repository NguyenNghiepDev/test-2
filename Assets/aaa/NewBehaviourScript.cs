using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject a;
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(move);
    }
    public void move()
    {
        a.transform.position = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
