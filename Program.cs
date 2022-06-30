/* int ShowQuart (int x, int y) 
{ 
        int result = -1; 

        if (x > 0 && y > 0) result = 1; 
        if (x < 0 && y > 0) result = 2; 
        if (x < 0 && y < 0) result = 3; 
        if (x > 0 && y < 0) result = 4; 
        return result; 
}   

Console.WriteLine("Введите координату x: "); 
int x0 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату y: "); 
int y0 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(ShowQuart(x0, y0));  

*/  

void Quad(int x) 
{ 
     int current = 1; 
     while (current <= x) 
     { 
        int quad = current * current; 
        Console.Write(quad + " "); 
        current++; 
     } 
} 

Console.WriteLine("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Quad(n); 