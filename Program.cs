double distancia, tempo, velocidadeMedia;

Console.Write("Insira a distância percorrida, em metros: ");
distancia = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Insira o tempo gasto: ");
tempo = Convert.ToDouble(Console.ReadLine()!);

velocidadeMedia = distancia / tempo;

Console.WriteLine($"\nA sua velocidade média foi {velocidadeMedia:N2} m/s");