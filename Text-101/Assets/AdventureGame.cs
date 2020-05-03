using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Agregamos este namespace para poder usar Text.
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    //SerializeField permite tener esto disponible en nuestro inspector, así Unity solo sugiere objetos de tipo texto
    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        //Accedemos a la prop text del textcomponent
        textComponent.text = "En el año 2304 el vapor tomó la tierra";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
