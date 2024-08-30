using System;

class Program
{
    static void Main()
    {
        
        int N = 10; 
        int[] array = new int[N]; 

       
        Console.WriteLine("Mảng ban đầu:");
        foreach (int element in array){
            Console.Write(element + " ");
        }
        Console.WriteLine();

        // Bước 1: Nhập X là số cần chèn
        Console.Write("Nhập giá trị chèn (X): ");
        int X = Convert.ToInt32(Console.ReadLine());

        // Bước 2: Nhập vào vị trí index cần chèn X vào trong mảng
        Console.Write("Nhập vị trí chèn (index): ");
        int index = Convert.ToInt32(Console.ReadLine());

        // Bước 3: Kiểm tra vị trí hợp lệ
        if (index < 0 || index > array.Length - 1)
        {
            Console.WriteLine("Không chèn được phần tử vào mảng.");
        }
        else
        {
            // Bước 4: Thực hiện chèn phần tử X ở vị trí index vào mảng
            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = X;

            // Bước 5: In ra mảng sau khi chèn
            Console.WriteLine("Mảng sau khi chèn:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
