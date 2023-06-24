System.Console.Write("From = ");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("To = ");
int m=Convert.ToInt32(Console.ReadLine());
for (int i=n; i<=m; i++){
    for (int j=1; j<=10; j++){
        System.Console.WriteLine($"{i}x{j}={i*j}");
    }
}