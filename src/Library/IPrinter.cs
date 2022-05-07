using System;

namespace Full_GRASP_And_SOLID.Library
{

    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}

// Personalmente, utilize el principio de polimorfismo,
// lo cual me permite que ConsolePrinter y FilePrinter 
// puedan utilizar el tipo IPrinter, para imprimir la receta.

