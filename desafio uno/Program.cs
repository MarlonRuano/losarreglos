using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program 
{
    static char[,] tablero = new char[3, 3];
    static char jugadorActual = 'X'; 

    static void Main(string[] args)
    {
        InicializarTablero();
        MostrarTablero();

        while (!JuegoTerminado())
        {
            Jugada();
            MostrarTablero();
            CambiarJugador();
        }

        Console.WriteLine("¡Juego terminado!");
        Console.ReadLine();
    }

    static void InicializarTablero()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tablero[i, j] = ' ';
            }
        }
    }

    static void MostrarTablero()
    {
        Console.WriteLine("-------------");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tablero[i, j] + " | ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------");
        }
    }

    static void Jugada()
    {
        Console.WriteLine($"Turno del jugador {jugadorActual}");
        Console.Write("Ingrese fila (0-2): ");
        int fila = int.Parse(Console.ReadLine());
        Console.Write("Ingrese columna (0-2): ");
        int columna = int.Parse(Console.ReadLine());

      
        if (tablero[fila, columna] == ' ')
        {
            tablero[fila, columna] = jugadorActual;
        }
        else
        {
            Console.WriteLine("¡Casilla ocupada! Intente de nuevo.");
            Jugada();
        }
    }

    static void CambiarJugador()
    {
        jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
    }

    static bool JuegoTerminado()
    {

        for (int i = 0; i < 3; i++)
        {
            if (tablero[i, 0] != ' ' && tablero[i, 0] == tablero[i, 1] && tablero[i, 1] == tablero[i, 2])
            {
                Console.WriteLine($"¡El jugador {jugadorActual} ha ganado!");
                return true;
            }
            if (tablero[0, i] != ' ' && tablero[0, i] == tablero[1, i] && tablero[1, i] == tablero[2, i])
            {
                Console.WriteLine($"¡El jugador {jugadorActual} ha ganado!");
                return true;
            }
        }

        if (tablero[0, 0] != ' ' && tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2])
        {
            Console.WriteLine($"¡El jugador {jugadorActual} ha ganado!");
            return true;
        }
        if (tablero[0, 2] != ' ' && tablero[0, 2] == tablero[1, 1] && tablero[1, 1] == tablero[2, 0])
        {
            Console.WriteLine($"¡El jugador {jugadorActual} ha ganado!");
            return true;
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (tablero[i, j] == ' ')
                    return false; 
            }
        }

        Console.WriteLine("¡Empate!");
        return true;
    }
}
