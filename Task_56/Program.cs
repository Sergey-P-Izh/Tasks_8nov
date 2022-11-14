int n1, n2;
            int[,] A;
 
            Console.Write("Введите количество строк в матрице: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрице: ");
            n2 = int.Parse(Console.ReadLine());
            A = new int[n1, n2];
            Random rnd = new Random();
 
            // Присвоение значений датчиком случайных чисел
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < n2; j++)
                    A[i, j] = rnd.Next(-0, 10 + 1);
 
            //Вывод массива
            for (int i = 0; i < n1; i++, Console.WriteLine())
                for (int j = 0; j < n2; j++)
                    Console.Write(A[i, j] + "\t");

int minRowSum = int.MaxValue, indexMinRow = 0;
 
             for (int i = 0; i < n1; i++)
             {
                int rowSum = 0;
                for (int j = 0; j < n2; j++)
                    rowSum += A[i, j];
                
                if (rowSum < minRowSum)
                {
                    minRowSum = rowSum;
                    indexMinRow = i;
                }
             }
 
             Console.WriteLine("Строка с минимальной суммой элементов");
                 for(int j = 0;j<n2;j++)
                      Console.Write(A[indexMinRow, j] + "\t");                    