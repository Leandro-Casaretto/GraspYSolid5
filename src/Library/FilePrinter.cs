using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipe receta)  //Le pasamos la interfaz como argumento
        {
            File.WriteAllText("Recipe.txt", receta.GetTextToPrint());
        }
    }
}