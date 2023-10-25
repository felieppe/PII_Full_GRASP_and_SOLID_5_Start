using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IPrinterText prText)
        {
            File.WriteAllText("Recipe.txt", prText.GetTextToPrint());
        }
    }
}