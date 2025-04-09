using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladeriaLos3Gustos : MonoBehaviour
{
    //1. DEclaracion las Variables
    public string codigoGusto; // public string es para que sea publico y para palabras, codigoGusto es el nombre de la variable
    public int gramosHelado; // public string es para que sea publico y para numeros, codigoGusto es el nombre de la variable

    float precioPorMilGramos; 
    
    void Start()
    {
        /// 2. Ingreso Y Validacion de Datos

        if (gramosHelado < 250 || gramosHelado > 3000)
        {
            Debug.Log("Cantidad de helado no validad"); // Si no se cumple el if de mayor a 250g y menor a 3000g, con el Debug.Log devuelve el mesaje entre comillas adentro del parentisis
            return;
        }

    }

    
    void Update()
    {
        
    }
}
