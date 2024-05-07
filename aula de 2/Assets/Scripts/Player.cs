using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    private void OntriggersEnter2d(Collider2D colission)
    {
        if (colission.CompareTag("bullet"))
        {


            spriteRenderer.color = Color.cyan;


        }



    }


}
