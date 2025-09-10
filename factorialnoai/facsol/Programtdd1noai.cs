using System;
using System.IO;

namespace facsol;

public class factorial {
    // public static long compute(int n) {
    //     if (n < 0) throw new Exception("negative");
    //     if (n == 0) return 1;
    //     return n * compute(n-1);
    // }

    public static long compute(int n) {
        if (n < 0) throw new Exception("negative");
        if (n == 0) return 1;
        long acc = 1;
        for (int i = n; i > 0; i--) {
            acc *= i;
        }
        return acc;
    }

}

public class Program {
    public static void Main(string[] args) {
        int? n = null;
       
        if (args.Length > 0) {
            try {
                n = int.Parse(args[0]);
            } catch {
                while (n == null) {
                    Console.Write("Input an int>\n");
                    try {
                        n = int.Parse(Console.ReadLine());

                    } catch (Exception e) {
                        continue;
                    }
                    Console.WriteLine();
                }
            }
        } else {
            while (n == null) {
                    Console.Write("Input an int>\n");
                    try {
                        n = int.Parse(Console.ReadLine());

                    } catch (Exception e) {
                        continue;
                    }
                    Console.WriteLine();
                }
        }
       

        string outstring = "";
        for (int i = 0; i < n+1; i++){
            outstring += $"{factorial.compute(i)}, {i}\n";
        }

        Console.WriteLine(outstring);

        // ugh why is it like this....
        using (StreamWriter writer = new("writeoutfile.txt")) {
            writer.WriteLine(outstring);
        }
    }
}