using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipe receta) //Le pasamos la interfaz como argumento
        {
            Console.WriteLine(receta.GetTextToPrint());
        }
        //De esta manera deja de depender de Recipe 
        //Hacemos que sea lo más abstracto posible
    }
}