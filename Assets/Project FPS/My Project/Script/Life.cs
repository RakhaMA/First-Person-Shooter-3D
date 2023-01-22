using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Life : MonoBehaviour
{
    public int life;

    public UnityEvent OnLifeReachZero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHit()
    {
        life = life - 1 < 0 ? 0 : life - 1;

        if (life <= 0)
        {
            OnLifeReachZero?.Invoke();
        }
    }
}
