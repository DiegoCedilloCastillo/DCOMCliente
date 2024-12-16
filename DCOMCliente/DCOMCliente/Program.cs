using System;

namespace DCOMCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Buscar el objeto COM por su ProgID
                Type tipoSaludo = Type.GetTypeFromProgID("DCOMServidor.Saludo");
                if (tipoSaludo == null)
                {
                    Console.WriteLine("No se pudo encontrar el objeto COM.");
                    return;
                }

                // Crear una instancia del objeto COM
                dynamic saludo = Activator.CreateInstance(tipoSaludo);

                // Llamar al método remoto Saludar
                string mensaje = saludo.Saludar("Diego");
                Console.WriteLine(mensaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}