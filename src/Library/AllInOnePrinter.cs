//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public enum Destination
    {
        Console,
        File
    }

    public class AllInOnePrinter
    {
        public void PrintRecipe(Recipe recipe, Destination destination)
        {
            if (destination == Destination.Console)
            {
                Console.WriteLine(recipe.GetTextToPrint());
            }
            else
            {
                File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
            }
        }
    }
}
/* La clase AllinOnePrinter tiene codigo tanto para 
 Destination.Console y otro para Destination.File.
 Para que este codigo cumpla ocn el patron de polimorfismo
en mi caso hago una interfaz llamada Iprinter. Luego hago los cambios necesarios donde AllInOnePrinter 
estaba para ser cambiado por IPrinter.
*/