using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Creamos un menu con el nombre de la clase. Así aparece en el menú de assets de Unity para ser creado 
[CreateAssetMenu(menuName = "State")]
//Cambiamos MonoBehaviour a ScriptableObject en esta clase
public class State : ScriptableObject
{
    //SerializeField permite que aparezca como recurso
    //TextArea() crea un area de texto en la interfaz de Unity del Scriptable Obj
    [TextArea(10,14)][SerializeField] string storyText;

}
